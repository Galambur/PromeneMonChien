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
            // les promenades où je suis inscrit de la plus recente à la plus ancienne
            string SelectPromenadesQuery = "SELECT datePromenade as Date, nomChien as Chien, CONCAT(u.nomUtilisateur, \" \", u.prenomUtilisateur) as Proprietaire, telephone as Numero, email as Email  " +
                "FROM promenade, chien, utilisateur u " +
                "WHERE promenade.idChien = chien.idChien " +
                "AND u.idUtilisateur = chien.idUtilisateur " +
                "AND promenade.idUtilisateur=" + this.userId.ToString() +
                " ORDER BY Date DESC";
            // les promenades où mes chiens sont inscrit, de la plus recente à la plus ancienne
            string SelectDogPromenadesQuery = "SELECT c.nomChien as Chien, CONCAT(promeneur.nomUtilisateur, \" \", promeneur.prenomUtilisateur) as Promeneur, " +
                "p.datePromenade as Date, promeneur.telephone as Numero, promeneur.email as Email " +
                "FROM promenade p, chien c, utilisateur as promeneur " +
                "WHERE p.idChien = c.idChien " +
                "AND p.idUtilisateur = promeneur.idUtilisateur " +
                "AND c.idUtilisateur = " + this.userId.ToString() +
                " ORDER BY Date DESC";


            // jointure des tables cherchees
            // ouverture de la connexion
            var con = new MySqlConnection(myConn);
            con.Open();

            // chiens
            var comDog = new MySqlCommand(SelectDogsQuery, con);
            var sdrDog = new MySqlDataAdapter(comDog);
            var dtDog = new DataTable();
            sdrDog.Fill(dtDog);
            dataGridViewDogs.DataSource = dtDog;

            // les promenades où je suis inscrit
            var comProm = new MySqlCommand(SelectPromenadesQuery, con);
            var sdrProm = new MySqlDataAdapter(comProm);
            var dtProm = new DataTable();
            sdrProm.Fill(dtProm);
            dataGridViewPromenades.DataSource = dtProm;

            // les promenades où mes chiens sont inscrit
            var comDogProm = new MySqlCommand(SelectDogPromenadesQuery, con);
            var sdrDogProm = new MySqlDataAdapter(comDogProm);
            var dtDogProm = new DataTable();
            sdrDogProm.Fill(dtDogProm);
            dataGridViewDogPromenade.DataSource = dtDogProm;

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
