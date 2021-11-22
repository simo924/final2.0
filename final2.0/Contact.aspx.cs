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
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_message_Click(object sender, EventArgs e)
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
                objCmd.CommandText = "insert into message(un,txt) values('"
                    + Session["user"] + "','"
                   
                  
                    + txt_message.Text + "')";
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

            // 下面還有錯誤晚點處理
            //try
            //{

            //    OleDbConnection objCon = new OleDbConnection();
            //    objCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\newuser.accdb;Persist Security Info=False;";
            //    //步驟二
            //    objCon.Open();
            //    OleDbCommand objCmd = new OleDbCommand("select * from ipod where modelno = '" + txtModelNo_update.Text
            //        + "'", objCon);
            //    OleDbDataReader objDr = objCmd.ExecuteReader();

            //    if (objDr.HasRows)
            //    {
            //        if (objDr.Read())
            //        {
            //            txtName_update.Text = objDr["Name"].ToString();
            //            txtStorage_update.Text = objDr["Storage"].ToString();
            //            txtBatteryLife_update.Text = objDr["BatteryLife"].ToString();
            //            txtPrice_update.Text = objDr["Price"].ToString();
            //            //txtStockDate_update.Text = objDr["StockDate"].ToString();
            //            string[] subs = objDr["StockDate"].ToString().Split(' ');
            //            txtStockDate_update.Text = subs[0];
            //        }
            //        else
            //        {
            //            lblMsg_delete.Text = "找不到資料";
            //        }

            //    }


            //    objCon.Close();
            //    objDr.Close();
            //    objCon.Dispose();
            //    objCmd.Dispose();
            //    objDr.Dispose();
            //    txtModelNo_update.Focus();
            //    txtModelNo_update.Enabled = false;
            //    Btn_update.Enabled = true;
            //    cancel.Enabled = true;
            //}
            //catch (Exception ex)
            //{
            //    lblMsg_update.Text = "輸入錯誤";
            //    txtName_update.Text = "";
            //    txtStorage_update.Text = "";
            //    txtBatteryLife_update.Text = "";
            //    txtPrice_update.Text = "";
            //    txtStockDate_update.Text = "";
            //}


        }
    }
}