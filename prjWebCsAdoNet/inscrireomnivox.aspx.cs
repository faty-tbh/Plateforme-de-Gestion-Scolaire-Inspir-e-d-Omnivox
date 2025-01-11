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
    public partial class inscrireomnivox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInscrire_Click(object sender, EventArgs e)
        {
            //recuperation des valeurs 
            string num = txtNum.Text.Trim();
            Int16 anneeN = Convert.ToInt16(txtAnneNaiss.Text);
            string eml = txtEmail.Text.Trim();
            string nom = "";
            string mdp = txtmdp.Text;

            //connection a la base de donnee 
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=OmnivoxDB;Integrated Security=True";
            mycon.Open();

            //creation de la requete de la commande 
            string sql = "SELECT Nom FROM Etudiants ";
            sql += "WHERE Numeno = '" + num + "' ";
            sql += "AND [AnnéeNaissance] = " + anneeN;
            sql += " AND Email = '" + eml + "'";

            SqlCommand mycmd = new SqlCommand(sql, mycon);
            SqlDataReader myrder = mycmd.ExecuteReader();
            //verifecation si user est un etudiant
            if (myrder.Read() == false)    //pas etudiant 
            {
                myrder.Close();
                mycon.Close();
                lblMessage.Text = "ce site web est reservé seulement aux étudiants !";

            }
            else   //user est etudiant
            {
                nom = myrder["Nom"].ToString();
                myrder.Close();

                //verivecation si étudiant est membre

                sql = "SELECT RefMembre FROM Membres ";
                sql += "WHERE Numero = '" + num + "'";
                SqlCommand mycmd1 = new SqlCommand(sql, mycon);
                SqlDataReader myreader1 = mycmd1.ExecuteReader();
                
                if(myreader1.Read() == true)   // deja membre
                {
                    myreader1.Close();
                    mycon.Close();
                    lblMessage.Text = "Vous etes deja membre, contacter l'administration !";

                }
                else
                {
                    myreader1.Close();
                    sql = "INSERT INTO Membres(Nom,Numero,Mot2passe,Statut) ";
                    sql += "VALUES('" + nom + "','" + num + "','" + mdp + "','actif')";

                    SqlCommand mycmd2 = new SqlCommand(sql, mycon);
                    mycmd2.ExecuteNonQuery();
                    mycon.Close();
                    Server.Transfer("acceuilOmnivox.aspx");

                }




            }
        }
    }
}