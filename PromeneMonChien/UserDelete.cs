using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class UserDelete : Form
    {        
        // chaine de connexion
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // requête SQL pour supprimer l'utilisateur sélectionné, avec ses chiens et toutes ses promenades
        private const string DeleteQuery = "DELETE FROM promenade WHERE idUtilisateur=@idUtilisateur; " +
                                            "DELETE FROM chien WHERE idUtilisateur=@idUtilisateur;" +
                                            "DELETE FROM utilisateur WHERE idUtilisateur=@idUtilisateur;";
                            
        public UserDelete()
        {
            InitializeComponent();
        }

        private void validateButton_clicked(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                using (MySqlCommand com = new MySqlCommand(DeleteQuery, con))
                {
                    // on récupère les données du formulaire en les liant aux paramètre de notre 
                    // requête
                    com.Parameters.AddWithValue("@idUtilisateur", comboBoxUserName.SelectedValue);
                    // on exécute la requête
                    com.ExecuteNonQuery();
                }
            }
            // fermeture de la fenêtre
            this.Close();
        }

        private void UserDelete_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.ville'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.villeTableAdapter.Fill(this.promenemonchienDataSet.ville);
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);

        }
    }
}
