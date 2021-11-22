<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="final2._0.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
}
  *,
  *:before,
  *:after {
    color: #000 !important;
    text-shadow: none !important;
    background: transparent !important;
    -webkit-box-shadow: none !important;
    box-shadow: none !important;
  }
  </style>
     <script src="Scripts/jquery-3.4.1.js" type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>


                <asp:Label ID="lbl_test" runat="server"></asp:Label>
                <br/>
            <div id="barcon"></div>
                 -----------------------------------------------------
               
         
           

        </div>

       
    </form>
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

   
</body>
</html>
