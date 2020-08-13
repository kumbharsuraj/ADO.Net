<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="School_web_page.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Student Informtion</h2>
            <table>
                <tr>
                    <td>EnquiryID</td>
                    <td><asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                    <asp:Button ID="btnLoad" runat="server" Text="LoadStudent" OnClick="btnLoad_Click"/>
                    <asp:GridView ID="gvId" runat="server"></asp:GridView>
               </tr>
                
                <tr>
                    <td>Parent Name</td>
                    <td><asp:TextBox ID="txtParent" runat="server"></asp:TextBox></td>
               </tr>
                
                <tr>
                    <td>Student Name</td>
                    <td><asp:TextBox ID="txtStudent" runat="server"></asp:TextBox></td>
               </tr>
                <tr>
                    <td>EmailId</td>
                    <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
               </tr>
                <tr>
                    <td>Contact No</td>
                    <td><asp:TextBox ID="txtContact" runat="server"></asp:TextBox></td>
               </tr>
                <tr>
                    <td>Address</td>
                    <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
               </tr>
            </table>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        </div>
    </form>
</body>
</html>
