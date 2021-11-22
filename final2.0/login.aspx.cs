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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            //步驟一
            OleDbConnection objCon = new OleDbConnection();
            objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\newuser.accdb;Persist Security Info=False;";
            //步驟二
            objCon.Open();
            //步驟三
            OleDbCommand objCmd = new OleDbCommand();
            objCmd.Connection = objCon;
            objCmd.CommandText = "select * from 使用者資料";
            //識別碼,userName,passWord,want,notice,Authority
            OleDbDataReader objDR = objCmd.ExecuteReader();
            if (objDR.HasRows)
            {
                while (objDR.Read())
                {
                    if (Txt_user.Text.Equals(objDR["un"]) && Txt_pw.Text.Equals(objDR["pw"]))
                    {
                        //if (objDR["notice"].Equals("哈士奇"))
                        //{
                        //    Response.Write("<script>alert(\"您要的動物有貨了\")</script>");
                        //}
                        //string s_url;
                        if (objDR["ay"].Equals("1"))  //設1為普通帳號
                        {

                            //s_url = "Final_index.aspx?user=" + Txt_user.Text;  //傳網址用法

                            Session["user"] = Txt_user.Text;

                            Response.Redirect("final_index");

                            //Server.Transfer("Final_home.aspx"); //登入到user
                        }
                        else                                   //設0為普通帳號
                        {
                            Session["admin"] = Txt_user.Text;
                            //s_url = "Final_index.aspx?user=" + Txt_user.Text;
                            Response.Redirect("final_index");
                            //Server.Transfer("Final_index.aspx");//登入到後台                        }

                        }
                    }
                    
                }
                Response.Write("<script>alert('帳號或密碼有誤')</script>");
                objCon.Close();
                objDR.Close();
                objCon.Dispose();
                objCmd.Dispose();

            }
        }

        protected void Btn_registered_Click(object sender, EventArgs e)
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\newuser.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand();
                objCmd.Connection = objCon;
                //
                objCmd.CommandText = "INSERT INTO  使用者資料(un,pw,ay) VALUES ('"
                    + Txt_user.Text + "','"
                    + Txt_pw.Text + "','"                   
                    +"0"+"')";
                Response.Write("A");
                int row_cnt = objCmd.ExecuteNonQuery();
                if (row_cnt > 0)
                    Response.Write("成功新增" + row_cnt.ToString() + "筆資料。");
                else
                    Response.Write("並未新增資料。");
                objCon.Close();
                objCon.Dispose();
                objCmd.Dispose();
                Response.Write("B");
                // Response.Redirect("admin");
            }
            catch (Exception ex)
            {
                Response.Write("有錯。:"+ex.Message);
            }
        }

       
    }
}