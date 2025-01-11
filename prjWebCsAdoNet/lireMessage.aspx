<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lireMessage.aspx.cs" Inherits="prjWebCsAdoNet.lireMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style>
        h1{
            text-align:center;

        }
        hr{
            width:440px;
        }
        .hiphop{
            font-weight:bold;
            background-color:aqua;
            width:400px;
            height:400px;
            border-radius:15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>OMNIVOX-TECCART-MIO</h1>
            <hr />
        </div>
        <center>
        <asp:Label ID="lblMessage" runat="server" CssClass="hiphop" ></asp:Label>
            </center>
    </form>
</body>
</html>
