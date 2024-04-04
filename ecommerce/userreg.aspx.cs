using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ecommerce
{
    public partial class userreg : System.Web.UI.Page
    {
        Conclass obj = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string sel = "select max(Reg_id) from loginn_tab ";
            string regid = obj.fn_Scalar(sel);
            int Reg_id = 0;
            if (regid == "")
            {
                Reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                Reg_id = newregid + 1;
            }
            string ins = "insert into user_reg_tab values(" + Reg_id + ",'" + TextBox1.Text + "'," + TextBox2.Text + "," + TextBox3.Text + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox12.Text + "'," + TextBox8.Text + ",'active')";
            int i = obj.fn_NonQuery(ins);
            if (i != 0)
            {
                string inslog = "insert into loginn_tab values(" + Reg_id + ",'" + TextBox10.Text + "','" + TextBox11.Text + "','user','active')";
                int n = obj.fn_NonQuery(inslog);
            }
        }
    }
}
