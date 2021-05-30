using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace PromeneMonChien
{
    public partial class PromenadeCreate : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string InsertQuery = "INSERT INTO promenade(datePromenade, idUtilisateur, idChien) Values (@datePromenade, @idUtilisateur, @idChien)";
        private const string SelectQuery = "SELECT lundi, mardi, mercredi, jeudi, vendredi, samedi, dimanche " +
            "FROM chien " +
            "WHERE idChien = @idChien";

        public PromenadeCreate()
        {
            InitializeComponent();
        }

        private void PromenadeCreate_Load(object sender, System.EventArgs e)
        {
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);

        }

        private void validateButton_Click(object sender, System.EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(myConn);
            // partie select
            MySqlCommand selectCom = new MySqlCommand(SelectQuery, con);
            MySqlDataReader reader;

            using (con)
            {
                con.Open();

                // requête select
                using (selectCom)
                {
                    selectCom.Parameters.AddWithValue("@idChien", comboBoxDog.SelectedValue);
                    reader = selectCom.ExecuteReader();
                    reader.Read();

                    if (((int)dateTimePicker.Value.DayOfWeek == 1 && reader.GetString(0) == "True") ||
                    ((int)dateTimePicker.Value.DayOfWeek == 2 && reader.GetString(1) == "True") ||
                    ((int)dateTimePicker.Value.DayOfWeek == 3 && reader.GetString(2) == "True") ||
                    ((int)dateTimePicker.Value.DayOfWeek == 4 && reader.GetString(3) == "True") ||
                    ((int)dateTimePicker.Value.DayOfWeek == 5 && reader.GetString(4) == "True") ||
                    ((int)dateTimePicker.Value.DayOfWeek == 6 && reader.GetString(5) == "True") ||
                    ((int)dateTimePicker.Value.DayOfWeek == 7 && reader.GetString(6) == "True"))
                    {
                        MessageBox.Show("Chien indisponible ce jour là");
                        reader.Close();
                    } else
                    {
                        reader.Close();
                        // requête insert
                        using (MySqlCommand com = new MySqlCommand(InsertQuery, con))
                        {
                            com.Parameters.AddWithValue("@datePromenade", dateTimePicker.Value);
                            com.Parameters.AddWithValue("@idUtilisateur", comboBoxUser.SelectedValue);
                            com.Parameters.AddWithValue("@idChien", comboBoxDog.SelectedValue);
                            com.ExecuteNonQuery();
                        }
                        // fermeture de la fenêtre
                        this.Close();
                    }
                }
            }

        }
    }
}
