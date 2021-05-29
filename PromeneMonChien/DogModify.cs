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
        private const string UpdateQuery = "UPDATE chien SET idType=@idType, " +
            "idUtilisateur=@idUtilisateur, description=@description , lundi = @lundi, mardi = @mardi, " +
            "mercredi = @mercredi, jeudi = @jeudi, vendredi = @vendredi, samedi = @samedi, dimanche = @dimanche " +
            "WHERE idChien = @idChien";

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
                    com.Parameters.AddWithValue("@lundi", checkBoxLundi.Checked);
                    com.Parameters.AddWithValue("@mardi", checkBoxMardi.Checked);
                    com.Parameters.AddWithValue("@mercredi", checkBoxMercredi.Checked);
                    com.Parameters.AddWithValue("@jeudi", checkBoxJeudi.Checked);
                    com.Parameters.AddWithValue("@vendredi", checkBoxVendredi.Checked);
                    com.Parameters.AddWithValue("@samedi", checkBoxSamedi.Checked);
                    com.Parameters.AddWithValue("@dimanche", checkBoxDimanche.Checked);
                    // execution de la requête
                    com.ExecuteNonQuery();
                }
            }
            //fermeture de la fenêtre de modification
            this.Close();
        }
    }
}
