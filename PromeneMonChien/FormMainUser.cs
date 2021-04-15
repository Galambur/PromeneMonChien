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
    public partial class FormMainUser : Form
    {
        public FormMainUser()
        {
            InitializeComponent();
        }

        private void createUser_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserCreate f = new UserCreate();
            f.ShowDialog();
        }

        private void addDogs_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DogAdd f = new DogAdd();
            f.ShowDialog();
        }

        private void showUsers_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsersShow f = new UsersShow();
            f.ShowDialog();
        }

        private void modifyLink_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserModify f = new UserModify();
            f.ShowDialog();
        }

        private void connexion_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserDelete f = new UserDelete();
            f.ShowDialog();
        }
    }
}
