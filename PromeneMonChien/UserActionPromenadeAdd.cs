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
    public partial class UserActionPromenadeAdd : Form
    {
        int userId;
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string InsertQuery = "INSERT INTO promenade(datePromenade, idUtilisateur, idChien) Values (@datePromenade, @idUtilisateur, @idChien)";
        
        public UserActionPromenadeAdd(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void UserActionPromenadeAdd_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.chien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);

        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                using (MySqlCommand com = new MySqlCommand(InsertQuery, con))
                {
                    // on récupère les données du formulaire en les liant aux paramètre de notre 
                    // requête
                    com.Parameters.AddWithValue("@datePromenade", dateTimePicker.Value);
                    com.Parameters.AddWithValue("@idUtilisateur", this.userId);
                    com.Parameters.AddWithValue("@idChien", comboBoxDog.SelectedValue);
                    // on exécute la requête
                    com.ExecuteNonQuery();
                }
            }
            // fermeture de la fenêtre
            FormMainUser f = new FormMainUser(this.userId);
            this.Hide();
            f.ShowDialog();
            this.Close();

        }
    }
}
