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
    public partial class MSSQL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsSqlConnectionParameters mssqlParam = new MsSqlConnectionParameters();
            mssqlParam.AuthorizationType = MsSqlAuthorizationType.SqlServer;
            mssqlParam.ServerName = ".";
            mssqlParam.DatabaseName = "Northwind";
            mssqlParam.UserName = "sa";
            mssqlParam.Password = "honeytea";

            DashboardSqlDataSource mssqlDatasource = new DashboardSqlDataSource("MS SQL 2K16 Data Source", mssqlParam);
            CustomSqlQuery query3 = new CustomSqlQuery("自訂的查詢三", "select * from [order details]");
            mssqlDatasource.Queries.Add(query3);

            DataSourceInMemoryStorage datasourceStorage = new DataSourceInMemoryStorage();
            datasourceStorage.RegisterDataSource("MS SQL 2K16 Data Source",mssqlDatasource);
            ASPxDashboardDesigner.Storage.SetDataSourceStorage(datasourceStorage);



        }
    }
}