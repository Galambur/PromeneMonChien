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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void createUser_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUser f = new CreateUser();
            f.ShowDialog();
        }

        private void addDogs_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddDog f = new AddDog();
            f.ShowDialog();
        }

        private void showUsers_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowUsers f = new ShowUsers();
            f.ShowDialog();
        }

        private void modifyLink_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ModifyUser f = new ModifyUser();
            f.ShowDialog();
        }
    }
}
