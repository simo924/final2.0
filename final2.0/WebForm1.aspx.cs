using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final2._0
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            test();
        }
        void test()
        {
            lbl_test.Text =
                "<table id=\"table_result\">";
            for (int i = 0; i < 30; i++)
            {
                lbl_test.Text += "<tr><td>";
                lbl_test.Text += i + 1;
                lbl_test.Text += "</tr></td>";
            }



            lbl_test.Text += "</table>";

        }
    }
}