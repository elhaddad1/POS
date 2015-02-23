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
        public static bool Print(ReportDocument doc, int copies)
        {
            bool status = false;
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            string[] LoginData = ConfigurationManager.ConnectionStrings["Development"].ConnectionString.ToString().Split(';');

            if (!string.IsNullOrEmpty(LoginData[3].ToString()) && LoginData[3].ToString() != "")
            {
                crConnectionInfo.Password = LoginData[3].Split('=')[1].ToString();
            }
            crConnectionInfo.UserID = LoginData[2].Split('=')[1].ToString();
            crConnectionInfo.DatabaseName = LoginData[1].Split('=')[1];
            crConnectionInfo.ServerName = LoginData[0].Split('=')[1];
            CrTables = doc.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);

            }

            for (int i = 0; i < copies; i++)
            {
                doc.PrintToPrinter(1, true, 0, 0);
                status = true;
                // trace(" Done, Printing to" + ValidPrinterName);
            }

            return status;
        }
    }
}
