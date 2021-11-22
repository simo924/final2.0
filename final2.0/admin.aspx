<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="final2._0.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <style>
                        /*table 樣式test*/ 藍線(不明顯)
                table {
              border: 0;
              border-collapse: collapse;
              border-radius: 8px;
              width: 100%;
            }
            th {
              border: solid 1px #5ceffe;
              padding: 16px 8px;
            }
            td {
              border: solid 1px #5ceffe;
              text-align: center;
              padding: 8px;
              color: #757575;
            }
            table td a{
              background-color: #25b327;
              color: white;
              padding:5px 20px;
              border-radius: 30px;
              font-weight: bold;
              text-decoration: none;
            }

            .auto-style1 {
                width: 89%;
                height: 447px;
            }
            /*table 樣式test*/
            .auto-style2 {
                width: 750px;
            }
            .auto-style3 {
                margin-left: 228;
            }
        </style>


        <table class="auto-style1">
            
                    <p style="text-align:center; font-size: 60pt;">使用者管理介面</p>
            <tr>
                <td class="auto-style2">
        <input type ="button" onclick="history.back()" value="回到上一頁"><br />
                    <span style="font-size: xx-large"><strong>
                    <asp:DropDownList ID="ddl_animal" runat="server" Height="35px" style="font-size: x-large" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="ddl_animal_SelectedIndexChanged">
                        <asp:ListItem>貓</asp:ListItem>
                        <asp:ListItem>狗</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </strong></span>
                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style3" Width="287px" />
                    <asp:Button ID="updata_image" runat="server" OnClick="Button1_Click" Text="上傳圖片" />
                    <asp:Image ID="Image1" runat="server" Width="60px" />
                    <br />
                    編號:<br />
                    <asp:TextBox ID="txt_number" runat="server"></asp:TextBox>
                    <br />
                    名字:<br />
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="delete" />
                    <br />
                    個性:<br />
                    <asp:TextBox ID="txt_personality" runat="server"></asp:TextBox>
                    <br />
                    身高:<br />
                    <asp:TextBox ID="txt_hight" runat="server"></asp:TextBox>
                    <br />
                    品種:<br />
                    <asp:Panel ID="Panel1" runat="server">
                        <asp:DropDownList ID="ddl_variety" runat="server" Height="23px" Width="81px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>黃金獵犬</asp:ListItem>
                            <asp:ListItem>拉不拉多</asp:ListItem>
                            <asp:ListItem>哈士奇</asp:ListItem>
                            <asp:ListItem Value="柴犬"></asp:ListItem>
                            <asp:ListItem>其他</asp:ListItem>
                        </asp:DropDownList>
                    </asp:Panel>
                    <asp:Panel ID="Panel2" runat="server">
                        <asp:DropDownList ID="ddl_variety0" runat="server" Height="23px" Width="81px">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>波斯貓</asp:ListItem>
                            <asp:ListItem Value="英國短毛貓">英國短毛貓</asp:ListItem>
                            <asp:ListItem>折耳貓</asp:ListItem>
                            <asp:ListItem Value="孟加拉貓">孟加拉貓</asp:ListItem>
                            <asp:ListItem>其他</asp:ListItem>
                        </asp:DropDownList>
                    </asp:Panel>
                    <br />
                    <asp:Button ID="btn_upData" runat="server" OnClick="btn_upData_Click" Text="上傳資料" style="height: 26px" />
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="lbl_dog_1" runat="server"></asp:Label>
                    <div id="barcon"></div>
                
                </td>
                <td>
                    <br />
                    </td>
            </tr>
            </table>

    <div style="margin-top: 212px">
        

    </div>

        <%-- js test--%>
                    <script type="text/javascript">

                        goPage(1, 3);
                        function goPage(pno, psize) {
                            var itable = document.getElementById("table_result");//用ID找到表格                  這裡有專有名詞
                            var num = itable.rows.length;//記錄表格總數
                            var totalPage = 0;//總共幾頁
                            var pageSize = psize;//一頁顯示幾行
                            //以下是總共會有幾個分頁
                            if (num / pageSize > parseInt(num / pageSize)) {  //paresInt是去小數點                  轉int一樣是parseInt
                                totalPage = parseInt(num / pageSize) + 1; //有剩就要多一頁
                            } else {
                                totalPage = parseInt(num / pageSize); //整除就不用多一頁
                            }
                            var currentPage = pno;//當前第幾頁
                            var startRow = (currentPage - 1) * pageSize + 1;//顯示行數  1 11 21
                            var endRow = currentPage * pageSize;//結束的行數   10 20 30
                            endRow = (endRow > num) ? num : endRow;
                            //如果超過總行數，就顯示到行數，沒有就繼續顯示endRow

                            for (var i = 1; i < (num + 1); i++) {
                                var irow = itable.rows[i - 1];                                                      //這裡有專有名詞
                                if (i >= startRow && i <= endRow) {
                                    irow.style.display = "block"; //將 display 均設為 block，所以成為區塊的呈現方式，強迫換行。   //這裡需要再試試
                                } else {
                                    irow.style.display = "none"; //沒了就display就不要顯示 
                                }
                            }

                            var tempStr = ""; //存上一頁 1 2 3 4 5 下一頁

                            var innital = currentPage; //下面的頁面 [1] 2 3 4 5 
                            var after = currentPage + 4; // 1 2 3 4 [5]


                            if (totalPage <= 4) {
                                innital = 1 //如果頁面不到五頁，強迫從1開始數
                            }

                            else if (innital + 4 >= totalPage) {
                                innital = totalPage - 4 // 不要讓初始頁面爆表 若只有7頁 選到[5] innital 一樣是[3] 4 5 6 7 
                            }

                            if (after >= totalPage) {
                                after = totalPage //若 after超過總頁數一定只能讓他在總頁數 若只有7頁 選到[5] after 一樣是3 4 5 6 [7] 
                            }

                            // 以下是頁碼的連結
                            if (currentPage > 1) {
                                tempStr += "<a href=\"#\" onClick=\"goPage(" + (currentPage - 1) + "," + psize + ")\"><上一頁&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>"
                                for (var j = innital; j <= after; j++) {
                                    tempStr += "<a href=\"#\" onClick=\"goPage(" + j + "," + psize + ")\">" + j + "&nbsp;&nbsp;&nbsp;</a>"
                                }

                                //innital++;
                                // after++;

                            } else {  //第一次進來
                                tempStr += "<上一頁&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                                for (var j = innital; j <= after; j++) {
                                    tempStr += "<a href=\"#\" onClick=\"goPage(" + j + "," + psize + ")\">" + j + "&nbsp;&nbsp;&nbsp;</a>"
                                }


                                // after++;
                            }
                            if (currentPage < totalPage) {
                                tempStr += "<a href=\"#\" onClick=\"goPage(" + (currentPage + 1) + "," + psize + ")\">下一頁>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>";

                                // innital--;
                                // after--;
                            } else {
                                tempStr += "  下一頁>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";

                                // innital--;

                            }
                            document.getElementById("barcon").innerHTML = tempStr;
                        }

                    </script>

                       <%-- js test--%>
    
</asp:Content>
