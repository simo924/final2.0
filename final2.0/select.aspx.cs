using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.OleDb;

namespace EX1
{
    public partial class select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Btn_select_Click(object sender, EventArgs e)
        {
            string dbpath = Server.MapPath("app_data\\ipods.mdb");
            string constr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + dbpath;
            OleDbConnection objCon = new OleDbConnection(constr);

            objCon.Open();
           // OleDbCommand objCmd = new OleDbCommand("select modelno, name from ipod where price >10000",
                 OleDbCommand objCmd = new OleDbCommand("select * from ipod",
            objCon);
            OleDbDataReader objDr = objCmd.ExecuteReader();
            lblRst.Text = "";
            if (objDr.HasRows)
            {
                lblRst.Text += "<table border='1' >";
                
                while (objDr.Read())
                {
                    lblRst.Text += "<tr>";

                    lblRst.Text = lblRst.Text + "<td>" + objDr["modelno"].ToString() + "</td>"
                                        + "<td>" + objDr["Name"].ToString() + "</td>"
                                        + " <td> " + objDr["Storage"].ToString() + " </ td > "
                                        + " <td> " + objDr["BatteryLife"].ToString() + " </ td > "
                                        + " <td> " + objDr["Price"].ToString() + " </ td > "
                                        + " <td> " + objDr["StockDate"].ToString() + " </ td > ";
                                        
                  
                    lblRst.Text += "</tr>";
                }
            }
           
            lblRst.Text += "</table>";
            objCon.Close();
            objDr.Close();
            objCon.Dispose();
            objCmd.Dispose();
            objDr.Dispose();

        }

        protected void Btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                string dbpath = Server.MapPath("app_data\\ipods.mdb");
                string constr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + dbpath;
                OleDbConnection objCon = new OleDbConnection(constr);
                objCon.Open();
                string sqlstr = "insert into ipod (modelno, name, Storage,BatteryLife,price,StockDate) values ('" + txtModelNo.Text + "','" +
                txtName.Text + "','" + txtStorage.Text + "'," + txtBatteryLife.Text + "," + txtPrice.Text + ", " + "#" + txtStockDate.Text + "#" + ")";
                OleDbCommand objCmd = new OleDbCommand(sqlstr, objCon);
                int row_cnt = objCmd.ExecuteNonQuery();
                if (row_cnt > 0)
                    lblMsg.Text = "成功新增" + row_cnt.ToString() + "筆資料。";
                else
                    lblMsg.Text = "並未新增資料。";
                objCon.Close();
                objCon.Dispose();
                objCmd.Dispose();
            }
            catch (Exception ex)
            {
                lblMsg.Text = "不可輸入相同資料。";
            }
         }

        protected void Btn_delete_Click(object sender, EventArgs e)
        {
         



            string dbpath = Server.MapPath("app_data\\ipods.mdb");
            string constr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + dbpath;
            OleDbConnection objCon = new OleDbConnection(constr);
            objCon.Open();
            string sqlstr = "delete from ipod where modelno = '" + txtModelNo_delete.Text + "'";
            OleDbCommand objCmd = new OleDbCommand(sqlstr, objCon);
            int row_cnt = objCmd.ExecuteNonQuery();
            if (row_cnt > 0)
                lblMsg_delete.Text = "成功刪除" + row_cnt.ToString() + "筆資料。<br> 已刪除 "+txtModelNo_delete.Text;
            else
                lblMsg_delete.Text = "並未刪除資料。";
            objCon.Close();
            objCon.Dispose();
            objCmd.Dispose();
        }

        protected void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {


                string dbpath = Server.MapPath("app_data\\ipods.mdb");
            string constr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + dbpath;
            OleDbConnection objCon = new OleDbConnection(constr);
            objCon.Open();
            string sqlstr = "update ipod set name='" + txtName_update.Text + 
                    "',BatteryLife = '" + txtBatteryLife_update.Text +
                    "',Storage = '" + txtStorage_update.Text  +
                    "',Price = " + txtPrice_update.Text +
                    ",StockDate = #" + txtStockDate_update.Text + "#" +
                    " where modelno = '" + txtModelNo_update.Text 
                    + "'";
            OleDbCommand objCmd = new OleDbCommand(sqlstr, objCon);
            int row_cnt = objCmd.ExecuteNonQuery();
            if (row_cnt > 0)
               lblMsg_update.Text = "成功更新" + row_cnt.ToString() + "筆資料。";
            else
                lblMsg_update.Text = "並未更新資料。";
            objCon.Close();
            objCon.Dispose();
            objCmd.Dispose();
          

              
            
            }
            catch (Exception ex)
            {
                lblMsg_update.Text = "錯誤";
                txtName_update.Text = "";
                txtStorage_update.Text = "";
                txtBatteryLife_update.Text = "";
                txtPrice_update.Text = "";
                txtStockDate_update.Text = "";
            }
        
    }
        
        protected void qurey_Click(object sender, EventArgs e)
        {
            try
            {

                string dbpath = Server.MapPath("app_data\\ipods.mdb");
                string constr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + dbpath;
                OleDbConnection objCon = new OleDbConnection(constr);

                objCon.Open();
                OleDbCommand objCmd = new OleDbCommand("select * from ipod where modelno = '" + txtModelNo_delete.Text
                    + "'",  objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)  
                if(objDr.Read()) { 
                        txtName_delete.Text = objDr["Name"].ToString();
                        txtStorage_delete.Text = objDr["Storage"].ToString(); 
                        txtBatteryLife_delete.Text = objDr["BatteryLife"].ToString();
                        txtPrice_delete.Text = objDr["Price"].ToString();
                        txtStockDate_delete.Text = objDr["StockDate"].ToString();
                    }
                    else
                    {
                        lblMsg_delete.Text = "找不到資料";
                    }

            


                objCon.Close();
                objDr.Close();
                objCon.Dispose();
                objCmd.Dispose();
                objDr.Dispose();
           
            }
            catch(Exception ex)
            {
                lblMsg_delete.Text = "輸入錯誤";
                txtName_delete.Text = "";
                txtStorage_delete.Text = "";
                txtBatteryLife_delete.Text = "";
                txtPrice_delete.Text = "";
                txtStockDate_delete.Text = "";
            }
        }

        protected void qurey_update_Click(object sender, EventArgs e)
        {
            try
            {

                string dbpath = Server.MapPath("app_data\\ipods.mdb");
                string constr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + dbpath;
                OleDbConnection objCon = new OleDbConnection(constr);

                objCon.Open();
                OleDbCommand objCmd = new OleDbCommand("select * from ipod where modelno = '" + txtModelNo_update.Text
                    + "'", objCon);
                OleDbDataReader objDr = objCmd.ExecuteReader();

                if (objDr.HasRows)
                {
                   if (objDr.Read())
                    {
                        txtName_update.Text = objDr["Name"].ToString();
                        txtStorage_update.Text = objDr["Storage"].ToString();
                        txtBatteryLife_update.Text = objDr["BatteryLife"].ToString();
                        txtPrice_update.Text = objDr["Price"].ToString();
                        //txtStockDate_update.Text = objDr["StockDate"].ToString();
                        string[] subs =objDr["StockDate"].ToString().Split(' ');
                        txtStockDate_update.Text = subs[0]; 
                    }
                    else
                    {
                        lblMsg_delete.Text = "找不到資料";
                    }

                }


                objCon.Close();
                objDr.Close();
                objCon.Dispose();
                objCmd.Dispose();
                objDr.Dispose();
                txtModelNo_update.Focus();
                txtModelNo_update.Enabled = false;
                Btn_update.Enabled = true;
                cancel.Enabled = true;
            }
            catch (Exception ex)
            {
                lblMsg_update.Text = "輸入錯誤";
                txtName_update.Text = "";
                txtStorage_update.Text = "";
                txtBatteryLife_update.Text = "";
                txtPrice_update.Text = "";
                txtStockDate_update.Text = "";
            }
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            txtModelNo_update.Enabled = true;
            txtModelNo_update.Focus();
            lblMsg_update.Text = "";
            txtName_update.Text = "";
            txtStorage_update.Text = "";
            txtBatteryLife_update.Text = "";
            txtPrice_update.Text = "";
            txtStockDate_update.Text = "";
        }
    }
}