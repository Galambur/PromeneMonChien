using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class UserActionDogAdd : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // requête pour ajouter un chien dans la base de données
        private const string InsertQuery = "INSERT INTO chien(nomChien, idType, idUtilisateur, description, lundi, mardi, mercredi, jeudi, vendredi, samedi, dimanche) " +
            "Values (@nomChien, @idType, @idUtilisateur, @description, @lundi, @mardi, @mercredi, @jeudi, @vendredi, @samedi, @dimanche)";

        int userId;


        public UserActionDogAdd(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                using (MySqlCommand com = new MySqlCommand(InsertQuery, con))
                {
                    // récupération des données du formulaire
                    // on les lie aux paramètres de la requête SQL
                    com.Parameters.AddWithValue("@nomChien", textBoxDogName.Text);
                    com.Parameters.AddWithValue("@idType", comboBoxDogType.SelectedValue);
                    com.Parameters.AddWithValue("@idUtilisateur", this.userId);
                    com.Parameters.AddWithValue("@description", descriptionBox.Text);
                    com.Parameters.AddWithValue("@lundi", checkBoxLundi.Checked);
                    com.Parameters.AddWithValue("@mardi", checkBoxMardi.Checked);
                    com.Parameters.AddWithValue("@mercredi", checkBoxMercredi.Checked);
                    com.Parameters.AddWithValue("@jeudi", checkBoxJeudi.Checked);
                    com.Parameters.AddWithValue("@vendredi", checkBoxVendredi.Checked);
                    com.Parameters.AddWithValue("@samedi", checkBoxSamedi.Checked);
                    com.Parameters.AddWithValue("@dimanche", checkBoxDimanche.Checked);
                    com.ExecuteNonQuery();
                }
            }
            // on revient à la page d'accueil après l'ajout du chien
            FormMainUser f = new FormMainUser(this.userId);
            this.Hide();
            f.ShowDialog();
            this.Close();

        }

        private void UserActionDogAdd_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.type'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeTableAdapter.Fill(this.promenemonchienDataSet.type);

        }
    }
}
