namespace PromeneMonChien
{
    partial class UserDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDelete));
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.checkBoxProprietaire = new System.Windows.Forms.CheckBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteUserTitle = new System.Windows.Forms.Label();
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            this.bindingSourceCity = new System.Windows.Forms.BindingSource(this.components);
            this.villeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.villeTableAdapter();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.validateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCity)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUserName.DataSource = this.bindingSourceUsers;
            this.comboBoxUserName.DisplayMember = "nomUtilisateur";
            this.comboBoxUserName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(528, 130);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(249, 47);
            this.comboBoxUserName.TabIndex = 29;
            this.comboBoxUserName.ValueMember = "idUtilisateur";
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.DataMember = "utilisateur";
            this.bindingSourceUsers.DataSource = this.promenemonchienDataSet;
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxProprietaire
            // 
            this.checkBoxProprietaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxProprietaire.AutoSize = true;
            this.checkBoxProprietaire.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceUsers, "proprietaire", true));
            this.checkBoxProprietaire.Enabled = false;
            this.checkBoxProprietaire.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProprietaire.Location = new System.Drawing.Point(556, 263);
            this.checkBoxProprietaire.Name = "checkBoxProprietaire";
            this.checkBoxProprietaire.Size = new System.Drawing.Size(191, 43);
            this.checkBoxProprietaire.TabIndex = 31;
            this.checkBoxProprietaire.Text = "Propriétaire";
            this.checkBoxProprietaire.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUsers, "mdp", true));
            this.passwordBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(528, 526);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(249, 47);
            this.passwordBox.TabIndex = 35;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(316, 529);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(193, 39);
            this.passwordLabel.TabIndex = 41;
            this.passwordLabel.Text = "Mot de passe";
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUsers, "email", true));
            this.emailBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(528, 457);
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(249, 47);
            this.emailBox.TabIndex = 34;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(421, 460);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(88, 39);
            this.emailLabel.TabIndex = 40;
            this.emailLabel.Text = "Email";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUsers, "prenomUtilisateur", true));
            this.firstNameBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(528, 201);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.ReadOnly = true;
            this.firstNameBox.Size = new System.Drawing.Size(249, 47);
            this.firstNameBox.TabIndex = 30;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(388, 204);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(121, 39);
            this.firstNameLabel.TabIndex = 39;
            this.firstNameLabel.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 39);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ville";
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUsers, "telephone", true));
            this.phoneBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(528, 386);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.ReadOnly = true;
            this.phoneBox.Size = new System.Drawing.Size(249, 47);
            this.phoneBox.TabIndex = 33;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneLabel.Location = new System.Drawing.Point(356, 389);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(153, 39);
            this.telephoneLabel.TabIndex = 37;
            this.telephoneLabel.Text = "Telephone";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(428, 133);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 39);
            this.nameLabel.TabIndex = 36;
            this.nameLabel.Text = "Nom";
            // 
            // deleteUserTitle
            // 
            this.deleteUserTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteUserTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserTitle.Location = new System.Drawing.Point(0, 0);
            this.deleteUserTitle.Name = "deleteUserTitle";
            this.deleteUserTitle.Size = new System.Drawing.Size(1120, 118);
            this.deleteUserTitle.TabIndex = 42;
            this.deleteUserTitle.Text = "Supprimer un compte utilisateur";
            this.deleteUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceCity
            // 
            this.bindingSourceCity.DataMember = "ville";
            this.bindingSourceCity.DataSource = this.promenemonchienDataSet;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCity, "nomVille", true));
            this.textBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSourceUsers, "idVille", true));
            this.textBoxCity.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(528, 312);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.Size = new System.Drawing.Size(249, 47);
            this.textBoxCity.TabIndex = 43;
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validateButton.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(972, 526);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(136, 50);
            this.validateButton.TabIndex = 44;
            this.validateButton.Text = "Supprimer";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_clicked);
            // 
            // UserDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1120, 588);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.deleteUserTitle);
            this.Controls.Add(this.comboBoxUserName);
            this.Controls.Add(this.checkBoxProprietaire);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.telephoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDelete";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUserName;
        private System.Windows.Forms.CheckBox checkBoxProprietaire;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label deleteUserTitle;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceCity;
        private promenemonchienDataSetTableAdapters.villeTableAdapter villeTableAdapter;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button validateButton;
    }
}