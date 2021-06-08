using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class DogsShow : Form
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        private static string SelectQuery = "SELECT idChien as Identifiant, nomChien as Nom, nomType as Type, " +
            "CONCAT(prenomUtilisateur, ' ', nomUtilisateur) as Utilisateur, description as Description, " +
            "nbPromenades as 'Nombre promenades' " +
            "FROM chien, utilisateur, type " +
            "WHERE chien.idUtilisateur = utilisateur.idUtilisateur " +
            "AND chien.idType = type.idType " +
            "ORDER BY Identifiant ASC";

        public DogsShow()
        {
            InitializeComponent();
        }

        private void ShowDogs_Load(object sender, EventArgs e)
        {
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);

            // création et ouverture de la connexion
            MySqlConnection con = new MySqlConnection(myConn);
            con.Open();

            using (MySqlCommand com = new MySqlCommand(SelectQuery, con))
            {
                // execution de la requête
                com.ExecuteNonQuery();

                // remplissage de notre datagridview avec les données reccueillies
                var sdr = new MySqlDataAdapter(com);
                var dt = new DataTable();
                sdr.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            // fermeture de la connexion
            con.Close();
        }
    }
}
