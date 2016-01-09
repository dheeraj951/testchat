<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chatenvironment.aspx.cs" Inherits="chatenvironment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="txtchatwin" runat="server" Height="196px" TextMode="MultiLine" Width="564px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtchatip" runat="server" Width="206px"></asp:TextBox>
                    <asp:Button ID="btnsend" runat="server" OnClick="btnsend_Click" Text="Send" />
                    <asp:Button ID="btnclear" runat="server" OnClick="btnclear_Click" Text="Clear" />
                    <asp:Timer ID="Timer1" runat="server" Interval="7000" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    </asp:UpdatePanel>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
