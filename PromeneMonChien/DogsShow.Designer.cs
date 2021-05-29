namespace PromeneMonChien
{
    partial class DogsShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogsShow));
            this.showDogsTitle = new System.Windows.Forms.Label();
            this.bindingSourceDogs = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idChienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomChienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUtilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chienTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.chienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showDogsTitle
            // 
            this.showDogsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showDogsTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDogsTitle.Location = new System.Drawing.Point(0, 0);
            this.showDogsTitle.Name = "showDogsTitle";
            this.showDogsTitle.Size = new System.Drawing.Size(800, 100);
            this.showDogsTitle.TabIndex = 2;
            this.showDogsTitle.Text = "Liste des chiens";
            this.showDogsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingSourceDogs
            // 
            this.bindingSourceDogs.DataMember = "chien";
            this.bindingSourceDogs.DataSource = this.promenemonchienDataSet;
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChienDataGridViewTextBoxColumn,
            this.nomChienDataGridViewTextBoxColumn,
            this.idTypeDataGridViewTextBoxColumn,
            this.idUtilisateurDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceDogs;
            this.dataGridView1.Location = new System.Drawing.Point(120, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(538, 268);
            this.dataGridView1.TabIndex = 3;
            // 
            // idChienDataGridViewTextBoxColumn
            // 
            this.idChienDataGridViewTextBoxColumn.DataPropertyName = "idChien";
            this.idChienDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.idChienDataGridViewTextBoxColumn.Name = "idChienDataGridViewTextBoxColumn";
            this.idChienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomChienDataGridViewTextBoxColumn
            // 
            this.nomChienDataGridViewTextBoxColumn.DataPropertyName = "nomChien";
            this.nomChienDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomChienDataGridViewTextBoxColumn.Name = "nomChienDataGridViewTextBoxColumn";
            this.nomChienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTypeDataGridViewTextBoxColumn
            // 
            this.idTypeDataGridViewTextBoxColumn.DataPropertyName = "idType";
            this.idTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.idTypeDataGridViewTextBoxColumn.Name = "idTypeDataGridViewTextBoxColumn";
            this.idTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUtilisateurDataGridViewTextBoxColumn
            // 
            this.idUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "idUtilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.HeaderText = "Utilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.Name = "idUtilisateurDataGridViewTextBoxColumn";
            this.idUtilisateurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chienTableAdapter
            // 
            this.chienTableAdapter.ClearBeforeFill = true;
            // 
            // DogsShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showDogsTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DogsShow";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowDogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label showDogsTitle;
        private System.Windows.Forms.BindingSource bindingSourceDogs;
        private promenemonchienDataSet promenemonchienDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private promenemonchienDataSetTableAdapters.chienTableAdapter chienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomChienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}