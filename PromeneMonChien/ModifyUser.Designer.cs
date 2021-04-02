namespace PromeneMonChien
{
    partial class ModifyUser
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
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.bindingSourceVille = new System.Windows.Forms.BindingSource(this.components);
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
            this.modifyUserTitle = new System.Windows.Forms.Label();
            this.villeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.villeTableAdapter();
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.validateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVille)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceUser, "idVille", true));
            this.comboBoxCity.DataSource = this.bindingSourceVille;
            this.comboBoxCity.DisplayMember = "nomVille";
            this.comboBoxCity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(389, 231);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(146, 31);
            this.comboBoxCity.TabIndex = 4;
            this.comboBoxCity.ValueMember = "idVille";
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataMember = "utilisateur";
            this.bindingSourceUser.DataSource = this.promenemonchienDataSet;
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceVille
            // 
            this.bindingSourceVille.DataMember = "ville";
            this.bindingSourceVille.DataSource = this.promenemonchienDataSet;
            // 
            // checkBoxProprietaire
            // 
            this.checkBoxProprietaire.AutoSize = true;
            this.checkBoxProprietaire.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceUser, "proprietaire", true));
            this.checkBoxProprietaire.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProprietaire.Location = new System.Drawing.Point(402, 192);
            this.checkBoxProprietaire.Name = "checkBoxProprietaire";
            this.checkBoxProprietaire.Size = new System.Drawing.Size(121, 27);
            this.checkBoxProprietaire.TabIndex = 3;
            this.checkBoxProprietaire.Text = "Propriétaire";
            this.checkBoxProprietaire.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "mdp", true));
            this.passwordBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(389, 379);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(146, 31);
            this.passwordBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(250, 382);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(113, 23);
            this.passwordLabel.TabIndex = 28;
            this.passwordLabel.Text = "Mot de passe";
            // 
            // emailBox
            // 
            this.emailBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "email", true));
            this.emailBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(389, 331);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(146, 31);
            this.emailBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(312, 334);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 23);
            this.emailLabel.TabIndex = 27;
            this.emailLabel.Text = "Email";
            // 
            // firstNameBox
            // 
            this.firstNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "prenomUtilisateur", true));
            this.firstNameBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(389, 144);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(146, 31);
            this.firstNameBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(292, 147);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(71, 23);
            this.firstNameLabel.TabIndex = 26;
            this.firstNameLabel.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ville";
            // 
            // phoneBox
            // 
            this.phoneBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceUser, "telephone", true));
            this.phoneBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(389, 283);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(146, 31);
            this.phoneBox.TabIndex = 5;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneLabel.Location = new System.Drawing.Point(275, 286);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(88, 23);
            this.telephoneLabel.TabIndex = 21;
            this.telephoneLabel.Text = "Telephone";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(316, 104);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(47, 23);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "Nom";
            // 
            // modifyUserTitle
            // 
            this.modifyUserTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.modifyUserTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyUserTitle.Location = new System.Drawing.Point(0, 0);
            this.modifyUserTitle.Name = "modifyUserTitle";
            this.modifyUserTitle.Size = new System.Drawing.Size(800, 100);
            this.modifyUserTitle.TabIndex = 16;
            this.modifyUserTitle.Text = "Modifier un compte utilisateur";
            this.modifyUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.DataSource = this.bindingSourceUser;
            this.comboBoxUserName.DisplayMember = "nomUtilisateur";
            this.comboBoxUserName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(389, 101);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(146, 31);
            this.comboBoxUserName.TabIndex = 1;
            this.comboBoxUserName.ValueMember = "idUtilisateur";
            // 
            // validateButton
            // 
            this.validateButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(696, 405);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(92, 33);
            this.validateButton.TabIndex = 8;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_clicked);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.comboBoxUserName);
            this.Controls.Add(this.comboBoxCity);
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
            this.Controls.Add(this.modifyUserTitle);
            this.Name = "ModifyUser";
            this.Text = "Promène mon chien";
            this.Load += new System.EventHandler(this.ModifyUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCity;
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
        private System.Windows.Forms.Label modifyUserTitle;
        private System.Windows.Forms.BindingSource bindingSourceVille;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.villeTableAdapter villeTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxUserName;
        private System.Windows.Forms.Button validateButton;
    }
}