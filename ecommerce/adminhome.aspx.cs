using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce
{
    public partial class adminhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton3_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("product.aspx");
        }

        protected void LinkButton4_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("productedit.aspx");
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("category.aspx");
        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("categoryedit.aspx");

        }
    }
}