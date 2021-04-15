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
    public partial class UsersShow : Form
    {
        public UsersShow()
        {
            InitializeComponent();
        }

        private void ShowUsers_Load(object sender, EventArgs e)
        {
            this.utilisateurTableAdapter.Fill(this.promenemonchienDataSet.utilisateur);
        }

        private void openCreateUser(object sender, EventArgs e)
        {
            UserCreate f = new UserCreate();
            f.ShowDialog();
        }
    }
}
