using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class DogDelete : Form
    {
        // chaine de connexion
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // requête SQL pour supprimer l'utilisateur sélectionné, avec ses chiens et toutes ses promenades
        private const string DeleteQuery = "DELETE FROM promenade WHERE idChien=@idChien; " +
                                            "DELETE FROM chien WHERE idChien=@idChien;";


        public DogDelete()
        {
            // initialisation de la fenêtre
            InitializeComponent();
        }

        private void DogDelete_Load(object sender, EventArgs e)
        {
            // on rempli des informations de la table chien
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            // crée l'objet de connexion
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                // crée l'objet requête SQL
                using (MySqlCommand com = new MySqlCommand(DeleteQuery, con))
                {
                    // on récupère les données du formulaire en les liant aux paramètre de notre 
                    // requête
                    com.Parameters.AddWithValue("@idChien", comboBoxDogName.SelectedValue);
                    // on exécute la requête
                    com.ExecuteNonQuery();
                }
            }
            // fermeture de la fenêtre
            this.Close();
        }
    }
}
