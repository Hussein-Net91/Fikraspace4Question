<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LastQuestion.aspx.cs" Inherits="FirstQuestion.LastQuestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            height: 153px;
        }
        .auto-style3 {
            width: 109px;
        }
        .auto-style5 {
            width: 100%;
        }
        .auto-style7 {
            font-weight: bold;
            margin-right: 0px;
        }
        .auto-style8 {
            width: 201px;
        }
        .auto-style9 {
            width: 155px;
        }
        .auto-style11 {
            width: 149px;
        }
        .auto-style12 {
            width: 127px;
        }
        .auto-style13 {
            font-weight: bold;
        }
        .auto-style14 {
            width: 149px;
            text-align: left;
        }
        .auto-style15 {
            width: 149px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div class="page">
        <div class="header" style="background-image: url('Images/Untitled-1.jpg'); width: 100%;">
            <table style="width: 100%; height: 135px;">
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <div style="width: 100%" class="main">
           
        <div class="auto-style2">
            <table class="auto-style5" align="center">
                <tr>
                    <td class="auto-style12"><strong>Insert First List:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="FirstListTextBox" runat="server" Width="100%" CssClass="auto-style7" Height="100%">1,2,7,9,5,6,n,V</asp:TextBox>
                    </td>
                    <td class="auto-style9">Insert Second List:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="SecondListTextBox" runat="server" Width="100%" CssClass="auto-style13" Height="100%">4,9,5,6,N,l,8,6</asp:TextBox>
                    </td>
                    <td class="auto-style3">Final List:</td>
                    <td>
                        <asp:TextBox ID="FinalList" runat="server" Width="100%" CssClass="auto-style13" Height="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style8">
                        &nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style11">
                        &nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style8">
                        &nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style15">
                        <strong>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Marge" Width="84px" CssClass="auto-style13" />
                        </strong>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </div>
    <div class="footer">
        <p class="auto-style1"> <strong>FikraSpace</strong></p>
    </div>
    </form>
</body>
</html>
