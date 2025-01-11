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
    public partial class testAdoNet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection mycon = new SqlConnection();
                mycon.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OmivoxDB;Integrated Security=True";
                mycon.Open();
                string sql = "SELECT * FROM Etudiants";
                SqlCommand mycmd = new SqlCommand(sql, mycon);
                SqlDataReader myrder = mycmd.ExecuteReader();
                gridResultat.DataSource = myrder;
                gridResultat.DataBind();
                mycon.Close();
            }
        }
    }
}