using System;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class FormMainAdmin : Form
    {
        int adminId;

        public FormMainAdmin()
        {
            InitializeComponent();
        }

        public FormMainAdmin(int id)
        {
            InitializeComponent();
            this.adminId = id;
        }


        #region user CRUD
        private void showUserButton_Click(object sender, EventArgs e)
        {
            UsersShow f = new UsersShow();
            f.ShowDialog();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserCreate f = new UserCreate();
            f.ShowDialog();
        }

        private void modifyUserButton_Click(object sender, EventArgs e)
        {
            UserModify f = new UserModify();
            f.ShowDialog();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            UserDelete f = new UserDelete();
            f.ShowDialog();
        }
        #endregion

        #region dog CRUD
        private void showDogsButton_Click(object sender, EventArgs e)
        {
            DogsShow f = new DogsShow();
            f.ShowDialog();
        }

        private void addDogButton_Click(object sender, EventArgs e)
        {
            DogAdd f = new DogAdd();
            f.ShowDialog();
        }

        private void modifyDogButton_Click(object sender, EventArgs e)
        {
            DogModify f = new DogModify();
            f.ShowDialog();
        }

        private void deleteDogButton_Click(object sender, EventArgs e)
        {
            DogDelete f = new DogDelete();
            f.ShowDialog();
        }
        #endregion

        private void addPromenadeButton_Click(object sender, EventArgs e)
        {
            PromenadeCreate f = new PromenadeCreate();
            f.ShowDialog();
        }
    }
}
