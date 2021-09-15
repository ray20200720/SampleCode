<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01.aspx.cs" Inherits="Project_MIS2000LAB.Ch03._01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
            <input type="submit" value="submit" />
            <input type="button" value="button"/>
            <asp:Button ID="Button1" runat="server" Text="ASP Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
