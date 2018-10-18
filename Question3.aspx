<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question3.aspx.cs" Inherits="FirstQuestion.Question3" %>

<!DOCTYPE html>

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
            width: 214px;
        }
        .auto-style4 {
            width: 319px;
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
            <table class="table-striped" style="width:100%;">
                <tr>
                    <td class="auto-style3">Insert Number:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="InNumber" runat="server" Width="214px">554545454</asp:TextBox>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert" Width="84px" />
                    </td>
                    <td>
                        <asp:TextBox ID="FinalNumber" runat="server" Width="382px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <div class="footer">
        <p class="auto-style1"> FikraSpace</p>
    </div>
    </form>
</body>
