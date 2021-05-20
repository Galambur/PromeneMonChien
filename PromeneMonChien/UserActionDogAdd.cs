using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class UserActionDogAdd : Form
    {
        int userId;
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        private const string InsertQuery = "INSERT INTO chien(nomChien, idType, idUtilisateur, description) Values (@nomChien, @idType, @idUtilisateur, @description)";

        public UserActionDogAdd(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@nomChien", textBoxDogName.Text);
                    com.Parameters.AddWithValue("@idType", comboBoxDogType.SelectedValue);
                    com.Parameters.AddWithValue("@idUtilisateur", this.userId);
                    com.Parameters.AddWithValue("@description", descriptionBox.Text);
                    com.ExecuteNonQuery();
                }
            }
            this.Close();

        }

        private void UserActionDogAdd_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.type'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.typeTableAdapter.Fill(this.promenemonchienDataSet.type);

        }
    }
}
