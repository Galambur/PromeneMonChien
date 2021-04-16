using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class UserCreate : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string InsertQuery = "INSERT INTO utilisateur(nomUtilisateur, prenomUtilisateur, proprietaire, idVille, telephone, email, mdp) Values (@nomUtilisateur, @prenomUtilisateur, @proprietaire, @idVille, @telephone, @email, @mdp)";

        public UserCreate()
        {
            InitializeComponent();
        }

        private void validateButton_clicked(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                using (MySqlCommand com = new MySqlCommand(InsertQuery, con))
                {
                    // on récupère les données du formulaire en les liant aux paramètre de notre 
                    // requête
                    com.Parameters.AddWithValue("@nomUtilisateur", nameBox.Text);
                    com.Parameters.AddWithValue("@prenomUtilisateur", firstNameBox.Text);
                    com.Parameters.AddWithValue("@proprietaire", checkBoxProprietaire.Checked);
                    com.Parameters.AddWithValue("@idVille", comboBox1.SelectedValue);
                    com.Parameters.AddWithValue("@telephone", phoneBox.Text);
                    com.Parameters.AddWithValue("@email", emailBox.Text);
                    com.Parameters.AddWithValue("@mdp", passwordBox.Text);
                    // on exécute la requête
                    com.ExecuteNonQuery();
                }
            }
            // fermeture de la fenêtre
            this.Close();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
            this.villeTableAdapter.Fill(this.promenemonchienDataSet.ville);
        }
    }
}
