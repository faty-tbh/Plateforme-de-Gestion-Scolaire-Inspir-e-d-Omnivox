using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsAdoNet
{
    public partial class indexomnivox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
            {
                //recuperer numero et mdp
                string num = txtNumero.Text.Trim();
                string mdp = txtMot2passe.Text.Trim();
                SqlConnection mycon = new SqlConnection();
                mycon.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=OmnivoxDB;Integrated Security=True";
                mycon.Open();
                string sql = "SELECT RefMembre FROM Membres WHERE Numero ='" + num + "' AND Mot2passe ='" + mdp + "'";
                SqlCommand mycmd = new SqlCommand(sql, mycon);
                SqlDataReader myrder = mycmd.ExecuteReader();

                // verifier si membre existe
                if (myrder.Read() == false)
                {
                    mycon.Close();
                    lblErreur.Text = "numero ou mot de passe incorrect";
                }

                else
                {
                // sauvgarder le RefMembre dans une variable global de session
                    Session["userId"] = myrder["RefMembre"];
                    mycon.Close();
                    Server.Transfer("acceuilOmnivox.aspx");
                }
            
        }

        protected void btnInscrire_Click(object sender, EventArgs e)
        {

        }
    }
}