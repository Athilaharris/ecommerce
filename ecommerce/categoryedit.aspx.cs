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
    public partial class categoryedit : System.Web.UI.Page
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
            string sele = "select * from categry_tab ";
            DataSet ds = obj.fn_ExeAdapter(sele);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton3_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            string s = "select * from  categry_tab ";
            SqlDataReader dr = obj.fn_ExeReader(s);
            while (dr.Read())
            {
                TextBox4.Text = dr["C_name"].ToString();
                Image1.ImageUrl = dr["C_image"].ToString();
                TextBox3.Text = dr["C_discription"].ToString();

            }
            int id1 = Convert.ToInt32(e.CommandArgument);
            Session["uid"] = id1;
            

        }
        protected void LinkButton4_Command(object sender, CommandEventArgs e)
        {
            Panel2.Visible = true;
            string n = "select * from  categry_tab ";
            SqlDataReader dr = obj.fn_ExeReader(n);
            while (dr.Read())
            {
                TextBox5.Text = dr["C_status"].ToString();


            }
            int id2 = Convert.ToInt32(e.CommandArgument);
            Session["uid1"] = id2;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string p = "~/pic/~" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string u = "update categry_tab set C_name='" + TextBox4.Text + "',C_image='" + p + "',C_discription='" + TextBox3.Text + "' where C_id=" + Session["uid"] + "";
            int upd1 = obj.fn_NonQuery(u);
            grid_bind();

        }

       

       


        protected void Button3_Click(object sender, EventArgs e)
        {
            string D = "update categry_tab set C_status='" + TextBox5.Text + "' where C_id=" + Session["uid1"] + "";
           
            int upd2 = obj.fn_NonQuery(D);
            grid_bind();
        }
    }
}