using System;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class DogsShow : Form
    {
        public DogsShow()
        {
            InitializeComponent();
        }

        private void ShowDogs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.chien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.chien'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chienTableAdapter.Fill(this.promenemonchienDataSet.chien);
            //this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
        }
    }
}
