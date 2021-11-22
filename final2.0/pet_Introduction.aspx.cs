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
    public partial class pet_Introduction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] == null)
            {
                adopt.Visible = false;
            }else{
                adopt.Visible = true;
            }
            showdb();
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
                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where pet名字 = '" +
                   Request.QueryString["name"] + "'", objCon);
                //OleDbCommand objCmd = new OleDbCommand("select * from 顯示資料 where 識別碼 ='" +
                //     Request.QueryString["number"] + "'",objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();
                lbl_showdb.Text = "";
                if (objDr.HasRows)
                {
                    lbl_showdb.Text += "<table border = '1'>" +
                        " <tr>" +
                        "<td> 編號</td>" +
                        "<td> pet名字</td>" +
                        "<td> pet圖片</td>" +
                        "<td> pet個性</td>" +
                        "<td> pet身高</td>" +
                        "<td> 品種</td>" +
                        "</tr>";


                    if (objDr.Read())
                    {
                        lbl_showdb.Text += "<tr>";
                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }
                        lbl_showdb.Text = lbl_showdb.Text + "<td>" + objDr["編號"].ToString() + "</td>"
                                            + "<td>" + objDr["pet名字"].ToString() + "</td>"
                                            + " <td> " + "<img src =\"" + str + "\" width=\"200px\" >" + " </ td > "
                                            + " <td> " + objDr["pet個性"].ToString() + " </ td > "
                                            + " <td> " + objDr["pet身高"].ToString() + " </ td > "
                                            + " <td> " + objDr["品種"].ToString() + " </ td > "; ;


                        lbl_showdb.Text += "</tr>";



                    }


                }

                lbl_showdb.Text += "</table>";
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

        protected void adopt_Click(object sender, EventArgs e)
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\user.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三
                OleDbCommand objCmd = new OleDbCommand();
                objCmd.Connection = objCon;
                objCmd.CommandText = "update 使用者資料 set want='" + Request.QueryString["name"] +
                  "' where userName = '" + Session["user"]
                  + "'";

                //識別碼,userName,passWord,want,notice,Authority



                int row_cnt = objCmd.ExecuteNonQuery();
                //if (row_cnt > 0)
                //    Response.Write("成功更新" + row_cnt.ToString() + "筆資料。");
                //else
                //    Response.Write("並未更新資料。");

                objCon.Close();
                objCon.Dispose();
                objCmd.Dispose(); ;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('error')</script>");
            }
            admin_updata();
        }

        void admin_updata()
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
                objCmd.CommandText = "update 狗 set 收養人='" + Session["user"] +
                  "' where pet名字 = '" + Request.QueryString["name"]
                  + "'";

                //識別碼,userName,passWord,want,notice,Authority



                int row_cnt = objCmd.ExecuteNonQuery();
                if (row_cnt > 0)
                    Response.Write("<script>alert('" + "已通知後台" + "')</script>");
                else
                    Response.Write("並未更新資料。");

                objCon.Close();
                objCon.Dispose();
                objCmd.Dispose(); ;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('error')</script>");
            }

        }
    }

    
}