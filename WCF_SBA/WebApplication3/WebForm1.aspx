<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/bootstrap.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.js"></script>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-sm-6">
                
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="sup no"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" style="margin-left: 42px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="sup name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" style="margin-left: 16px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="supladder"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" style="margin-left: 12px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="create" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="edit" />
&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="delete" />
&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="getall" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="getby supno" />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    </form>
                </div>
            </div>
        </div>
    
</body>
</html>
