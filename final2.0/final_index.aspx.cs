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
    public partial class final_index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["user"] != null)
            //{ //session 方式
            //    LOGIN.Visible = false;
            //    LOGIN_OUT.Visible = true;
            //    Label2.Text = Convert.ToString(Session["user"]) + "的房間";
            // }
            //if (Request.QueryString["user"] != null)   //傳網址方式
            //{
            //    LOGIN.Visible = false;

            //    Label2.Text = Request.QueryString["user"] + "的房間"; //如果有登入就顯是誰的房間
            //}
            ShowDog1();
            ShowDog2();
            ShowDog3();
            ShowDog4();
            Showdog5();
            ShowCat1();
            ShowCat2();
            ShowCat3();
            ShowCat4();
            Showcat5();
           
        }



        protected void Btn_Introduction_Click(object sender, EventArgs e)
        {
            Panel_Introduction.Visible = true;
            
           // Panel_Supplies.Visible = false;

            Panel_Variety.Visible = false;

            Panel_dog_home.Visible = true;
            Panel_dog_1.Visible = false;
            Panel_dog_2.Visible = false;
            Panel_dog_3.Visible = false;
            Panel_dog_4.Visible = false;
            Panel_dog_5.Visible = false;
            Panel1.Visible = false;
        }

        protected void Btn_Variety_Click(object sender, EventArgs e)
        {
            Panel_Introduction.Visible = false;
           
          //  Panel_Supplies.Visible = false;

            Panel_Variety.Visible = true;
            Panel_cat_home.Visible = true;
            Panel_cat_1.Visible = false;
            Panel_cat_2.Visible = false;
            Panel_cat_3.Visible = false;
            Panel_cat_4.Visible = false;
            Panel_cat_5.Visible = false;
            Panel1.Visible = false;
        }


        //protected void Btn_Supplies_Click(object sender, EventArgs e)
        //{
        //    Panel_Introduction.Visible = false;
          
        //    Panel_Supplies.Visible = true;

        //    Panel_Variety.Visible = false;
        //    Panel1.Visible = false;
        //}

        protected void Button_Click(object sender, EventArgs e)
        {

        }
        //老鼠
        //protected void Btn_about_Click(object sender, EventArgs e)
        //{
        //    Panel_Introduction.Visible = false;
           
        //    Panel_Supplies.Visible = false;

        //    Panel_Variety.Visible = false;
        //    Panel1.Visible = false;
        //}

        protected void LOGIN_Click(object sender, EventArgs e)
        {

            Response.Redirect("/login");
        }



        //protected void LOGIN_OUT_Click(object sender, EventArgs e)
        //{
        //    Session["user"] = null;
        //    LOGIN.Visible = true;
        //    LOGIN_OUT.Visible = false;
        //    Response.Redirect("final_index");
        //}

        protected void Btn_dog_1_Click(object sender, EventArgs e)
        {
            Panel_dog_home.Visible = false;
            Panel_dog_1.Visible = true;
            Panel_dog_2.Visible = false;
            Panel_dog_3.Visible = false;
            Panel_dog_4.Visible = false;
            Panel_dog_5.Visible = false;

        }

        protected void Btn_dog_2_Click(object sender, EventArgs e)
        {
            Panel_dog_home.Visible = false;
            Panel_dog_1.Visible = false;
            Panel_dog_2.Visible = true;
            Panel_dog_3.Visible = false;
            Panel_dog_4.Visible = false;
            Panel_dog_5.Visible = false;
        }

        protected void Btn_dog_3_Click(object sender, EventArgs e)
        {
            Panel_dog_home.Visible = false;
            Panel_dog_1.Visible = false;
            Panel_dog_2.Visible = false;
            Panel_dog_3.Visible = true;
            Panel_dog_4.Visible = false;
            Panel_dog_5.Visible = false;
        }

        protected void Btn_dog_4_Click(object sender, EventArgs e)
        {
            Panel_dog_home.Visible = false;
            Panel_dog_1.Visible = false;
            Panel_dog_2.Visible = false;
            Panel_dog_3.Visible = false;
            Panel_dog_4.Visible = true;
            Panel_dog_5.Visible = false;
        }
        //黃金獵犬的介面
        void ShowDog1()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='黃金獵犬' and animal = '狗'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();
                
                if (objDr.HasRows)
                {
                  
                    //lbl_image  
                    lbl_ShowDog_1.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {
                   
                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }
                     

                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowDog_1.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowDog_1.Text += "<tr>";
                        lbl_ShowDog_1.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowDog_1.Text += "</tr>";
                    lbl_ShowDog_1.Text += "</table>";

                }

              
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

        void ShowDog2()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='拉不拉多' and animal = '狗'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {

                    //lbl_image  
                    lbl_ShowDog_2.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {

                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }


                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowDog_2.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowDog_2.Text += "<tr>";
                        lbl_ShowDog_2.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowDog_2.Text += "</tr>";
                    lbl_ShowDog_2.Text += "</table>";

                }


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
        void ShowDog3()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='哈士奇' and animal = '狗'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {

                    //lbl_image  
                    lbl_ShowDog_3.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {

                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }


                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowDog_3.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowDog_3.Text += "<tr>";
                        lbl_ShowDog_3.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowDog_3.Text += "</tr>";
                    lbl_ShowDog_3.Text += "</table>";

                }


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
        void ShowDog4()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='柴犬' and animal = '狗'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {

                    //lbl_image  
                    lbl_ShowDog_4.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {

                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }


                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowDog_4.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowDog_4.Text += "<tr>";
                        lbl_ShowDog_4.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowDog_4.Text += "</tr>";
                    lbl_ShowDog_4.Text += "</table>";

                }


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

        protected void Btn_dog_5_Click(object sender, EventArgs e)
        {
            Panel_dog_home.Visible = false;
            Panel_dog_1.Visible = false;
            Panel_dog_2.Visible = false;
            Panel_dog_3.Visible = false;
            Panel_dog_4.Visible = false;
            Panel_dog_5.Visible = true;
        }

        protected void Btn_11_Click(object sender, EventArgs e)
        {
            Panel_cat_home.Visible = false;
            Panel_cat_1.Visible = true;
            Panel_cat_2.Visible = false;
            Panel_cat_3.Visible = false;
            Panel_cat_4.Visible = false;
            Panel_cat_5.Visible = false;
        }

        protected void Btn_12_Click(object sender, EventArgs e)
        {
            Panel_cat_home.Visible = false;
            Panel_cat_1.Visible = false;
            Panel_cat_2.Visible = true;
            Panel_cat_3.Visible = false;
            Panel_cat_4.Visible = false;
            Panel_cat_5.Visible = false;
        }

        protected void Btn_13_Click(object sender, EventArgs e)
        {
            Panel_cat_home.Visible = false;
            Panel_cat_1.Visible = false;
            Panel_cat_2.Visible = false;
            Panel_cat_3.Visible = true;
            Panel_cat_4.Visible = false;
            Panel_cat_5.Visible = false;
        }

        protected void Btn_14_Click(object sender, EventArgs e)
        {
            Panel_cat_home.Visible = false;
            Panel_cat_1.Visible = false;
            Panel_cat_2.Visible = false;
            Panel_cat_3.Visible = false;
            Panel_cat_4.Visible = true;
            Panel_cat_5.Visible = false;
        }

        protected void Btn_dog_6_Click(object sender, EventArgs e)
        {
            Panel_cat_home.Visible = false;
            Panel_cat_1.Visible = false;
            Panel_cat_2.Visible = false;
            Panel_cat_3.Visible = false;
            Panel_cat_4.Visible = false;
            Panel_cat_5.Visible =true;
        }


        void ShowCat1()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='波斯貓' and animal = '貓'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {

                    //lbl_image  
                    lbl_ShowCat_1.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {

                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }


                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowCat_1.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowCat_1.Text += "<tr>";
                        lbl_ShowCat_1.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowCat_1.Text += "</tr>";
                    lbl_ShowCat_1.Text += "</table>";

                }


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

        void ShowCat2()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='英國短毛貓' and animal = '貓'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {

                    //lbl_image  
                    lbl_ShowCat_2.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {

                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }


                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowCat_2.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowCat_2.Text += "<tr>";
                        lbl_ShowCat_2.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowCat_2.Text += "</tr>";
                    lbl_ShowCat_2.Text += "</table>";

                }


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
        void ShowCat3()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='折耳貓' and animal = '貓'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {

                    //lbl_image  
                    lbl_ShowCat_3.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {

                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }


                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowCat_3.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowCat_3.Text += "<tr>";
                        lbl_ShowCat_3.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowCat_3.Text += "</tr>";
                    lbl_ShowCat_3.Text += "</table>";

                }


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
        void ShowCat4()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='孟加拉貓' and animal = '貓'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {

                    //lbl_image  
                    lbl_ShowCat_4.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {

                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }


                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowCat_4.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowCat_4.Text += "<tr>";
                        lbl_ShowCat_4.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowCat_4.Text += "</tr>";
                    lbl_ShowCat_4.Text += "</table>";

                }


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


        void Showdog5()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='其他' and animal = '狗'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {

                    //lbl_image  
                    lbl_ShowDog_5.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {

                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }


                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowDog_5.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowDog_5.Text += "<tr>";
                        lbl_ShowDog_5.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowDog_5.Text += "</tr>";
                    lbl_ShowDog_5.Text += "</table>";

                }


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
        void Showcat5()
        {
            try
            {
                //步驟一
                OleDbConnection objCon = new OleDbConnection();
                objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\image.accdb;Persist Security Info=False;";
                //步驟二
                objCon.Open();
                //步驟三

                OleDbCommand objCmd = new OleDbCommand("select * from 狗 where 品種 ='其他' and animal = '狗'",
       objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {

                    //lbl_image  
                    lbl_ShowCat_5.Text = "<table>";
                    int count = 0;
                    //
                    while (objDr.Read())
                    {

                        String str = objDr["圖片位置"].ToString();
                        if (objDr["圖片位置"].ToString().Equals(""))
                        {
                            //處理沒有圖片時的狀況  (一律用no.png)
                            str = "/Image/" + "no.png";
                        }


                        //lbl_image
                        count++;
                        if (count % 5 == 0)
                            lbl_ShowCat_5.Text += "</tr>";
                        if (count == 1 || count % 5 == 0)
                            lbl_ShowCat_5.Text += "<tr>";
                        lbl_ShowCat_5.Text += "<td>" + "<a href =\"pet_Introduction?name=" + objDr["pet名字"].ToString() + "\"><img src =\"" + str + "\" width=\"200px\" >" + "</td> ";


                    }
                    //lbl_image
                    if (count % 5 != 0)
                        lbl_ShowCat_5.Text += "</tr>";
                    lbl_ShowCat_5.Text += "</table>";

                }


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

    }
}