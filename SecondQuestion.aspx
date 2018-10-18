<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondQuestion.aspx.cs" Inherits="FirstQuestion.SecondQuestion" %>

<!DOCTYPE html>

<head runat="server">
   
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            height: 103px;
        }
        .auto-style3 {
            width: 100%;
            height: 126px;
        }
        .auto-style4 {
            width: 100%;
            height: 35px;
        }
        .auto-style5 {
            width: 62px;
        }
        .auto-style6 {
            width: 56px;
        }
        .auto-style7 {
            width: 161px;
        }
        .auto-style9 {
            width: 354px;
        }
        .auto-style10 {
            font-weight: bold;
        }
        .auto-style11 {
            font-weight: bold;
            margin-left: 0px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
<div class="page">
        <div class="auto-style3" style="background-image: url('Images/Untitled-1.jpg'); ">
            </div>
            <div class="Info">
        <fieldset class="register">
            <legend >Results of Question Two</legend>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="788px">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" />
                    <asp:BoundField DataField="age" HeaderText="age" />
                    <asp:BoundField DataField="year" HeaderText="year" />
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Film" HeaderText="Film" />
                    <asp:BoundField DataField="NumberofOscar" HeaderText="NumberofOscar" />
                </Columns>
            </asp:GridView>
        </fieldset>
            </div>

            <table class="auto-style4">
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style5">
                        <strong>
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style11" OnClick="Button1_Click" Text=" Oldest Actor" Width="108px" />
                        </strong></td>
                    <td class="auto-style6">
                        <strong>
                        <asp:Button ID="Button3" runat="server" CssClass="auto-style11" OnClick="Button2_Click" Text="More than One Oscar" Width="148px" />
                        </strong></td>
                    <td class="auto-style7">
                        <strong>
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style10" OnClick="Button3_Click" Text="High Win of Oscars " Width="127px" />
                        </strong></td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <div class="auto-style4">
           
        <div class="auto-style2">
        </div>
    </div>
    <div class="footer">
        <p class="auto-style1"> FikraSpace</p>
    </div>
    </form>
</body>