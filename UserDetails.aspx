<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="Task_Otobit.UserDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <h1>User Information</h1>
            User Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="drpUserId" runat="server" ></asp:DropDownList>
            <br />
            <br />
            <div>
                User Name <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <br />
            <br />
                Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

                <br />
            <br />
                Password&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPassword" runat="server" ></asp:TextBox>
                <br />
            <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSubmit" runat="server" Text="SUBMIT" OnClick="btnSubmit_Click" BackColor="Lime"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnUpdateEmail" runat="server" Text="Update EmailId" OnClick="btnUpdateEmail_Click" BackColor="#FF6600" />
                <br />
            <br />
                </div>
            </div>
    </form>
</body>
</html>
