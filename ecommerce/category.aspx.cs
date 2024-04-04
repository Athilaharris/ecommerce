using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ecommerce
{
    public partial class category : System.Web.UI.Page
    {
        Conclass obj = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/pic/~" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into categry_tab values('" + TextBox1.Text + "','" + p + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int i = obj.fn_NonQuery(ins);
            if (i == 1)
            {
                Label5.Text = "success";
            }
        }
    }
}