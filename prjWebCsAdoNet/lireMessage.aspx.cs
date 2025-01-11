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
    public partial class lireMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 refMsg = Convert.ToInt32(Request.QueryString["refM"].ToString());

            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=OmnivoxDB;Integrated Security=True";
            mycon.Open();
            // "SELECT * FROM Messages WHERE RefMessage =" + refMsg;
            string sql = "SELECT Messages.*, Membres.Nom FROM Messages, Membres ";
            sql += "WHERE Membres.RefMembre = Messages.Envoyeur AND Messages.RefMessage =" + refMsg;
            SqlCommand mycmd = new SqlCommand(sql, mycon);
            SqlDataReader myrder = mycmd.ExecuteReader();
            if (myrder.Read())
            {
                string info = "Titre : " + myrder["Titre"].ToString() + " <br />";
                info += "Date : " + myrder["Date"].ToString() + " <br />";
                info += "De : " + myrder["Nom"].ToString() + " <br />";
                info += "Message : " + myrder["Message"].ToString() + " <br />";
                lblMessage.Text = info;
            }
            myrder.Close();
            mycon.Close();

        }
    }
}