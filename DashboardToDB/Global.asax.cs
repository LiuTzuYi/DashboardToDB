using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using DevExpress.DashboardWeb.Designer;

namespace DashboardToDB
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // 存到 file
            DashboardFileStorage newDashboardStorage = new DashboardFileStorage(@"~/App_Data/dashboardFiles");
            // 存到 DB ?
            ASPxDashboardDesigner.Storage.SetDashboardStorage(newDashboardStorage);

        }
    }
}