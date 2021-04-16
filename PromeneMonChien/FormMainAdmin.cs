﻿using System;
using System.Windows.Forms;

namespace PromeneMonChien
{
    public partial class FormMainAdmin : Form
    {
        public FormMainAdmin()
        {
            InitializeComponent();
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
        private void addDogButton_Click(object sender, EventArgs e)
        {
            DogAdd f = new DogAdd();
            f.ShowDialog();
        }
        #endregion
    }
}
