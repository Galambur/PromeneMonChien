using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class FormMainUser : Form
    {
        int userId;
        private static string myConn = ConfigurationManager.ConnectionStrings["PromeneMonChien.Properties.Settings.promenemonchienConnectionString"].ConnectionString;
        

        public FormMainUser()
        {
            InitializeComponent();
        }

        public FormMainUser(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void FormMainUser_Load(object sender, System.EventArgs e)
        {
            this.promenadeTableAdapter.Fill(this.promenemonchienDataSet.promenade);
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);

            string SelectDogsQuery = "SELECT nomChien as Nom, nomType as Type, description as Description " +
                "FROM chien, type " +
                "WHERE chien.idType = type.idType " +
                "AND chien.idUtilisateur=" + this.userId.ToString();
            string SelectPromenadesQuery = "SELECT datePromenade as Date, nomChien as Chien " +
                "FROM promenade, chien " +
                "WHERE promenade.idChien = chien.idChien " +
                "AND promenade.idUtilisateur=" + this.userId.ToString();


                // jointure des tables cherchées
            // ouverture de la connexion
            var con = new MySqlConnection(myConn);
            con.Open();

            // chiens
            var comDog = new MySqlCommand(SelectDogsQuery, con);
            var sdrDog = new MySqlDataAdapter(comDog);
            var dtDog = new DataTable();
            sdrDog.Fill(dtDog);
            dataGridViewDogs.DataSource = dtDog;

            // promenades
            var comProm = new MySqlCommand(SelectPromenadesQuery, con);
            var sdrProm = new MySqlDataAdapter(comProm);
            var dtProm = new DataTable();
            sdrProm.Fill(dtProm);
            dataGridViewPromenades.DataSource = dtProm;

            // fermeture de la connexion
            con.Close();
        }

        private void buttonAddPromenade_Click(object sender, System.EventArgs e)
        {
            UserActionPromenadeAdd f = new UserActionPromenadeAdd(this.userId);
            this.Hide();
            f.ShowDialog();
        }

        private void buttonAddDog_Click(object sender, System.EventArgs e)
        {
            UserActionDogAdd f = new UserActionDogAdd(this.userId);
            this.Hide();
            f.ShowDialog();
        }
    }
}
