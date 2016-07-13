<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DashboardToDB.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v15.2.Web, Version=15.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb.Designer" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Dashboard.v15.2.Web, Version=15.2.11.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDashboardDesigner ID="ASPxDashboardDesigner1" runat="server"></dx:ASPxDashboardDesigner>
    </div>
    </form>
</body>
</html>
