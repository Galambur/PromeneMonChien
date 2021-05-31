using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class UserActionPromenadeAdd : Form
    {
        int userId;
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string InsertQuery = "INSERT INTO promenade(datePromenade, idUtilisateur, idChien)" +
            " Values (@datePromenade, @idUtilisateur, @idChien)";
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
            comboBoxDog_SelectedIndexChanged(sender, e);
        }

        private void validateButton_Click(object sender, System.EventArgs e)
        {
            
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion avec la base de données
                con.Open();

                // requête select : on récupère les valeurs de la semaine pour le chien
                using (MySqlCommand selectCom = new MySqlCommand("getDays", con))
                {
                    // on paramètre la procédure stockée
                    selectCom.Parameters.AddWithValue("@uIdChien", comboBoxDog.SelectedValue);
                    selectCom.CommandType = CommandType.StoredProcedure;

                    // création du reader
                    var reader = selectCom.ExecuteReader();
                    reader.Read();

                    // si la date choisie est bloquée par le propriétaire
                    if (((int)dateTimePicker.Value.DayOfWeek == 1 && reader.GetString(0) == "True") ||  //lundi
                    ((int)dateTimePicker.Value.DayOfWeek == 2 && reader.GetString(1) == "True") ||      //mardi
                    ((int)dateTimePicker.Value.DayOfWeek == 3 && reader.GetString(2) == "True") ||      //mercredi
                    ((int)dateTimePicker.Value.DayOfWeek == 4 && reader.GetString(3) == "True") ||      //jeudi
                    ((int)dateTimePicker.Value.DayOfWeek == 5 && reader.GetString(4) == "True") ||      //vendredi
                    ((int)dateTimePicker.Value.DayOfWeek == 6 && reader.GetString(5) == "True") ||      //samedi
                    ((int)dateTimePicker.Value.DayOfWeek == 7 && reader.GetString(6) == "True"))        //dimanche
                    {
                        MessageBox.Show("Chien indisponible ce jour là");
                        reader.Close();
                    }
                    else 
                    {
                        reader.Close();
                        // cette variable reste à true si le chien n'a pas de promenade ce jour là
                        bool estDisponible = true;


                        using (MySqlCommand comPromenade = new MySqlCommand(SelectPromenadesQuery, con))
                        {
                            comPromenade.Parameters.AddWithValue("@idChien", comboBoxDog.SelectedValue);
                            var readerPromenade = comPromenade.ExecuteReader();
                            int count = readerPromenade.FieldCount;

                            while (readerPromenade.Read())
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    // on enlève l'heure choisie pour comparer les jours
                                    // si le chien a déjà une promenade ce jour là
                                    if (readerPromenade.GetString(0).Remove(11) == dateTimePicker.Value.ToString().Remove(11))
                                    {
                                        // cette variable reste à true si le chien n'a pas de promenade ce jour là
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
                                // on utilise ce qu'on a entré dans le formulaire pour les paramètres de la requête
                                com.Parameters.AddWithValue("@datePromenade", dateTimePicker.Value);
                                // identifiant de l'utilisateur connecté
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

        private void comboBoxDog_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bindingSourceDays = new BindingSource();
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(myConn);
            con.Open();

            MySqlCommand myCmd = new MySqlCommand("getDays", con);
            myCmd.Parameters.AddWithValue("@uIdChien", comboBoxDog.SelectedValue);
            myCmd.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(myCmd);
            da.Fill(dt);
            bindingSourceDays.DataSource = dt;
            dataGridViewDays.DataSource = bindingSourceDays;

            con.Close();
        }
    }
}
