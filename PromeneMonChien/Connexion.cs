using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class Connexion : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string SelectQuery = "SELECT * FROM utilisateur WHERE email = @email AND mdp = @mdp";

        public Connexion()
        {
            InitializeComponent();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserTitle_Click(object sender, EventArgs e)
        {

        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            string emailTyped = emailBox.Text;
            string passwordTyped = passwordBox.Text;
            int attempt = 0;

            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                using (MySqlCommand com = new MySqlCommand(SelectQuery, con))
                {
                    // on récupère les données du formulaire en les liant aux paramètre de notre 
                    // requête
                    com.Parameters.AddWithValue("@email", emailBox.Text);
                    com.Parameters.AddWithValue("@mdp", passwordBox.Text);
                    // on exécute la requête
                    com.ExecuteNonQuery();
                }
            }

            if ((email == "g@d") && (password == "123"))
            {
                attempt = 0;
                MessageBox.Show("you are granted with access");
            }
            else if ((attempt == 3) && (attempt > 0))
            {
                MessageBox.Show("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
            }
            else
            {
                attempt = 0;
                MessageBox.Show("you are not granted with access");
            }
        }
    }
}
