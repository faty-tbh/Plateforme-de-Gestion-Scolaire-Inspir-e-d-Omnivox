<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ecrireMessage.aspx.cs" Inherits="prjWebCsAdoNet.ecrireMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        table{
            width: 500px;
            margin:auto;
            font-weight:bold;
            border-radius:15px;
            background-color:aquamarine;
            padding:2px;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center;">OMNIVOX - REDACTION MESSAGE</h1>
            <hr style="width:600px;" />
            <table>
                <tr>
                    <td>Destinataire : </td>
                    <td>
                        <asp:DropDownList ID="cboDestinataires" runat="server" Font-Bold="True" Width="300px"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Titre Message : </td>
                    <td>
                        <asp:TextBox ID="txtTitre" runat="server" Font-Bold="True" Width="300px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td style="vertical-align:top">Contenu Message : </td>
                    <td>
                        <asp:TextBox ID="txtMessage" runat="server" Font-Bold="True" TextMode="MultiLine" Width="300px" Height="100px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    
                    <td colspan="2">
                        <asp:Label runat="server" ID="lblErreur" Font-Bold="True" ForeColor="Red" Width="100%"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnEnvoyer" runat="server" Font-Bold="True" Text="Envoyer" Width="100px" OnClick="btnEnvoyer_Click" />
                    </td>
                    <td>
                         <asp:Button ID="btnEffacer" runat="server" Font-Bold="True" Text="Effacer" Width="100px" OnClick="btnEffacer_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
