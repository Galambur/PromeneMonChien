using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class CreateUser : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string InsertQuery = "INSERT INTO utilisateur(nomUtilisateur, prenomUtilisateur, proprietaire, idVille, telephone, email, mdp) Values (@nomUtilisateur, @prenomUtilisateur, @proprietaire, @idVille, @telephone, @email, @mdp)";

        public CreateUser()
        {
            InitializeComponent();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

        private bool SaveUserDetails(utilisateur uti) 
        {
            bool result = false;
            using (PromeneMonChienContext _entity = new PromeneMonChienContext())
            {
                _entity.utilisateurs.Add(uti);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
            this.villeTableAdapter.Fill(this.promenemonchienDataSet.ville);

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
