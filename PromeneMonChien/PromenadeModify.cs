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
    public partial class PromenadeModify : Form
    {
        // chaine de connexion
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties." +
            "Settings.promenemonchienConnectionString"].ConnectionString;
        // requête SQL pour modifier la ligne désirée
        private const string UpdateQuery = "Update promenade set datePromenade=@datePromenade, " +
            "idUtilisateur=@idUtilisateur, idChien=@idChien where idPromenade=@idPromenade";

        public PromenadeModify()
        {
            InitializeComponent();
        }

        private void PromenadeModify_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.chien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.promenade'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.promenadeTableAdapter.Fill(this.promenemonchienDataSet.promenade);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                using (MySqlCommand com = new MySqlCommand(UpdateQuery, con))
                {
                    // récupération des données du formulaire, on les relie aux paramètre de
                    // notre requête SQL
                    com.Parameters.AddWithValue("@idPromenade", comboBoxId.SelectedValue);
                    com.Parameters.AddWithValue("@datePromenade", dateTimePicker.Value);
                    com.Parameters.AddWithValue("@idUtilisateur", comboBoxUser.SelectedValue);
                    com.Parameters.AddWithValue("@idChien", comboBoxDog.SelectedValue);
                    // execution de la requête
                    com.ExecuteNonQuery();
                }
            }
            //fermeture de la fenêtre de modification
            this.Close();

        }
    }
}
