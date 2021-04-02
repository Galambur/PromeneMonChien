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
    public partial class AddDog : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // on ne spécifie pas l'id car il s'auto incrémentera tout seul à partir du dernier id de la bdd
        private const string InsertQuery = "INSERT INTO chien(nomChien, idType, idUtilisateur, description) Values (@nomChien, @idType, @idUtilisateur, @description)";

        public AddDog()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AddDog_Load(object sender, EventArgs e)
        {
            this.typeTableAdapter.Fill(this.promenemonchienDataSet.type);
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);

        }

        private void validateButton_clicked(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@nomChien", textBoxDogName.Text);
                    com.Parameters.AddWithValue("@idType", comboBoxDogType.SelectedValue);
                    com.Parameters.AddWithValue("@idUtilisateur", comboBoxUser.SelectedValue);
                    com.Parameters.AddWithValue("@description", descriptionBox.Text);
                    com.ExecuteNonQuery();
                }
            }
            this.Close();
        }
    }
}
