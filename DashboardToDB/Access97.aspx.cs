using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.DashboardWeb.Designer;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;

namespace DashboardToDB
{
    public partial class Access97 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new access97 connection
            Access97ConnectionParameters access97Params = new DevExpress.DataAccess.ConnectionParameters.Access97ConnectionParameters();
            access97Params.FileName = Server.MapPath(@"~\App_Data\nwind.mdb");

            //create dashboard data source
            DashboardSqlDataSource access97DataSource = new DashboardSqlDataSource("MS Office Access 97 舊版", access97Params);
            CustomSqlQuery query2 = new CustomSqlQuery("自訂的查詢二","select * from Employees");
            access97DataSource.Queries.Add(query2);

            //create dashboard storage
            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
            dataSourceStorage.RegisterDataSource("MS Office Access 97 舊版", access97DataSource);
            ASPxDashboardDesigner.Storage.SetDataSourceStorage(dataSourceStorage);
        }
    }
}