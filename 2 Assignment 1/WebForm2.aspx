<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_2_Assignment_1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Fetch Trainer" onclick="Btn1_Click"/>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br /> 
        <asp:GridView ID="gvEmployee" runat="server"></asp:GridView>
    </div>
        <div>
            <table>
                <tr>
                    <td>Id:</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                     
                    </td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="txtName1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Salary:</td>
                    <td>
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                    </td>
                </tr>
               
                <tr>
                  <td>Gender</td>  
                    <td>
                        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button  ID="btnInsert" runat="server" Text="Insert Employee" OnClick="btnInsert_Click" class="bg-red bg" />
                        <asp:Button ID="btnLoad" runat="server" Text="Load Employee" OnClick="btnLoad_Click" />
                        <asp:Button ID="btn_Update" runat="server" Text="Update" OnClick="btn_Update_Click" />
                        <asp:Button ID="btnDelet" runat="server" Text="Delete" OnClick="btnDelet_Click" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear"  OnClick="btnClear_Click"/>
                    </td>
                </tr>
                <asp:GridView ID="gvEmployee29" runat="server"></asp:GridView>
            </table>
        </div>
    </form>
</body>
</html>
