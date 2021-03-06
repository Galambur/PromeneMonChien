namespace PromeneMonChien
{
    partial class UserCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCreate));
            this.createUserTitle = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceVille = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.checkBoxProprietaire = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.villeTableAdapter();
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            this.validateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createUserTitle
            // 
            this.createUserTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.createUserTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserTitle.Location = new System.Drawing.Point(0, 0);
            this.createUserTitle.Name = "createUserTitle";
            this.createUserTitle.Size = new System.Drawing.Size(1120, 111);
            this.createUserTitle.TabIndex = 1;
            this.createUserTitle.Text = "Créer un compte utilisateur";
            this.createUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(411, 142);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 39);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nom";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(519, 139);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(249, 47);
            this.nameBox.TabIndex = 1;
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataSource = this.utilisateurBindingSource;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.bindingSourceVille;
            // 
            // bindingSourceVille
            // 
            this.bindingSourceVille.DataSource = this.promenemonchienDataSet;
            this.bindingSourceVille.Position = 0;
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(519, 396);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(249, 47);
            this.phoneBox.TabIndex = 5;
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneLabel.Location = new System.Drawing.Point(339, 399);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(153, 39);
            this.telephoneLabel.TabIndex = 4;
            this.telephoneLabel.Text = "Telephone";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ville";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(519, 206);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(249, 47);
            this.firstNameBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(371, 209);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(121, 39);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "Prenom";
            // 
            // emailBox
            // 
            this.emailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(519, 470);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(249, 47);
            this.emailBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(404, 473);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(88, 39);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(519, 541);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(249, 47);
            this.passwordBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(299, 544);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(193, 39);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Mot de passe";
            // 
            // checkBoxProprietaire
            // 
            this.checkBoxProprietaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxProprietaire.AutoSize = true;
            this.checkBoxProprietaire.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxProprietaire.Location = new System.Drawing.Point(547, 281);
            this.checkBoxProprietaire.Name = "checkBoxProprietaire";
            this.checkBoxProprietaire.Size = new System.Drawing.Size(191, 43);
            this.checkBoxProprietaire.TabIndex = 3;
            this.checkBoxProprietaire.Text = "Propriétaire";
            this.checkBoxProprietaire.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceUser, "idVille", true));
            this.comboBox1.DataSource = this.villeBindingSource;
            this.comboBox1.DisplayMember = "nomVille";
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(519, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 47);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "idVille";
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataMember = "ville";
            this.villeBindingSource.DataSource = this.bindingSourceVille;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validateButton.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(998, 547);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(110, 41);
            this.validateButton.TabIndex = 17;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_clicked);
            // 
            // UserCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1120, 600);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.validateButton);
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
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createUserTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserCreate";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.Click += new System.EventHandler(this.validateButton_clicked);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createUserTitle;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.CheckBox checkBoxProprietaire;
        private System.Windows.Forms.BindingSource bindingSourceVille;
        private System.Windows.Forms.ComboBox comboBox1;
        private promenemonchienDataSet promenemonchienDataSet;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private promenemonchienDataSetTableAdapters.villeTableAdapter villeTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.Button validateButton;
    }
}