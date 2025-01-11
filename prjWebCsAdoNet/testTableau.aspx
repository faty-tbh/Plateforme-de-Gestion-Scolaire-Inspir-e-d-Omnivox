<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testTableau.aspx.cs" Inherits="prjWebCsAdoNet.testTableau" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><center>
            <asp:Table ID="tabEtudiants" runat="server" BackColor="Yellow" BorderStyle="Solid" GridLines="Horizontal" Font-Bold="True" Width="500px">
                <asp:TableRow runat="server" BackColor="#8AD9FF" BorderStyle="None">
                    <asp:TableCell runat="server">Titres</asp:TableCell>
                    <asp:TableCell runat="server">Envoyeurs</asp:TableCell>
                    <asp:TableCell runat="server">Actions</asp:TableCell>
                </asp:TableRow>
                
            </asp:Table>
            </center>
        </div>
    </form>
</body>
</html>
