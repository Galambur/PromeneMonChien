using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class UserActionPromenadeAdd : Form
    {
        int userId;
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string InsertQuery = "INSERT INTO promenade(datePromenade, idUtilisateur, idChien) Values (@datePromenade, @idUtilisateur, @idChien)";
        private const string SelectQuery = "SELECT lundi, mardi, mercredi, jeudi, vendredi, samedi, dimanche " +
            "FROM chien " +
            "WHERE idChien = @idChien";
        private const string SelectPromenadesQuery = "SELECT datePromenade " +
            "FROM promenade " +
            "WHERE idChien = @idChien";

        public UserActionPromenadeAdd(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void UserActionPromenadeAdd_Load(object sender, EventArgs e)
        {
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);

        }

        private void validateButton_Click(object sender, System.EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(myConn);
            MySqlCommand selectCom = new MySqlCommand(SelectQuery, con);
            MySqlCommand comPromenade = new MySqlCommand(SelectPromenadesQuery, con);
            MySqlDataReader reader;
            MySqlDataReader readerPromenade;

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
                    }
                    else // le propriétaire du chien n'a pas précisé que le jour choisi le chien ne peut pas être promené
                    {
                        // vérification que le chien ne fait pas déjà une promenade ce jour là
                        reader.Close();
                        bool estDisponible = true;


                        using (comPromenade)
                        {
                            comPromenade.Parameters.AddWithValue("@idChien", comboBoxDog.SelectedValue);
                            readerPromenade = comPromenade.ExecuteReader();
                            int count = readerPromenade.FieldCount;

                            while (readerPromenade.Read())
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    // on enlève l'heure choisie pour comparer les jours
                                    if (readerPromenade.GetString(0).Remove(11) == dateTimePicker.Value.ToString().Remove(11))
                                    {
                                        estDisponible = false;
                                        MessageBox.Show("Ce chien est déjà en promenade ce jour là");
                                    }
                                }
                            }
                            readerPromenade.Close();
                        }
                        if (estDisponible == true)
                        {
                            // requête insert
                            using (MySqlCommand com = new MySqlCommand(InsertQuery, con))
                            {
                                com.Parameters.AddWithValue("@datePromenade", dateTimePicker.Value);
                                com.Parameters.AddWithValue("@idUtilisateur", this.userId);
                                com.Parameters.AddWithValue("@idChien", comboBoxDog.SelectedValue);
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

        }
    }
}
