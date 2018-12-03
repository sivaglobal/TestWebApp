using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TestWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String connstr = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
            SqlDataAdapter adap = new SqlDataAdapter("select * from Incidents where MID='"+txtMID.Text+"'", conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            grdResults.DataSource = ds;
            grdResults.DataBind();
        }
    }
}