using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class DogDelete : Form
    {
        // chaine de connexion
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // requête SQL pour supprimer l'utilisateur sélectionné, avec ses chiens et toutes ses promenades
        private const string DeleteQuery = "DELETE FROM promenade WHERE idChien=@idChien; " +
                                            "DELETE FROM chien WHERE idChien=@idChien;";


        public DogDelete()
        {
            // initialisation de la fenêtre
            InitializeComponent();
        }

        private void DogDelete_Load(object sender, EventArgs e)
        {
            // on rempli des informations de la table chien
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            comboBoxDogName_SelectedIndexChanged(sender, e);
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            // crée l'objet de connexion
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                // crée l'objet requête SQL
                using (MySqlCommand com = new MySqlCommand(DeleteQuery, con))
                {
                    // on récupère les données du formulaire en les liant aux paramètre de notre 
                    // requête
                    com.Parameters.AddWithValue("@idChien", comboBoxDogName.SelectedValue);
                    // on exécute la requête
                    com.ExecuteNonQuery();
                }
            }
            // fermeture de la fenêtre
            this.Close();
        }

        private void comboBoxDogName_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                con.Open();

                // requête select : on récupère les valeurs de la semaine pour le chien
                using (MySqlCommand selectCom = new MySqlCommand("getDays", con))
                {
                    selectCom.Parameters.AddWithValue("@uIdChien", comboBoxDogName.SelectedValue);
                    selectCom.CommandType = CommandType.StoredProcedure;

                    var reader = selectCom.ExecuteReader();
                    reader.Read();

                    // lundi
                    if (reader.GetString(0) == "True")
                        checkBoxLundi.Checked = true;
                    else
                        checkBoxLundi.Checked = false;

                    // mardi
                    if (reader.GetString(1) == "True")
                        checkBoxMardi.Checked = true;
                    else
                        checkBoxMardi.Checked = false;

                    // mercredi
                    if (reader.GetString(2) == "True")
                        checkBoxMercredi.Checked = true;
                    else
                        checkBoxMercredi.Checked = false;

                    // jeudi
                    if (reader.GetString(3) == "True")
                        checkBoxJeudi.Checked = true;
                    else
                        checkBoxJeudi.Checked = false;

                    // vendredi
                    if (reader.GetString(4) == "True")
                        checkBoxVendredi.Checked = true;
                    else
                        checkBoxVendredi.Checked = false;

                    // samedi
                    if (reader.GetString(5) == "True")
                        checkBoxSamedi.Checked = true;
                    else
                        checkBoxSamedi.Checked = false;

                    // dimanche
                    if (reader.GetString(6) == "True")
                        checkBoxDimanche.Checked = true;
                    else
                        checkBoxDimanche.Checked = false;
                }
            }
        }
    }
}
