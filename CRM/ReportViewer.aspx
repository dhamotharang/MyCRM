﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportViewer.aspx.cs" Inherits="CRM.ReportViewer" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" HasCrystalLogo="False" AutoDataBind="false" HasToggleGroupTreeButton="False" EnableDatabaseLogonPrompt="False" HasDrilldownTabs="False" BestFitPage="True" DisplayStatusbar="false" EnableTheming="true"  EnableToolTips="true" EnableDrillDown="false" />

        </div>
    </form>
</body>
</html>
