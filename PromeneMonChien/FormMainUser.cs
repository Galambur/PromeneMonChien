using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class FormMainUser : Form
    {
        int userId;

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
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.chien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
        }
    }
}
