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
    public partial class ModifyUser : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        private const string UpdateQuery = "Update utilisateur set nomUtilisateur=@nomUtilisateur, " +
            "prenomUtilisateur=@prenomUtilisateur, proprietaire=@proprietaire, idVille=@idVille, " +
            "telephone=@telephone, email=@email, mdp=@mdp where idUtilisateur=@idUtilisateur";
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
            this.villeTableAdapter.Fill(this.promenemonchienDataSet.ville);

        }

        private void validateButton_clicked(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                con.Open();
                using (MySqlCommand com = new MySqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@idUtilisateur", comboBoxUserName.SelectedValue);
                    com.Parameters.AddWithValue("@nomUtilisateur", comboBoxUserName.Text);
                    com.Parameters.AddWithValue("@prenomUtilisateur", firstNameBox.Text);
                    com.Parameters.AddWithValue("@proprietaire", checkBoxProprietaire.Checked);
                    com.Parameters.AddWithValue("@idVille", comboBoxCity.SelectedValue);
                    com.Parameters.AddWithValue("@telephone", phoneBox.Text);
                    com.Parameters.AddWithValue("@email", emailBox.Text);
                    com.Parameters.AddWithValue("@mdp", passwordBox.Text);
                    com.ExecuteNonQuery();
                }
            }
            this.Close();
        }
    }
}
