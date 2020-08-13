<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="School.aspx.cs" Inherits="School_web_page.School" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   
            <div>
        <h2>StudentList</h2>

        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Fetch Student" OnClick="btnSubmit_Click" />
       
        
        <asp:GridView ID="gvStudent" runat="server"></asp:GridView>
    
    </div>


    </form>
</body>
</html>
