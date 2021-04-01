using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class ShowUsers : Form
    {
        public ShowUsers()
        {
            InitializeComponent();
        }

        private void ShowUsers_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'promenemonchienDataSet.utilisateur'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
        }

        private void openCreateUser(object sender, EventArgs e)
        {
            CreateUser f = new CreateUser();
            f.ShowDialog();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            this.promenemonchienDataSet.AcceptChanges();
            this.bindingSourceUsers.EndEdit(); 
        }
    }
}
