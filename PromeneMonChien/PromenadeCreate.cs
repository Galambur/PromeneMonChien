using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class PromenadeCreate : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string InsertQuery = "INSERT INTO promenade(datePromenade, idUtilisateur, idChien) Values (@datePromenade, @idUtilisateur, @idChien)";

        public PromenadeCreate()
        {
            InitializeComponent();
        }

        private void PromenadeCreate_Load(object sender, System.EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.chien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);

        }

        private void validateButton_Click(object sender, System.EventArgs e)
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
                    com.Parameters.AddWithValue("@idUtilisateur", comboBoxUser.SelectedValue);
                    com.Parameters.AddWithValue("@idChien", comboBoxDog.SelectedValue);
                    // on exécute la requête
                    com.ExecuteNonQuery();
                }
            }
            // fermeture de la fenêtre
            this.Close();

        }
    }
}
