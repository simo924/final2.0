<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="final_index.aspx.cs" Inherits="final2._0.final_index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <style>
        td{ 
          text-align:right;
            /*width:200px;*/
        }
        .auto-style7 {
            width: 254px;
            text-align: left;
        }
        .auto-style12 {
            width: 98%;
        }
        .auto-style13 {
            width: 98%;
            height: 431px;
        }
         .auto-style14 {
             text-align: left;
             width: 10px;
             height: 431px;
         }
         .auto-style15 {
             width: 1000px;
             padding: 0 30px 20px 30px;
             margin-left: auto;
             margin-right: auto;
             margin-top: 0px;
             height: 2626px;
         }
         .auto-style16 {
             font-size: x-large;
         }
         .auto-style17 {
             width: 668px;
             text-align: left;
         }
         .auto-style20 {
             margin-top: 0px;
         }
         .auto-style21 {
             text-align: center;
             width: 323px;
         }
         .auto-style22 {
             text-align: center;
             width: 331px;
         }
         .auto-style23 {
             width: 200px;
             text-align: left;
             height: 431px;
         }
         .auto-style24 {
             font-size: xx-small;
         }
     </style>
    <div class ="auto-style20">
    <div class ="auto-style15">
      <%--  <p style="text-align:right" class="auto-style9">
            <strong><asp:Button class="Button" ID="LOGIN_OUT" runat="server" BorderStyle="None" ForeColor="#3366FF" Height="33px"  Text="登出" Visible="False" OnClick="LOGIN_OUT_Click" />
            
            
            <asp:Button class="Button" ID="LOGIN" runat="server" BorderStyle="None" ForeColor="#3366FF" Height="33px" OnClick="LOGIN_Click" Text="登入" />
            
            
            &nbsp;<asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </strong>
        </p>--%>
        <br/>
        
	    <br />
        <table class="nav-justified">
            <tr>
                <td class="auto-style21">
        
        <asp:Button ID="Btn_1" runat="server" Text="回首頁" class=" Button" PostBackUrl="~/final_index.aspx"  />
                </td>
                <td class="auto-style22">
		<asp:Button ID="Btn_2" runat="server" Text="狗" class =" Button" OnClick="Btn_Introduction_Click"/>
                </td>
                <td style="width: 167px" class="text-center">
		<asp:Button ID="Btn_3" runat="server" Text="貓" class =" Button" OnClick="Btn_Variety_Click"/>
                </td>
         <%--       <td class="text-center">
		<asp:Button ID="Btn_5" runat="server" Text="其他" class =" Button" OnClick="Btn_Supplies_Click"/>
		        </td>--%>
                <td class="text-center">
		            &nbsp;</td>
            </tr>
        </table>
        <asp:Panel ID="Panel1" runat="server">
            <br />
            <br />
            <h1 class="auto-style16">動物收容所，是專門收留走失、被遺棄或流浪動物的場所。由於收容的動物多數是貓狗，故又名狗房。大部分動物收容所只會暫留動物7至14天，期間會為動物提供生活基本的需要，包括食水、醫療和容身之所。如果等待不及飼主領回，或未能得到新主人前來領養，這些動物多數會被人道毀滅，只有少數國家立法禁止殺掉流浪犬隻。 <span class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span></h1>
            <h1 class="auto-style16">&nbsp;<span class="auto-style24">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ---資料來自維基百科</span></h1>
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Image/home.jpg" Width="878px" />

        </asp:Panel>
            
        <table class="nav-justified">
            </table>
      
        <br />
        
        <table class="auto-style12" style="margin-top: 0px">
            <tr>
                <td>
        <asp:Panel ID="Panel_Introduction" runat="server" Visible="False" Width="972px"><br /> 
             
            <table class="auto-style13">
                <tr>
                    <td class="auto-style14">
                        <asp:Button ID="Btn_dog_1" runat="server" class=" Button" Text="黃金獵犬" OnClick="Btn_dog_1_Click" />
                        <br />
                        <br />
                        <asp:Button ID="Btn_dog_2" runat="server" class=" Button"  Text="拉不拉多" OnClick="Btn_dog_2_Click" />
                        <br />
                        <br />
                        <asp:Button ID="Btn_dog_3" runat="server" class=" Button"  Text="哈士奇" OnClick="Btn_dog_3_Click" />
                        <br />
                        <br />
                        <asp:Button ID="Btn_dog_4" runat="server" class=" Button"  Text="柴犬" OnClick="Btn_dog_4_Click" />
                        <br />
                        <br />
                        <asp:Button ID="Btn_dog_5" runat="server" class=" Button" Text="其他" OnClick="Btn_dog_5_Click" />
                        <br />
                    </td>
                    <td class="auto-style23">
                        <asp:Panel ID="Panel_dog_home" runat="server">
                            <asp:Image ID="Image1" runat="server" Height="286px" ImageUrl="http://img.yao51.com/jiankangtuku/ofibhbffz.jpeg" Width="388px" />

                        </asp:Panel>
                        <asp:Panel ID="Panel_dog_1" runat="server">
                            <asp:Label ID="lbl_ShowDog_1" runat="server"></asp:Label>
                        </asp:Panel>
                         <asp:Panel ID="Panel_dog_2" runat="server">
                             <asp:Label ID="lbl_ShowDog_2" runat="server"></asp:Label>
                             </asp:Panel>
                         <asp:Panel ID="Panel_dog_3" runat="server">
                             <asp:Label ID="lbl_ShowDog_3" runat="server"></asp:Label>
                             </asp:Panel>
                         <asp:Panel ID="Panel_dog_4" runat="server">
                             <asp:Label ID="lbl_ShowDog_4" runat="server"></asp:Label>
                             </asp:Panel>
                         <asp:Panel ID="Panel_dog_5" runat="server">
                             <asp:Label ID="lbl_ShowDog_5" runat="server"></asp:Label>
                             <asp:Label ID="lbl_ShowDog_6" runat="server"></asp:Label>
                             </asp:Panel>
                    </td>
                </tr>
            </table>
            <br />
            &nbsp;</asp:Panel>
		<asp:Panel ID="Panel_Variety" runat="server" Visible="False" Width="972px"><br /> 
            <table class="auto-style13">
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="Btn_11" runat="server" class=" Button"  Text="波斯貓" OnClick="Btn_11_Click" />
                        <br />
                        <br />
                        <asp:Button ID="Btn_12" runat="server" class=" Button"  Text="英國短毛貓" OnClick="Btn_12_Click" />
                        <br />
                        <br />
                        <asp:Button ID="Btn_13" runat="server" class=" Button" Text="折耳貓" OnClick="Btn_13_Click" />
                        <br />
                        <br />
                        <asp:Button ID="Btn_14" runat="server" class=" Button" Text="孟加拉貓" OnClick="Btn_14_Click"  />
                        <br />
                        <br />
                        <asp:Button ID="Btn_dog_6" runat="server" class=" Button" Text="其他" OnClick="Btn_dog_6_Click" />
                    </td>
                    <td class="auto-style17">
                        <asp:Panel ID="Panel_cat_home" runat="server" Width="537px">
                            <asp:Image ID="Image3" runat="server" Height="286px" ImageUrl="https://buzzorange.com/techorange/wp-content/uploads/sites/2/2019/08/800px-Cute-kittens-12929201-1600-1200-768x576.webp?jpg" Width="388px" />
                        </asp:Panel>
                        <asp:Panel ID="Panel_cat_1" runat="server">
                            <asp:Label ID="lbl_ShowCat_1" runat="server"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel_cat_2" runat="server">
                            <asp:Label ID="lbl_ShowCat_2" runat="server"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel_cat_3" runat="server">
                            <asp:Label ID="lbl_ShowCat_3" runat="server"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel_cat_4" runat="server">
                            <asp:Label ID="lbl_ShowCat_4" runat="server"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel_cat_5" runat="server">
                            <asp:Label ID="lbl_ShowCat_5" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
            &nbsp;<br />
            <br />
        </asp:Panel>
		<asp:Panel ID="Panel_Supplies" runat="server" Visible="False" Width="892px">這是其他介面<br /> 
             
             
            <br />
            <br />
            <br />
                    </asp:Panel>
      
                </td>
            </tr>
            </table>
        <br />
        <br />
 
      
        <div>
        <br />
    </div>

        <br />
        <br />
        <br />
	    <br />
	</div>
        </div>

</asp:Content>
