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
    public partial class ecrireMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false) { 
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=OmnivoxDB;Integrated Security=True";
            mycon.Open();
            string sql = "SELECT RefMembre,Nom,Numero FROM Membres ";
            SqlCommand mycmd = new SqlCommand(sql, mycon);
            SqlDataReader myrder = mycmd.ExecuteReader();
            while (myrder.Read())
            {
                string tmp = myrder["Nom"].ToString() + " (" +
                    myrder["Numero"].ToString() + " )";
                ListItem el = new ListItem();
                el.Text = tmp;
                el.Value = myrder["RefMembre"].ToString();
                cboDestinataires.Items.Add(el);
            }
            myrder.Close();
            mycon.Close();

            }
        }

        protected void btnEnvoyer_Click(object sender, EventArgs e)
        {
            Int32 refEnv = Convert.ToInt32(Session["userId"]);
            Int32 refDest = Convert.ToInt32(cboDestinataires.SelectedItem.Value);
            string tit = txtTitre.Text.Trim();
            string mess = txtMessage.Text.Trim();
            if (tit.Length == 0)
            {
                lblErreur.Text = "Veuillez mettre un Titre à votre messsage";
                txtTitre.Focus();
            }
            else
            {
                SqlConnection mycon = new SqlConnection();
                mycon.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=OmnivoxDB;Integrated Security=True";
                mycon.Open();
                //string sql = "INSERT INTO Messages(Titre,Message,Envoyeur,Receveur,Nouveau) " +
                // "VALUES('" + tit + "','" + mess + "'," + refEnv + "," + refDest + ",'True')";
                
                string sql = "INSERT INTO Messages(Titre,Message,Envoyeur,Receveur,Nouveau) " +
                   "VALUES(@partit, @parmess, @parrefEnv, @parrefDest,'True')";
                
                SqlCommand mycmd = new SqlCommand(sql, mycon);
                mycmd.Parameters.AddWithValue("partit", tit);
                mycmd.Parameters.AddWithValue("parmess", mess);
                mycmd.Parameters.AddWithValue("parrefEnv", refEnv);
                mycmd.Parameters.AddWithValue("parrefDest", refDest);
                mycmd.ExecuteNonQuery();
                mycon.Close();
                Server.Transfer("acceuilOmnivox.aspx");
            }
        }

        protected void btnEffacer_Click(object sender, EventArgs e)
        {
            lblErreur.Text = txtMessage.Text = txtTitre.Text = "";
            txtTitre.Focus();
        }
    }
}