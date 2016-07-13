using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using DevExpress.DashboardWeb.Designer;
using System.Data;
using System.IO;
using DevExpress.DashboardCommon;


namespace DashboardToDB
{

    public class DataBaseDashboardStorage : IDashboardStorage
    {
        Dashboard tableAdapter = new Dashboard();
        
        public DataBaseDashboardStorage() : base() {

        }
        public string CreateNewDashboard() {
            return "cc";
        }
        XDocument IDashboardStorage.GetDashboard(string id) {
            return new XDocument();
        }
        public IEnumerable<string> IDashboardStorage.GetDashboardIDs() {


        }
        void IDashboardStorage.UpdateDashboard(string id, XDocument document) {

        }

    }

}