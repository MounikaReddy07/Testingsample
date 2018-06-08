using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewstateEg
{
    public partial class Viewstate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Name"] != null)
                Label1.Text = ViewState["Name"].ToString();
            else
                Label1.Text = "Not yet assigned";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["Name"] = TextBox1.Text;
            Label1.Text = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            Label1.Text = "Not yet assigned";
            
        }
    }
}