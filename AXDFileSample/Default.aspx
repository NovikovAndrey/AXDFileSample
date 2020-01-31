<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AXDFileSample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Use AXD</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <a href="/Images/">Images</a>
        <br />
        <a href="Images/view.axd">View AXD</a>
        <br />
        <a href="Images/Subfolder/view.axd">Sub View AXD</a>
        </div>
    </form>
</body>
</html>
