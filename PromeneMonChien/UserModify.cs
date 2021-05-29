using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class UserModify : Form
    {
        // chaine de connexion
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties." +
            "Settings.promenemonchienConnectionString"].ConnectionString;
        // requête SQL pour modifier la ligne désirée
        private const string UpdateQuery = "Update utilisateur set prenomUtilisateur=@prenomUtilisateur," +
            " proprietaire=@proprietaire, idVille=@idVille, " +
            "telephone=@telephone, email=@email, mdp=@mdp where idUtilisateur=@idUtilisateur";
        public UserModify()
        {
            InitializeComponent();
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
            this.villeTableAdapter.Fill(this.promenemonchienDataSet.ville);

        }

        private void validateButton_clicked(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                using (MySqlCommand com = new MySqlCommand(UpdateQuery, con))
                {
                    // récupération des données du formulaire, on les relie aux paramètre de
                    // notre requête SQL
                    com.Parameters.AddWithValue("@idUtilisateur", comboBoxUserName.SelectedValue);
                    com.Parameters.AddWithValue("@prenomUtilisateur", firstNameBox.Text);
                    com.Parameters.AddWithValue("@proprietaire", checkBoxProprietaire.Checked);
                    com.Parameters.AddWithValue("@idVille", comboBoxCity.SelectedValue);
                    com.Parameters.AddWithValue("@telephone", phoneBox.Text);
                    com.Parameters.AddWithValue("@email", emailBox.Text);
                    com.Parameters.AddWithValue("@mdp", passwordBox.Text);
                    // execution de la requête
                    com.ExecuteNonQuery();
                }
            }
            //fermeture de la fenêtre de modification
            this.Close();
        }
    }
}
