using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace prjWebCsAdoNet
{
    public partial class effacerMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 refMsg = Convert.ToInt32(Request.QueryString["refM"].ToString());

            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=OmnivoxDB;Integrated Security=True";
            mycon.Open();
            string sql = "DELETE FROM Messages WHERE Messages.RefMessage =" + refMsg;
            SqlCommand mycmd = new SqlCommand(sql, mycon);
            mycmd.ExecuteNonQuery();
            mycon.Close();
            Server.Transfer("acceuilOmnivox.aspx");
        }
    }
}