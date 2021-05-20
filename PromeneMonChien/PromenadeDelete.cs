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
    public partial class PromenadeDelete : Form
    {
        // chaine de connexion
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        // requête SQL pour supprimer l'utilisateur sélectionné, avec ses chiens et toutes ses promenades
        private const string DeleteQuery = "DELETE FROM promenade WHERE idPromenade=@idPromenade; ";

        public PromenadeDelete()
        {
            InitializeComponent();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(myConn))
            {
                // ouverture de la connexion à notre base de données
                con.Open();
                using (MySqlCommand com = new MySqlCommand(DeleteQuery, con))
                {
                    // on récupère les données du formulaire en les liant aux paramètre de notre 
                    // requête
                    com.Parameters.AddWithValue("@idPromenade", comboBoxId.SelectedValue);
                    // on exécute la requête
                    com.ExecuteNonQuery();
                }
            }
            // fermeture de la fenêtre
            this.Close();
        }

        private void PromenadeDelete_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.chien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.promenade'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.promenadeTableAdapter.Fill(this.promenemonchienDataSet.promenade);

        }
    }
}
