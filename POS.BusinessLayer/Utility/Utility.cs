using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;
namespace POS.BusinessLayer.Utility
{
    public static class Utility
    {
        public static bool Print(string reportName, int copies, List<KeyValuePair<string, object>> Param_Values)
        {
            ReportDocument _reportDocument = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            bool status = false;
            _reportDocument.Load(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\Reports\\" + reportName);

            string[] LoginData = ConfigurationManager.ConnectionStrings["Development"].ConnectionString.ToString().Split(';');

            if (!string.IsNullOrEmpty(LoginData[3].ToString()) && LoginData[3].ToString() != "")
                crConnectionInfo.Password = LoginData[3].Split('=')[1].ToString();

            crConnectionInfo.UserID = LoginData[2].Split('=')[1].ToString();
            crConnectionInfo.DatabaseName = LoginData[1].Split('=')[1];
            crConnectionInfo.ServerName = LoginData[0].Split('=')[1];
            CrTables = _reportDocument.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            _reportDocument.Refresh();
            // set report Parameter
            if (Param_Values != null)
            {
                foreach (KeyValuePair<string, object> Param_Value in Param_Values)
                {
                    _reportDocument.SetParameterValue(Param_Value.Key, Param_Value.Value == null ? DBNull.Value : Param_Value.Value);
                }
            }
            for (int i = 0; i < copies; i++)
            {
                _reportDocument.PrintToPrinter(1, true, 0, 0);
                status = true;
            }
            return status;
        }
    }
}
