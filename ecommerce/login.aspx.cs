using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ecommerce
{
    public partial class login : System.Web.UI.Page
    {
        Conclass obj = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_id) from loginn_tab where L_username='" + TextBox1.Text + "'and L_Password='" + TextBox2.Text + "'";
            string cid = obj.fn_Scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select Reg_id from loginn_tab where L_username='" + TextBox1.Text + "'and L_Password='" + TextBox2.Text + "'";
                string regid = obj.fn_Scalar(str1);
                Session["U_id"] = regid;
                string str2 = "select L_logtype from loginn_tab where L_username='" + TextBox1.Text + "'and L_Password='" + TextBox2.Text + "'";
                string logtype = obj.fn_Scalar(str2);
                if (logtype == "admin")
                {
                    Label4.Text = "admin";
                }
                else if (logtype == "user")
                {
                    Label4.Text = "user";
                }
            }
        }
    }
}
     
 
        