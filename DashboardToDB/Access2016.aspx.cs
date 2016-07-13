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
    public partial class Access2016 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new access 2016 connection
            Access2007ConnectionParameters access2007Params = new Access2007ConnectionParameters();
            access2007Params.FileName = Server.MapPath(@"~\App_Data\nwind.accdb");

            //create dashboard data source
            DashboardSqlDataSource access2007DataSource = new DashboardSqlDataSource("MS Access 2016 資料庫 新版",access2007Params);
            CustomSqlQuery query1 = new CustomSqlQuery("自訂的查詢一", "select * from Employees");
            access2007DataSource.Queries.Add(query1);

            //create dashboard storage
            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
            dataSourceStorage.RegisterDataSource("MS Access 2016 資料庫 新版", access2007DataSource);
            ASPxDashboardDesigner.Storage.SetDataSourceStorage(dataSourceStorage);
        }
    }
}