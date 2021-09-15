<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePanel01.aspx.cs" Inherits="UpdatePanelExample.UpdatePanel01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
    <ContentTemplate>
    <% =DateTime.Now.ToString()%>
    <asp:Button ID="Button1" runat="server" Text="UpdatePanelButton" />
    </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Button ID="Button2" runat="server" Text="Button" />
    </form>
</body>
</html>
