using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final2._0
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            { //session 方式
               
                LOGIN.Visible = false;
                LOGIN_OUT.Visible = true;
                Label2.Text = "歡迎"+Convert.ToString(Session["user"]);
            }
            if
                (Session["admin"] != null)
            { //session 方式
                LOGIN.Visible = false;
                LOGIN_OUT.Visible = true;
                Label2.Text = "歡迎" + Convert.ToString(Session["admin"]);
                admin.Visible = true;
            }
        }

        protected void LOGIN_OUT_Click(object sender, EventArgs e)
        {
            Session["count"] = null;
            Session["user"] = null;
            Session["admin"] = null;
            LOGIN.Visible = true;
            LOGIN_OUT.Visible = false;
            Response.Redirect("final_index");
        }

        protected void LOGIN_Click(object sender, EventArgs e)
        {
            Response.Redirect("/login");
        }

        protected void ADMIN_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin");
        }
    }
}