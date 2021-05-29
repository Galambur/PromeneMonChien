using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class DogModify : Form
    {
        // chaine de connexion
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties." +
            "Settings.promenemonchienConnectionString"].ConnectionString;
        // requête SQL pour modifier la ligne désirée
        private const string UpdateQuery = "Update chien set idType=@idType, " +
            "idUtilisateur=@idUtilisateur, description=@description " +
            "where idChien = @idChien";

        public DogModify()
        {
            InitializeComponent();
        }

        private void DogModify_Load(object sender, EventArgs e)
        {
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            this.typeTableAdapter.Fill(this.promenemonchienDataSet.type);

        }

        private void validateButton_Click(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                using (MySqlCommand com = new MySqlCommand(UpdateQuery, con))
                {
                    // récupération des données du formulaire, on les relie aux paramètre de
                    // notre requête SQL
                    com.Parameters.AddWithValue("@idChien", comboBoxDog.SelectedValue);
                    com.Parameters.AddWithValue("@idType", comboBoxType.SelectedValue);
                    com.Parameters.AddWithValue("@idUtilisateur", comboBoxProprietaire.SelectedValue);
                    com.Parameters.AddWithValue("@description", descriptionBox.Text);
                    // execution de la requête
                    com.ExecuteNonQuery();
                }
            }
            //fermeture de la fenêtre de modification
            MessageBox.Show("Modification réalisée avec succès");
            this.Close();
        }
    }
}
