<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="select.aspx.cs" Inherits="EX1.select" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p/>&nbsp;<p/>&nbsp;<table class="nav-justified">
    <tr>
        <td style="width: 392px; "><asp:Button ID="Btn_select" runat="server" Text="Btn_select" OnClick="Btn_select_Click" />
        </td>
        <td>
            <asp:Button ID="Btn_insert" runat="server" Text="Btn_insert" OnClick="Btn_insert_Click" />
            <br />
        </td>
        <td><asp:Button ID="Btn_delete" runat="server" Text="Btn_delete" OnClick="Btn_delete_Click" />
        </td>
        <td><asp:Button ID="Btn_update" runat="server" Text="Btn_update" OnClick="Btn_update_Click" Enabled="False" />
            <asp:Button ID="cancel" runat="server" Text="cancel" OnClick="cancel_Click" Enabled="False" />
        </td>
    </tr>
    <tr>
        <td style="width: 392px; height: 197px;">
    <asp:Label ID="lblRst" runat="server" ></asp:Label>
        </td>
        <td style="height: 197px">
            <table class="nav-justified">
                <tr>
                    <td>ModelNo:</td>
                    <td style="width: 231px">
            <asp:TextBox ID="txtModelNo" runat="server"></asp:TextBox>
            
                    </td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td style="width: 231px">
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Storage:</td>
                    <td style="width: 231px">
              <asp:TextBox ID="txtStorage" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>BatteryLife:</td>
                    <td style="width: 231px">
              <asp:TextBox ID="txtBatteryLife" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Price:</td>
                    <td style="width: 231px">
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>StockDate:</td>
                    <td style="width: 231px">
            <asp:TextBox ID="txtStockDate" runat="server"></asp:TextBox>
           
                    </td>
                </tr>
            </table>
           
            <br />
    <asp:Label ID="lblMsg" runat="server" ></asp:Label>
           
            <br />
        </td>
        <td style="height: 197px">
            <table class="nav-justified" style="height: 237px">
    <tr>
        <td style="height: 562px">
            <table class="nav-justified">
                <tr>
                    <td>ModelNo:</td>
                    <td>
            <asp:TextBox ID="txtModelNo_delete" runat="server"></asp:TextBox>
            
                    </td>
                    <td>
                        <asp:Button ID="qurey" runat="server" Text="qurey" OnClick="qurey_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td>
            <asp:TextBox ID="txtName_delete" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Storage:</td>
                    <td>
              <asp:TextBox ID="txtStorage_delete" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>BatteryLife:</td>
                    <td>
              <asp:TextBox ID="txtBatteryLife_delete" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Price:</td>
                    <td>
            <asp:TextBox ID="txtPrice_delete" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>StockDate:</td>
                    <td>
            <asp:TextBox ID="txtStockDate_delete" runat="server" Enabled="False" Width="128px"></asp:TextBox>
           
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
           
            <br />
    <asp:Label ID="lblMsg_delete" runat="server" ></asp:Label>
           
            <br />
        </td>
    </tr>
    </table>
        </td>
        <td style="height: 197px">
            <table class="nav-justified" style="height: 125px">
                <tr>
                    <td class="text-left" style="height: 31px">ModelNo:</td>
                    <td class="text-left" style="height: 31px">
            <asp:TextBox ID="txtModelNo_update" runat="server"></asp:TextBox>
            
                    </td>
                    <td class="text-left" style="height: 31px">
                        <asp:Button ID="qurey_update" runat="server" Text="qurey" OnClick="qurey_update_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="text-left">Name:</td>
                    <td class="text-left">
            <asp:TextBox ID="txtName_update" runat="server"></asp:TextBox>
                    </td>
                    <td class="text-left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="text-left">Storage:</td>
                    <td class="text-left">
              <asp:TextBox ID="txtStorage_update" runat="server"></asp:TextBox>
                    </td>
                    <td class="text-left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="text-left">BatteryLife:</td>
                    <td class="text-left">
              <asp:TextBox ID="txtBatteryLife_update" runat="server"></asp:TextBox>
                    </td>
                    <td class="text-left">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="text-left" style="height: 28px">Price:</td>
                    <td class="text-left" style="height: 28px">
            <asp:TextBox ID="txtPrice_update" runat="server"></asp:TextBox>
                    </td>
                    <td class="text-left" style="height: 28px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="text-left">StockDate:</td>
                    <td class="text-left">
            <asp:TextBox ID="txtStockDate_update" runat="server"  Width="128px"></asp:TextBox>
           
                    </td>
                    <td class="text-left">
                        &nbsp;</td>
                </tr>
            </table>
            <br />
    <asp:Label ID="lblMsg_update" runat="server" ></asp:Label>
           
        </td>
    </tr>
    </table>
    <p/>&nbsp;<p/>
        &nbsp;
 
    <p/>


</asp:Content>
