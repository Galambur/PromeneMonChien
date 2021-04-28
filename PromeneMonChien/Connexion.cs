using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class Connexion : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string SelectQuery = "SELECT idUtilisateur FROM utilisateur WHERE email = @email AND mdp = @mdp";

        public Connexion()
        {
            InitializeComponent();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            bool result;
            MySqlDataReader user;

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
                    user = com.ExecuteReader();
                    result = user.HasRows;
                    user.Read();
                    if ((emailBox.Text == "g@d") && (passwordBox.Text == "123") && (result == true))
                    {
                        FormMainAdmin f = new FormMainAdmin(user.GetInt32("idUtilisateur"));
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (result == true)
                    {
                        FormMainUser f = new FormMainUser(user.GetInt32("idUtilisateur"));
                        this.Hide();
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (result == false)
                    {
                        MessageBox.Show("Email ou mot de passe incorrect");
                        emailBox.Text = String.Empty;
                        passwordBox.Text = String.Empty;
                    }
                }
            }
        }
    }
}
