<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MyASPProj.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="align-content:center">Welcome to ASP.NET</h1>

        <asp:Label ID="Username" runat="server" Text="Label">Username</asp:Label>
        &nbsp;&nbsp;<input id="Text1" type="text" id ="username"/>

        <br /><asp:Label ID="Password" runat="server" Text="Label">Password</asp:Label>
        &nbsp;&nbsp;<input type="password" id="password" />

        <br /><br /><input type="submit" id="submit" value="SUBMIT" />

    </div>
    </form>
</body>
</html>
