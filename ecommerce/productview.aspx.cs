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
    public partial class productview : System.Web.UI.Page
    {
        Conclass obj = new Conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sele1 = "select * from product_tab  where C_id='" + Session["id"] + "'";
                DataSet ds = obj.fn_ExeAdapter(sele1);
                DataList1.DataSource = ds;
                DataList1.DataBind();

            }

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Session["P_id"] = id;
            Response.Redirect("singleproduct_view.aspx");
            
        }
    }
}