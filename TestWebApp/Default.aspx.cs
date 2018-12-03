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
            SqlConnection conn = new SqlConnection("Server=tcp:trk20181203.database.windows.net,1433;Initial Catalog=Tracker;Persist Security Info=False;User ID=siva;Password=Test1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlDataAdapter adap = new SqlDataAdapter("select * from Incidents where MID='"+txtMID.Text+"'", conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            grdResults.DataSource = ds;
            grdResults.DataBind();
        }
    }
}