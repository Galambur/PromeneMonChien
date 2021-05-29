using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class DogAdd : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string InsertQuery = "INSERT INTO chien(nomChien, idType, idUtilisateur, description)" +
            " Values (@nomChien, @idType, @idUtilisateur, @description)";

        public DogAdd()
        {
            InitializeComponent();
        }

        private void AddDog_Load(object sender, EventArgs e)
        {
            // cette ligne de code charge les données dans la table 'promenemonchienDataSet.type'
            this.typeTableAdapter.Fill(this.promenemonchienDataSet.type);
            // cette ligne de code charge les données dans la table 'promenemonchienDataSet.utilisateur'
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);

        }

        private void validateButton_clicked(object sender, EventArgs e)
        {
            // création de l'objet connexion
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouvre la connexion avec la base de données
                con.Open();
                // création de l'objet requête SQL
                using (MySqlCommand com = new MySqlCommand(InsertQuery, con))
                {
                    // recupération des données du formulaire
                    com.Parameters.AddWithValue("@nomChien", textBoxDogName.Text);
                    com.Parameters.AddWithValue("@idType", comboBoxDogType.SelectedValue);
                    com.Parameters.AddWithValue("@idUtilisateur", comboBoxUser.SelectedValue);
                    com.Parameters.AddWithValue("@description", descriptionBox.Text);
                    com.ExecuteNonQuery();
                }
            }
            this.Close();
        }
    }
}
