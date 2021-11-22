<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="final2._0.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="margin-top: 212px"><%: Title %>.</h2>
    <h3>Administrator contact page.</h3>
    <address>
        One Microsoft Way<br />
        Providence University 433719<br />
        <abbr title="Phone">P:</abbr>
        	(04)2631-9704
    </address>

    <address>
        <strong>teacher <a href="mailto:e-mail:wang@pu.edu.tw">e-mail:</a></strong><a href="mailto:e-mail:wang@pu.edu.tw">wang@pu.edu.tw</a></a>
    </address>

    <div>


        <asp:Label ID="lbl_message" runat="server" Text="歡迎留言" style="font-size:x-large;"></asp:Label>


        <br />
        <br />
        <asp:TextBox ID="txt_message" runat="server" Height="135px" TextMode="MultiLine" Width="437px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_message" runat="server" OnClick="btn_message_Click" Text="送出" />


    </div>
</asp:Content>
