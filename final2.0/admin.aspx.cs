using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.OleDb;
namespace final2._0
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("login");
            }
            Panel2.Visible = true;
            Panel1.Visible = false;

            if(Session["count"]==null)
            showuser();

            showdb();
           
            //userdb();
        }
        void showuser()
        {
            string str0 = "";
            int count = 0;
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗  where (收養人 is NOT NULL)",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();
                str0 = "";
                if (objDr.HasRows)
                {
                   // str0 += "編號" + "   " + "收養人";
                       
                        



                    while (objDr.Read())
                    {
                        

                       
                        str0 +=  objDr["編號"].ToString() + " : " +  objDr["收養人"].ToString()+"表示想養\\r " ;
                        count ++;

                    }
                }
               
               if(!str0.Equals(""))
               Response.Write("<script>alert('" +str0 + "')</script>");
                Session["count"] = "break"; //停止
                objCon.Close();
                objDr.Close();
                objCon.Dispose();
                objCmd.Dispose();
                objDr.Dispose();
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + "rerrrr" + "')</script>");
            }



            //if(str.Equals(""))
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //宣告保存檔案路徑
            //string savaPath = "D:\\ASP.FileUpload\\";
            string savaPath = Server.MapPath("\\Image\\");
            //如果user有選擇檔案
            string fileName = "";
            if (FileUpload1.HasFile)
            {
                //取得user上傳檔案檔名
                fileName = FileUpload1.FileName;
                //保存檔案路徑 = 我們預設保存地點 + user上傳檔案名稱
                savaPath = savaPath + fileName;
                //將檔案保存在設定路徑中
                FileUpload1.SaveAs(savaPath);
                Response.Write("檔案上傳成功");


            }
            //沒有選擇檔案
            else
            {
                Response.Write("未選擇檔案");
            }


            Image1.ImageUrl = "/Image/" + fileName;

        }

        protected void btn_upData_Click(object sender, EventArgs e)
        {

            if (ddl_animal.Text.Equals("狗"))
                dog();

            if (ddl_animal.Text.Equals("貓"))
                cat();
        }
        void dog()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand();
                objCmd.Connection = objCon;
                //
                objCmd.CommandText = "insert into 狗(編號,pet名字,圖片位置,pet個性,pet身高,品種,animal) values('"
                    + txt_number.Text + "','"
                    + txt_name.Text + "','"
                    + Image1.ImageUrl + "','"
                    + txt_personality.Text + "','"


                    + txt_hight.Text + "','"
                    + ddl_variety.Text + "','"
                    + ddl_animal.Text + "')";
                int row_cnt = objCmd.ExecuteNonQuery();
                if (row_cnt > 0)
                    Response.Write("成功新增" + row_cnt.ToString() + "筆資料。");
                else
                    Response.Write("並未新增資料。");
                objCon.Close();
                objCon.Dispose();
                objCmd.Dispose();
                Response.Redirect("admin");
            }
            catch (Exception ex)
            {
                Response.Write("不可輸入相同資料。");
            }
        }

        void cat()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand();
                objCmd.Connection = objCon;
                //
                objCmd.CommandText = "insert into 狗(編號,pet名字,圖片位置,pet個性,pet身高,品種,animal) values('"
                    + txt_number.Text + "','"
                    + txt_name.Text + "','"
                    + Image1.ImageUrl + "','"
                    + txt_personality.Text + "','"
                    + txt_hight.Text + "','"
                    + ddl_variety0.Text + "','"
                    + ddl_animal.Text + "')";
                int row_cnt = objCmd.ExecuteNonQuery();
                if (row_cnt > 0)
                    Response.Write("成功新增" + row_cnt.ToString() + "筆資料。");
                else
                    Response.Write("並未新增資料。");
                objCon.Close();
                objCon.Dispose();
                objCmd.Dispose();
                Response.Redirect("admin");
            }
            catch (Exception ex)
            {
                Response.Write("不可輸入相同資料。");
            }
        }
        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("delete from 狗 where pet名字 ='" + txt_name.Text + "'",
       objCon);
                int row_cnt = objCmd.ExecuteNonQuery();
                if (row_cnt > 0)
                    Response.Write("成功刪除" + row_cnt.ToString() + "筆資料。<br> 已刪除 ");
                else
                    Response.Write("並未刪除資料。");
                objCon.Close();
                objCon.Dispose();
                objCmd.Dispose();
                Response.Redirect("admin");
            }
            catch (Exception ex)
            {
                // Response.Write("寫錯了");
            }
        }
        void showdb()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();
                lbl_dog_1.Text = "";
                if (objDr.HasRows)
                {
                    lbl_dog_1.Text += "<table border = '1' id=\"table_result\"> " +
                        " <tr>" +
                        "<td> 編號</td>" +
                        "<td> pet名字</td>" +
                        "<td> pet圖片</td>" +
                        "<td> pet個性</td>" +
                        "<td> pet身高</td>" +
                        "<td> 品種</td>" +
                        "<td> 收養人</td>" +
                        "<td> animal</td>" +
                        "</tr>";



                    while (objDr.Read())
                    {
                        lbl_dog_1.Text += "<tr>";
                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }
                        lbl_dog_1.Text += "<td>" + objDr["編號"].ToString() + "</td>"
                                            + "<td>" + objDr["pet名字"].ToString() + "</td>"
                                            + " <td> " + "<img src =\"" + str + "\" width=\"200px\" >" + " </ td > "
                                            + " <td> " + objDr["pet個性"].ToString() + " </ td > "
                                            + " <td> " + objDr["pet身高"].ToString() + " </ td > "
                                            + " <td> " + objDr["品種"].ToString() + " </ td > "
                                            + " <td> " + objDr["收養人"].ToString() + " </ td > "
                                             + " <td> " + objDr["animal"].ToString() + " </ td > ";


                        lbl_dog_1.Text += "</tr>";



                    }
                    //lbl_image

                }

                lbl_dog_1.Text += "</table>";
                objCon.Close();
                objDr.Close();
                objCon.Dispose();
                objCmd.Dispose();
                objDr.Dispose();

            }
            catch (Exception ex)
            {

            }
        }

        protected void ddl_animal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_animal.Text.Equals("狗"))
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            else
            {

                Panel1.Visible = false;
                Panel2.Visible = true;
            }

        }
  
        
      
    }
}