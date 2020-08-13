<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_1_Introduction.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h2 style="text-align:center;color:crimson">Student Information </h2>

    <div style="margin-left:450px" >
        
        <asp:GridView ID="gvEmployee" runat="server"></asp:GridView>
        <br /> 
       </div> 
    <h2 style="text-align:center;color:crimson"> Trainer Information </h2>

        <div style="margin-left:450px">
        <asp:GridView ID="gvStudent" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
