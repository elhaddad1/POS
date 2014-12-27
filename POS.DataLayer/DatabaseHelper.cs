//
// Class	:	DatabaseHelper.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/27/2014 6:55:52 PM
//
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration ;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;

using System.Reflection;

namespace POS.DataLayer
{

    #region Enumerations

    public enum SupportedDatabases
    {
        SqlServer = 0,
        OleDb,
        Oracle,
        ODBC,
        ConfigurationDefined,
        SqlCe
    }

    public enum ConnectionState
    {
        KeepOpen, CloseOnExit
    }

    #endregion

    public class DatabaseHelper : IDisposable
    {
        [System.Runtime.InteropServices.DllImport("Rpcrt4.dll")]
        private static extern int UuidCreateSequential(ref Guid guid);

        #region Class Level Variables

        private string _connectionString = string.Empty;
        private DbConnection _newConnection = null;
        private DbCommand _newCommand = null;
        private DbProviderFactory _newFactory = null;
        private bool _shouldLogErrors = true;
        private string _errorLogFileName = "Generic DataAccess Error.log";
        private bool _isDisposed = false;

        #endregion

        #region Constants

        private const string DEFAULT_CONNECTION_STRING_KEY_NAME = "Production"; // default to using the production defined connection string
        private const string PROVIDER_SQL_SERVER_CLIENT = "System.Data.SqlClient";
        private const string PROVIDER_OLEDB_CLIENT = "System.Data.OleDb";
        private const string PROVIDER_ODBC_CLIENT = "System.Data.Odbc";
        private const string PROVIDER_SQL_CE_CLIENT = "System.Data.SqlServerCe";

        #endregion

        #region Constructors / Destructors

        /// <summary>
        /// This constructor allows an instance of the data access library to be created and cached
        /// assuming a valid connection string is provided along with the enumeration indicating 
        /// which database provider to utilize.  In the case of a standard application configuration 
        /// file not being utilized, this would be the constructor to use.
        /// </summary>
        ///
        /// <param name="connectionString" type = "string">The fully compliant .NET connection string</param>
        /// <param name="databaseToUse" type="SupportedDatabases">Indicates the type of database to connect with</param>
        ///
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author			      	  	Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public DatabaseHelper(SupportedDatabases databaseToUse, string connectionString)
        {
            CacheConnection(GetFactory(GetFactoryProviderName(databaseToUse)), connectionString);
        }


        /// <summary>
        /// This constructor allows an instance of the data access library to be created and cached with a connection string and database provider.
        /// It determines the type of database to instantiate by looking at the configuration section of the config file.
        /// </summary>
        ///
        /// <param name="configFileAndPath" type = "string">The path and file name containing the connection string defintion to be used.</param>
        /// <param name="configFileConnectionStringKeyName" type = "string">The key name in the config file that defines the connection string to be used.</param>
        /// 
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author			        		Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public DatabaseHelper(string configFileAndPath)
        {
            try
            {
                CacheConnection(GetFactory(ConnectionStringHelper.GetInfo(configFileAndPath).ProviderName), ConnectionStringHelper.GetInfo(configFileAndPath).ConnectionString);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

        }

        /// <summary>
        /// This constructor allows an instance of the data access library to be created and cached with a connection string and database provider.
        /// It determines the type of database to instantiate by looking at the configuration section of the config file.
        /// </summary>
        ///
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public DatabaseHelper()
        {
            try
            {
                CacheConnection(GetFactory(ConnectionStringHelper.GetInfo().ProviderName), ConnectionStringHelper.GetInfo().ConnectionString);
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

        }


        public void Dispose()
        {
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue 
            // and prevent finalization code for this object
            // from executing a second time.
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Executes in two distinct scenarios:
        // If isDisposed equals true, the method has been called directly
        // or indirectly by user's code. Managed and unmanaged resources
        // can be disposed.
        // If disposing equals false, the method has been called by the 
        // runtime from inside the finalizer and you should not reference 
        // other objects. Only unmanaged resources can be disposed.
        protected virtual void Dispose(bool isDisposing)
        {
            // Check to see if Dispose has already been called.
            if (!_isDisposed)
            {
                // If isDisposing equals true cleanup all managed and unmanaged resources.
                if (isDisposing)
                {
                    // Dispose managed resources.
                    _newConnection.Close();
                    _newConnection.Dispose();
                    _newCommand.Dispose();
                    _newCommand = null;
                    _newConnection = null;
                }

                // Call the appropriate methods to clean up 
                // unmanaged resources here.
                // If isDisposing is false, 
                // only the following code is executed.

            }
            _isDisposed = true;
        }

        #endregion

        #region Properties

        public bool ShouldLogErrors
        {
            get
            {
                return _shouldLogErrors;
            }
            set
            {
                _shouldLogErrors = value;
            }
        }

        public string ErrorLogFileName
        {
            get
            {
                return _errorLogFileName;
            }
            set
            {
                _errorLogFileName = value;
            }
        }

        public DbCommand Command
        {
            get
            {
                return _newCommand;
            }
        }

        public DbTransaction CurrentTransaction
        {
            get { return _newCommand.Transaction; }
        }

        #endregion

        #region Methods (Private)

        /// <summary>
        /// Creates a connection and caches it so that it can be used later to submit SQL.
        /// </summary>
        ///
        /// <param name="factory" type = "DbProviderFactory">The factory to create the connection against.</param>
        /// <param name="connectionString" type = "string">The connection string used to make the connnection to the database.</param>
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        private void CacheConnection(DbProviderFactory factory, string connectionString)
        {
            try
            {

                // create a connection using the built-in factory and cache
                // the command object.
                _connectionString = connectionString; // set class level instance and cache connection string
                _newFactory = factory;
                _newConnection = factory.CreateConnection();
                _newCommand = factory.CreateCommand();

                _newConnection.ConnectionString = connectionString;
                _newCommand.Connection = _newConnection;
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }
        }

        /// <summary>
        /// This method will return a factory instance of a specific database provider based on 
        /// the connection string defined in the ConnectionStrings section of the configuration file.
        /// </summary>
        ///
        /// <param name="connectStringsKeyName" type="string">The name of the connection string to retrieve from the ConnectionStrings section of the configuration file.</param>
        ///
        /// <returns>An instance of the specific factory object requested.</returns>
        /// 
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        private DbProviderFactory GetFactory(string providerName)
        {
            DbProviderFactory newFactory = null;

            try
            {
                //string providername = ConfigurationManager.ConnectionStrings[connectStringsKeyName].ProviderName;
                switch (providerName)
                {
                    case PROVIDER_SQL_SERVER_CLIENT:
                        newFactory = SqlClientFactory.Instance;
                        break;
                    case PROVIDER_OLEDB_CLIENT:
                        newFactory = OleDbFactory.Instance;
                        break;
                    case PROVIDER_ODBC_CLIENT:
                        newFactory = OdbcFactory.Instance;
                        break;

                }
            }
            catch (Exception ex)
            {
                ProcessException(ex);
            }

            return newFactory;

        }

        /// <summary>
        /// Creates an instance of the factory provider defined in the default connection string section.
        /// </summary>
        ///
        /// <returns>A database provider factory</returns>
        /// 
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        private DbProviderFactory GetFactory()
        {
            return GetFactory(DEFAULT_CONNECTION_STRING_KEY_NAME);
        }


        /// <summary>
        /// This method will determine the name of the identified enumerated database.
        /// </summary>
        ///
        /// <param name="databaseToUse" type="SupportedDatabases">The enumeration of the database in which to find it's name.</param>
        ///
        /// <returns>The name of the database factory provider.</returns>
        /// 
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        private string GetFactoryProviderName(SupportedDatabases databaseToUse)
        {
            string newFactoryName = string.Empty;

            switch (databaseToUse)
            {
                case SupportedDatabases.SqlServer:
                    newFactoryName = "System.Data.SqlClient";
                    break;

                case SupportedDatabases.OleDb:
                    newFactoryName = "System.Data.OleDb";
                    break;

                case SupportedDatabases.Oracle:
                    newFactoryName = "System.Data.OracleClient";
                    break;

                case SupportedDatabases.ODBC:
                    newFactoryName = "System.Data.Odbc";
                    break;
                case SupportedDatabases.SqlCe:
                    newFactoryName = "System.Data.SqlServerCe";
                    break;
            }

            return newFactoryName;
        }


        /// <summary>
        /// This method determines if an exception should be recorded, records it (if needed) and rethrows the exception.
        /// </summary>
        ///
        /// <param name="databaseToUse" type="SupportedDatabases">The enumeration of the database in which to find it's name.</param>
        /// 
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        private void ProcessException(Exception ex)
        {
            if (ShouldLogErrors)
            {
                if (ex != null)
                    WriteToLog(ex.Message);
                else
                    WriteToLog("Exception could not be logged because it was NULL");
            }

            throw ex;   // rethrow error
        }

        /// <summary>
        /// This method writes the given text to a text file.
        /// </summary>
        ///
        /// <param name="text" type="string">The information to write to the file.</param>
        /// 
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        private void WriteToLog(string text)
        {
            try
            {
                StreamWriter writer = File.AppendText(ErrorLogFileName);
                writer.WriteLine(DateTime.Now.ToString("yyyy/MM/dd hh:mm") + " - " + text);
                writer.Close();
            }
            catch
            {
                // if we can't log the error then eat the exception and continue.
            }

        }

        //private void DeriveParameters()
        //{
        //    _newFactory.de
        //}

        #endregion

        #region Methods (Public)

        /// <summary>
        /// This method generates a sequential GUID.
        /// </summary>
        ///
        /// <returns>A sequential GUID.</returns>
        /// 
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public static string GetSequentialGUID()
        {
            Guid newGuid = new Guid();
            int returnValue = UuidCreateSequential(ref newGuid);
            return newGuid.ToString();
        }


        // ------------------------------------
        // Explicit Transaction Related Methods
        // ------------------------------------

        /// <summary>
        /// Marks the beginning of a transaction with a default Isolation Level of ReadUncommited.
        /// </summary>
        ///
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public void BeginTransaction()
        {
            BeginTransaction(IsolationLevel.ReadCommitted);
        }

        /// <summary>
        /// Marks the beginning of a transaction.
        /// </summary>
        ///
        /// <param name="isolationLevel" type="IsolationLevel">The locking level in which to run this transaction.</param>
        /// 
        ///	<remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public void BeginTransaction(IsolationLevel isolationLevel)
        {
            if (_newConnection.State == System.Data.ConnectionState.Closed)
            {
                _newConnection.Open();
            }
            if (_newCommand.Transaction == null) _newCommand.Transaction = _newConnection.BeginTransaction(isolationLevel);
        }


        public void CommitTransaction()
        {
            _newCommand.Transaction.Commit();
            _newConnection.Close();
        }

        public void RollbackTransaction()
        {
            _newCommand.Transaction.Rollback();
            _newConnection.Close();
        }


        // -------------------------
        // Parameter Related Methods
        // -------------------------

        /// <summary>
        /// Creates a new parameter on the current factory.
        /// </summary>
        ///	
        /// <returns>A DbParameter object representing a parameter to pass to a stored procedure.</returns>
        /// 
        /// <remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public DbParameter CreateParameter()
        {
            return _newFactory.CreateParameter();
        }

        /// <summary>
        /// Adds a parameter to the call list prior to executing a stored procedure.
        /// </summary>
        ///
        /// <param name="parameter" type="DbParameter">The parameter to pass to the stored procedure.</param>
        ///	
        /// <returns>An integer representing the number of parameters added to the collection.</returns>
        /// 
        /// <remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public int AddParameter(DbParameter parameter)
        {
            return _newCommand.Parameters.Add(parameter);
        }

        /// <summary>
        /// Adds a parameter to the call list prior to executing a stored procedure.
        /// </summary>
        ///
        /// <param name="name" type="string">The name of the parameter as defined in the stored procedure.</param>
        /// <param name="value" type="object">The value of the parameter to pass to the stored procedure.</param> 
        /// 
        ///	
        /// <returns>An integer representing the number of parameters currently in the collection.</returns>
        /// 
        /// <remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public int AddParameter(string name, object value)
        {
            int result = 0;
            DbParameter p = _newFactory.CreateParameter();

            p.ParameterName = name;
            p.Value = value;

            result = _newCommand.Parameters.Add(p);
            return result;
        }

        /// <summary>
        /// Adds a parameter to the current command parameters collection.
        /// </summary>
        ///	
        /// <param name="name" type="">The name of the parameter to add to the collection.</param>
        /// <param name="value" type="">The value of the parameter.</param>
        /// <param name="dataType" type="">The data type the parameter.</param>
        /// <param name="direction" type="">The direction the variable.</param>
        /// 
        /// <returns>The number of parameters in the collection.</returns>
        /// 
        /// <remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		    Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public int AddParameter(string name, object value, DbType dataType, ParameterDirection direction)
        {
            int result = 0;
            DbParameter p = _newFactory.CreateParameter();

            p.ParameterName = name;
            p.Value = value;
            p.Direction = direction;
            p.DbType = dataType;

            result = _newCommand.Parameters.Add(p);

            return result;
        }

        /// <summary>
        /// Adds a parameter to the current command parameters collection.
        /// </summary>
        ///	
        /// <param name="name" type="">The name of the parameter to add to the collection.</param>
        /// <param name="value" type="">The value of the parameter.</param>
        /// <param name="dataType" type="">The data type the parameter.</param>
        /// 
        /// <returns>The number of parameters in the collection.</returns>
        /// 
        /// <remarks>
        ///	
        /// <RevisionHistory>
        /// Author					        Date		    Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public int AddParameter(string name, object value, DbType dataType)
        {
            int result = 0;
            DbParameter p = _newFactory.CreateParameter();

            p.ParameterName = name;
            p.Value = value;
            p.DbType = dataType;

            result = _newCommand.Parameters.Add(p);

            return result;
        }

        /// <summary>
        /// Adds a parameter to the current command parameters collection.
        /// </summary>
        ///	
        /// <param name="name" type="">The name of the parameter to add to the collection.</param>
        /// <param name="value" type="">The value of the parameter.</param>
        /// <param name="direction" type="">The direction the variable.</param>
        /// 
        /// <returns>The number of parameters in the collection.</returns>
        /// 
        /// <remarks>
        ///	
        /// <RevisionHistory>
        /// Author			        		Date		          Description
        /// DLGenerator		12/27/2014 6:55:52 PM			Created function
        /// 
        /// </RevisionHistory>
        /// 
        /// </remarks>
        public int AddParameter(string name, object value, ParameterDirection direction)
        {
            int result = 0;
            DbParameter p = _newFactory.CreateParameter();

            p.ParameterName = name;
            p.Value = value;
            p.Direction = direction;

            result = _newCommand.Parameters.Add(p);

            return result;
        }


        // ------------------------
        // NonQuery Related Methods
        // ------------------------

        public int ExecuteNonQuery(string spName)
        {
            bool executionSucceeded = false;
            return ExecuteNonQuery(spName, CommandType.StoredProcedure, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public int ExecuteNonQuery(string spName, ref bool executionSucceeded)
        {
            return ExecuteNonQuery(spName, CommandType.StoredProcedure, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public int ExecuteNonQuery(string sqlStatement, CommandType commandType)
        {
            bool executionSucceeded = false;
            return ExecuteNonQuery(sqlStatement, commandType, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public int ExecuteNonQuery(string sqlStatement, CommandType commandType, ref bool executionSucceeded)
        {
            return ExecuteNonQuery(sqlStatement, commandType, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public int ExecuteNonQuery(string sqlStatement, CommandType commandType, ConnectionState connectionState, ref bool executionSucceeded)
        {
            _newCommand.CommandText = sqlStatement;
            _newCommand.CommandType = commandType;
            int i = 0;
            try
            {
                if (_newConnection.State == System.Data.ConnectionState.Closed)
                {
                    _newConnection.Open();
                }
                i = _newCommand.ExecuteNonQuery();
                executionSucceeded = true;
            }
            catch (Exception ex)
            {
                executionSucceeded = false;
                ProcessException(ex);
            }
            finally
            {
                _newCommand.Parameters.Clear();
                if (connectionState == ConnectionState.CloseOnExit && _newCommand.Transaction == null)
                {
                    _newConnection.Close();
                }
            }

            return i;
        }



        // ----------------------
        // Scalar Related Methods
        // ----------------------

        public object ExecuteScalar(string spName)
        {
            bool executionSucceeded = false;
            return ExecuteScalar(spName, CommandType.StoredProcedure, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public object ExecuteScalar(string spName, ref bool executionSucceeded)
        {
            return ExecuteScalar(spName, CommandType.StoredProcedure, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public object ExecuteScalar(string sqlStatement, CommandType commandType)
        {
            bool executionSucceeded = false;
            return ExecuteScalar(sqlStatement, commandType, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public object ExecuteScalar(string sqlStatement, CommandType commandType, ref bool executionSucceeded)
        {
            return ExecuteScalar(sqlStatement, commandType, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public object ExecuteScalar(string sqlStatement, CommandType commandType, ConnectionState connectionState, ref bool executionSucceeded)
        {
            _newCommand.CommandText = sqlStatement;
            _newCommand.CommandType = commandType;
            object result = null;
            try
            {
                if (_newConnection.State == System.Data.ConnectionState.Closed)
                {
                    _newConnection.Open();
                }
                result = _newCommand.ExecuteScalar();
                executionSucceeded = true;

            }
            catch (Exception ex)
            {
                executionSucceeded = false;
                ProcessException(ex);
            }
            finally
            {
                _newCommand.Parameters.Clear();
                if (connectionState == ConnectionState.CloseOnExit)
                {
                    _newConnection.Close();
                }
            }

            return result;
        }


        // -----------------------------
        // ExecuteReader Related Methods
        // -----------------------------

        public DbDataReader ExecuteReaderUsingSQL(string sqlStatement)
        {
            bool executionSucceeded = false;
            return ExecuteReader(sqlStatement, CommandType.Text, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DbDataReader ExecuteReaderUsingSQL(string sqlStatement, ref bool executionSucceeded)
        {
            return ExecuteReader(sqlStatement, CommandType.Text, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DbDataReader ExecuteReader(string spName)
        {
            bool executionSucceeded = false;
            return ExecuteReader(spName, CommandType.StoredProcedure, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DbDataReader ExecuteReader(string spName, ref bool executionSucceeded)
        {
            return ExecuteReader(spName, CommandType.StoredProcedure, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DbDataReader ExecuteReader(string sqlStatement, CommandType commandType)
        {
            bool executionSucceeded = false;
            return ExecuteReader(sqlStatement, commandType, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DbDataReader ExecuteReader(string sqlStatement, CommandType commandType, ref bool executionSucceeded)
        {
            return ExecuteReader(sqlStatement, commandType, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DbDataReader ExecuteReader(string sqlStatement, CommandType commandType, ConnectionState connectionState, ref bool executionSucceeded)
        {
            _newCommand.CommandText = sqlStatement;
            _newCommand.CommandType = commandType;
            DbDataReader reader = null;

            try
            {
                if (_newConnection.State == System.Data.ConnectionState.Closed)
                {
                    _newConnection.Open();
                }
                if (connectionState == ConnectionState.CloseOnExit)
                {
                    reader = _newCommand.ExecuteReader(CommandBehavior.CloseConnection);
                }
                else
                {
                    reader = _newCommand.ExecuteReader();
                }
                executionSucceeded = true;

            }
            catch (Exception ex)
            {
                executionSucceeded = false;
                ProcessException(ex);
            }
            finally
            {
                _newCommand.Parameters.Clear();
            }

            return reader;
        }

        public DataSet ExecuteDataSet(string spName)
        {
            bool executionSucceeded = false;
            return ExecuteDataSet(spName, CommandType.StoredProcedure, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DataSet ExecuteDataSet(string spName, ref bool executionSucceeded)
        {
            return ExecuteDataSet(spName, CommandType.StoredProcedure, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DataSet ExecuteDataSet(string sqlStatement, CommandType commandType)
        {
            bool executionSucceeded = false;
            return ExecuteDataSet(sqlStatement, commandType, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DataSet ExecuteDataSet(string sqlStatement, CommandType commandType, ref bool executionSucceeded)
        {
            return ExecuteDataSet(sqlStatement, commandType, ConnectionState.CloseOnExit, ref executionSucceeded);
        }

        public DataSet ExecuteDataSet(string sqlStatement, CommandType commandType, ConnectionState connectionState, ref bool executionSucceeded)
        {
            DataSet result = new DataSet();
            DbDataAdapter adapter = _newFactory.CreateDataAdapter();

            _newCommand.CommandText = sqlStatement;
            _newCommand.CommandType = commandType;
            adapter.SelectCommand = _newCommand;

            try
            {
                adapter.Fill(result);
                executionSucceeded = true;
            }
            catch (Exception ex)
            {
                executionSucceeded = false;
                ProcessException(ex);
            }
            finally
            {
                _newCommand.Parameters.Clear();
                if (connectionState == ConnectionState.CloseOnExit)
                {
                    if (_newConnection.State == System.Data.ConnectionState.Open)
                    {
                        _newConnection.Close();
                    }
                }
            }
            return result;
        }
        #endregion

    }


    #region Internal Classes

    /// <summary>
    /// This class allows us to define our connection string once and reuse it
    /// across calls to the database.
    /// </summary>
    internal static class ConnectionStringHelper
    {
        private static ConnectionInfo _connectionInfo = new ConnectionInfo();

        internal struct ConnectionInfo
        {
            public string ConnectionString;
            public string ProviderName;
        }

        public static ConnectionInfo GetInfo()
        {
            return GetInfo(string.Empty);
        }

        public static bool IsConnectionStringLoaded()
        {
            return (_connectionInfo.ConnectionString != null && _connectionInfo.ConnectionString.Length > 0);
        }

        public static ConnectionInfo GetInfo(string configFileAndPath)
        {

            if (_connectionInfo.ConnectionString != null)
            {
                // if the connection information has already been retrieved
                // then return it so we don't have to read the config file 
                // again.
                return _connectionInfo;
            }
            else
            {

                // Our static variable is empty so we need to find our config
                // file (or use what was passed in) and load the appropriate 
                // connection string and provider.  For web apps, the config file
                // could exist as the 'web.config' but for windows apps, it would 
                // app.config where 'app' is replaced with the name of the actual
                // application executable name.
                try
                {
                    if (configFileAndPath.Trim().Length == 0)
                    {
                        // If the file does not exist then try and find one...
                        if (!System.IO.File.Exists(configFileAndPath))
                        {
                            // First, we will look for the default ignyte data layer generator config file
                            // in the bin directory of the application's base directory.  If it is
                            // not there, we will look in the root directory.
                            configFileAndPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "bin", "POS.DataLayer.config");
                            if (File.Exists(configFileAndPath) == false)
                                configFileAndPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "POS.DataLayer.config");

                            // If the file still does not exists, then we might be dealing with a web application
                            // which will store it's settings in the web.config file.
                            if (File.Exists(configFileAndPath) == false)
                                configFileAndPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "web.config");

                            // If the file still cannot be found, then it could be using it's own app.config file.  
                            // The 'app' portion of the name will need to be changed to match the name of the application.
                            if (File.Exists(configFileAndPath) == false)
                                configFileAndPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app.config");
                        }
                    }

                    // Make sure the file exists.
                    if (System.IO.File.Exists(configFileAndPath))
                    {
                        ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                        Configuration configFile = null;
                        string keyToUse = string.Empty;

                        fileMap.ExeConfigFilename = configFileAndPath;
                        configFile = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

                        keyToUse = configFile.AppSettings.Settings["ConnectionStringToUse"].Value;

                        _connectionInfo.ConnectionString = configFile.ConnectionStrings.ConnectionStrings[keyToUse].ConnectionString;
                        _connectionInfo.ProviderName = configFile.ConnectionStrings.ConnectionStrings[keyToUse].ProviderName;
                    }
                    else
                    {
                        throw new ConfigurationErrorsException();
                    }

                    //

                }
                catch (ConfigurationErrorsException ex)
                {
                    // determine if the data access config file even exists as
                    // this might be the problem.

                    if (!System.IO.File.Exists(configFileAndPath))
                    {
                        throw new System.IO.FileNotFoundException("The data access configuration file (" + configFileAndPath + ") was not found.  Please copy this file to the same location as the Generic Data Access DLL.", ex);
                    }
                    else
                    {
                        throw;
                    }

                }
                catch (Exception)
                {
                    throw;
                }

                return _connectionInfo;
            }

        }

    }
    #endregion
}
