using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ecommerce
{
    public partial class productedit : System.Web.UI.Page
    {
        Conclass obj = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid_bind();
            }

        }
        public void grid_bind()
        {
            string sele = "select * from product_tab ";
            DataSet ds = obj.fn_ExeAdapter(sele);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel2.Visible = true;
            string s = "select * from  product_tab ";
            SqlDataReader dr = obj.fn_ExeReader(s);
            while (dr.Read())
            {
                TextBox1.Text = dr["P_name"].ToString();
                Image1.ImageUrl = dr["P_image"].ToString();
                TextBox6.Text = dr["P_discription"].ToString();
                TextBox7.Text = dr["P_price"].ToString();
                TextBox8.Text = dr["P_stock"].ToString();
               


            }
            int id1 = Convert.ToInt32(e.CommandArgument);
            Session["uiid"] = id1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string p = "~/pic/~" + FileUpload2.FileName;
            FileUpload2.SaveAs(MapPath(p));
            string u = "update product_tab set P_name='" + TextBox1.Text + "',P_image='" + p + "',P_discription='" + TextBox6.Text + "' ,P_price='" + TextBox7.Text + "',P_stock='" + TextBox8.Text + "'where P_id=" + Session["uiid"] + "";
            int upd1 = obj.fn_NonQuery(u);
            grid_bind();
        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {

            Panel3.Visible = true;
            string n = "select * from  Product_tab ";
            SqlDataReader dr = obj.fn_ExeReader(n);
            while (dr.Read())
            {
                TextBox5.Text = dr["P_status"].ToString();


            }
            int id2 = Convert.ToInt32(e.CommandArgument);
            Session["uidd"] = id2;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string D = "update product_tab set P_status='" + TextBox5.Text + "' where P_id=" + Session["uidd"] + "";

            int upd2 = obj.fn_NonQuery(D);
            grid_bind();
        }
    }
}