namespace PromeneMonChien
{
    partial class UsersShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersShow));
            this.showUsersTitle = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.idUtilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUtilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomUtilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietaireDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idVilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // showUsersTitle
            // 
            this.showUsersTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUsersTitle.Location = new System.Drawing.Point(0, 0);
            this.showUsersTitle.Name = "showUsersTitle";
            this.showUsersTitle.Size = new System.Drawing.Size(800, 100);
            this.showUsersTitle.TabIndex = 2;
            this.showUsersTitle.Text = "Liste des utilisateurs";
            this.showUsersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUtilisateurDataGridViewTextBoxColumn,
            this.nomUtilisateurDataGridViewTextBoxColumn,
            this.prenomUtilisateurDataGridViewTextBoxColumn,
            this.proprietaireDataGridViewCheckBoxColumn,
            this.idVilleDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mdpDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.utilisateurBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(25, 103);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(739, 283);
            this.dataGridViewUsers.TabIndex = 3;
            // 
            // idUtilisateurDataGridViewTextBoxColumn
            // 
            this.idUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "idUtilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.HeaderText = "idUtilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.Name = "idUtilisateurDataGridViewTextBoxColumn";
            this.idUtilisateurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomUtilisateurDataGridViewTextBoxColumn
            // 
            this.nomUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "nomUtilisateur";
            this.nomUtilisateurDataGridViewTextBoxColumn.HeaderText = "nomUtilisateur";
            this.nomUtilisateurDataGridViewTextBoxColumn.Name = "nomUtilisateurDataGridViewTextBoxColumn";
            this.nomUtilisateurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomUtilisateurDataGridViewTextBoxColumn
            // 
            this.prenomUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "prenomUtilisateur";
            this.prenomUtilisateurDataGridViewTextBoxColumn.HeaderText = "prenomUtilisateur";
            this.prenomUtilisateurDataGridViewTextBoxColumn.Name = "prenomUtilisateurDataGridViewTextBoxColumn";
            this.prenomUtilisateurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proprietaireDataGridViewCheckBoxColumn
            // 
            this.proprietaireDataGridViewCheckBoxColumn.DataPropertyName = "proprietaire";
            this.proprietaireDataGridViewCheckBoxColumn.HeaderText = "proprietaire";
            this.proprietaireDataGridViewCheckBoxColumn.Name = "proprietaireDataGridViewCheckBoxColumn";
            this.proprietaireDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idVilleDataGridViewTextBoxColumn
            // 
            this.idVilleDataGridViewTextBoxColumn.DataPropertyName = "idVille";
            this.idVilleDataGridViewTextBoxColumn.HeaderText = "idVille";
            this.idVilleDataGridViewTextBoxColumn.Name = "idVilleDataGridViewTextBoxColumn";
            this.idVilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mdpDataGridViewTextBoxColumn
            // 
            this.mdpDataGridViewTextBoxColumn.DataPropertyName = "mdp";
            this.mdpDataGridViewTextBoxColumn.HeaderText = "mdp";
            this.mdpDataGridViewTextBoxColumn.Name = "mdpDataGridViewTextBoxColumn";
            this.mdpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.bindingSourceUsers;
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.DataSource = this.promenemonchienDataSet;
            this.bindingSourceUsers.Position = 0;
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // UsersShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.showUsersTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersShow";
            this.Text = "Promène mon chien";
            this.Load += new System.EventHandler(this.ShowUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label showUsersTitle;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private promenemonchienDataSet promenemonchienDataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUtilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomUtilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn proprietaireDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdpDataGridViewTextBoxColumn;
    }
}