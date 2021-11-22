<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pet_Introduction.aspx.cs" Inherits="final2._0.pet_Introduction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height: 359px; margin-top: 96px">
        <br />
       
        <input type ="button" onclick="history.back()" value="回到上一頁"></input>
        <br />
     <asp:Label ID="lbl_showdb" runat="server"></asp:Label>
        <div>
            <br />
            <asp:Button ID="adopt" runat="server" Text="想養" OnClick="adopt_Click" />
</div>
    </div>
</asp:Content>
