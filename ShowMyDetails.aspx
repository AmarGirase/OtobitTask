<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowMyDetails.aspx.cs" Inherits="Task_Otobit.ShowMyDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             User Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="drpUserId" runat="server" OnSelectedIndexChanged="drpUserId_SelectedIndexChanged"></asp:DropDownList>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="btnShowMyProfile" runat="server" Text="MyProfile" BackColor="#CC66FF" OnClick="btnShowMyProfile_Click" />
           <br />
           <br />
           User Name <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                <br />
            <br />
                Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

                <br />
            <br />
                Password&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                <br />
            <br />
       </div>
    </form>
</body>
</html>
