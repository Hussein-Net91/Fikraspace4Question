<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstQ.aspx.cs" Inherits="FirstQuestion.FirstQ" %>

<!DOCTYPE html>

<head runat="server">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            height: 49px;
        }
        .auto-style3 {
            width: 214px;
        }
        .auto-style4 {
            width: 319px;
        }
        .auto-style5 {
            width: 100%;
            height: 352px;
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
        <div class="auto-style5">
           
        <div class="auto-style2">
            <table class="table-striped" style="width:100%;">
                <tr>
                    <td class="auto-style3">Insert User Id:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="UserId" runat="server" AutoPostBack="True" OnSelectedIndexChanged="UserId_SelectedIndexChanged" Width="191px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
<div class="row">
    <div class="col-sm-6" style="background-color:lavender;"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" Text="Veiw Comments" CommandName="1" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" CssClass="btn-success" />
                </ItemTemplate>
                    </asp:TemplateField>
                  
            <asp:BoundField DataField="userId" HeaderText="userId" />
            <asp:BoundField DataField="id" HeaderText="id" />
            <asp:BoundField DataField="title" HeaderText="title" />
            <asp:BoundField DataField="body" HeaderText="body" />
        </Columns>
        </asp:GridView>
    </div>
    <div class="col-sm-6" style="background-color:lavenderblush;"><asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="postId" HeaderText="postId" />
            <asp:BoundField DataField="id" HeaderText="id" />
            <asp:BoundField DataField="name" HeaderText="name" />
            <asp:BoundField DataField="email" HeaderText="email" />
            <asp:BoundField DataField="body" HeaderText="body" />
        </Columns>
        </asp:GridView></div>
  </div>
           
        </div>
    </div>
    <div class="footer">
        <p class="auto-style1"> FikraSpace</p>
    </div>
    </form>
</body>
