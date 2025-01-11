<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inscrireomnivox.aspx.cs" Inherits="prjWebCsAdoNet.inscrireomnivox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            text-decoration: underline;
        }
        table {
            width: 410px;
            background-color: #F4630B;
            font-weight: bold;
            border-radius:15px;
        }
        .auto-style2 {
            width: 214px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1>&nbsp;INSCRIPTION DU MEMBRE</h1>
            
        </div>
    <table cellpadding="4" align="center">
        <tr>
            <td>Numero Adimission :</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtNum" runat="server" Font-Bold="True" ForeColor="Blue" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="reqNum" runat="server" ControlToValidate="txtNum" ErrorMessage="Numero etudiant Requis!" Font-Bold="True" ForeColor="White">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Année de Naissance :</td>
            <td id="txtAnneNaiss" class="auto-style2">
                <asp:TextBox ID="txtAnneNaiss" runat="server" Font-Bold="True" ForeColor="Blue" TextMode="Number" Width="50px"></asp:TextBox>
            </td>
            <td id="ReqAnneNaiss">
                <asp:RequiredFieldValidator ID="reqAnneNaiss" runat="server" ControlToValidate="txtAnneNaiss" ErrorMessage="Année de naissance Requise!" Font-Bold="True" ForeColor="White">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rngAnnee" runat="server" ControlToValidate="txtAnneNaiss" ErrorMessage="Annee doit etre entre 2007 et 1967." Font-Bold="True" ForeColor="White" MaximumValue="2007" MinimumValue="1967" Type="Integer">*</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>Email Personnel :</td>
            <td id="txtEmail" class="auto-style2">
                <asp:TextBox ID="txtEmail" runat="server" Font-Bold="True" ForeColor="Blue" Width="200px"></asp:TextBox>
            </td>
            <td id="reqEmail">
                <asp:RequiredFieldValidator ID="reqEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email Requis!" Font-Bold="True" ForeColor="White">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rgxEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Format Email Invalide!" Font-Bold="True" ForeColor="White" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Mot de passe : </td>
            <td id="txtMdp" class="auto-style2">
                <asp:TextBox ID="txtmdp" runat="server" Font-Bold="True" ForeColor="Blue" TextMode="Password" Width="200px"></asp:TextBox>
            </td>
            <td id="reqMdp">
                <asp:RequiredFieldValidator ID="reqMdp" runat="server" ControlToValidate="txtmdp" ErrorMessage="Mot de passe Requis!" Font-Bold="True" ForeColor="White">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Confirmer Mot-Passe :</td>
            <td id="txtCMdp" class="auto-style2">
                <asp:TextBox ID="txtmdp2" runat="server" Font-Bold="True" ForeColor="Blue" TextMode="Password" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="reqMdp2" runat="server" ControlToValidate="txtmdp2" ErrorMessage="Confirmation du Mot de passe Requis!" Font-Bold="True" ForeColor="White">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cmpMdp" runat="server" ControlToCompare="txtmdp2" ControlToValidate="txtmdp" ErrorMessage="les 2 mots de passe non identiques !" Font-Bold="True" ForeColor="White">*</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnInscrire" runat="server" Text="Inscrire" Width="150px" Font-Bold="True" OnClick="btnInscrire_Click" />
            </td>
            <td class="auto-style2">
                <asp:Button ID="btnReset" runat="server" Text="Recommencer" Width="150px" Font-Bold="True" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True" ForeColor="Aqua" Width="100%"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="White" />
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
