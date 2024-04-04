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
    public partial class product : System.Web.UI.Page
    {
        Conclass obj = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string c = "select C_name,C_id from categry_tab";
                DataSet ds = obj.fn_ExeAdapter(c);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "C_name";
                DropDownList1.DataValueField = "C_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "-select-");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/pic/~" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins1 = "insert into product_tab values(" + DropDownList1.SelectedItem.Value + ",'" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj.fn_NonQuery(ins1);
            if (i == 1)
            {
                Label7.Visible = true;
                Label7.Text = "success";
            }
        }
    }
}