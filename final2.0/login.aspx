<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="final2._0.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body{
            background-image:url("/Image/dog.gif");
        }
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
             <br /> <br /> <br /> <br /> <br /> <br /> <br />
             <br /> <br /> <br /> <br /> <br /> 
             <br /><br/>
        <br />
            <h1 style="text-align:center;">
                輸入帳號:<asp:TextBox ID="Txt_user" runat="server"  Height="23px" Width="188px" required></asp:TextBox>
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <br />
                輸入密碼:<asp:TextBox ID="Txt_pw" runat="server" Height="23px" Width="188px" type ="password" required></asp:TextBox>
               
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               
             <br />
                 </h1>
             <h1 style="text-align:center;">
        <br />
        <asp:Button ID="Btn_login" runat="server" style="font-size:xx-large" Text="登入" Height="50px" Width="118px" OnClick="Btn_login_Click"  />
        <asp:Button ID="Btn_registered" runat="server" style="font-size:xx-large" Text="註冊" Height="50px" Width="116px" OnClick="Btn_registered_Click"   />
        <br />
        <br />
                 </h1>
        </div>
    </form>
</body>
</html>
