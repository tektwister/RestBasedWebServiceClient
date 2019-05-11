<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeFile="MyForm.aspx.cs" Inherits="MyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="click" OnClick="Button1_Click" />
        </p>
        
        <asp:Label ID="Label2" runat="server" Text="Value1"></asp:Label>&nbsp;&nbsp;  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Value2"></asp:Label>&nbsp;&nbsp;   <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Label4" runat="server" Text="Result"></asp:Label> &nbsp;&nbsp;  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />


    </form>
</body>
</html>
