namespace PromeneMonChien
{
    partial class PromenadeShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromenadeShow));
            this.showUsersTitle = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.bindingSourcePromenades = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.promenadeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.promenadeTableAdapter();
            this.idPromenadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePromenadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUtilisateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idChienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromenades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // showUsersTitle
            // 
            this.showUsersTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUsersTitle.Location = new System.Drawing.Point(-2, -1);
            this.showUsersTitle.Name = "showUsersTitle";
            this.showUsersTitle.Size = new System.Drawing.Size(800, 100);
            this.showUsersTitle.TabIndex = 3;
            this.showUsersTitle.Text = "Liste des promenades";
            this.showUsersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPromenadeDataGridViewTextBoxColumn,
            this.datePromenadeDataGridViewTextBoxColumn,
            this.idUtilisateurDataGridViewTextBoxColumn,
            this.idChienDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.bindingSourcePromenades;
            this.dataGridViewUsers.Location = new System.Drawing.Point(181, 102);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(444, 283);
            this.dataGridViewUsers.TabIndex = 4;
            // 
            // bindingSourcePromenades
            // 
            this.bindingSourcePromenades.DataMember = "promenade";
            this.bindingSourcePromenades.DataSource = this.promenemonchienDataSet;
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // promenadeTableAdapter
            // 
            this.promenadeTableAdapter.ClearBeforeFill = true;
            // 
            // idPromenadeDataGridViewTextBoxColumn
            // 
            this.idPromenadeDataGridViewTextBoxColumn.DataPropertyName = "idPromenade";
            this.idPromenadeDataGridViewTextBoxColumn.HeaderText = "idPromenade";
            this.idPromenadeDataGridViewTextBoxColumn.Name = "idPromenadeDataGridViewTextBoxColumn";
            this.idPromenadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datePromenadeDataGridViewTextBoxColumn
            // 
            this.datePromenadeDataGridViewTextBoxColumn.DataPropertyName = "datePromenade";
            this.datePromenadeDataGridViewTextBoxColumn.HeaderText = "datePromenade";
            this.datePromenadeDataGridViewTextBoxColumn.Name = "datePromenadeDataGridViewTextBoxColumn";
            this.datePromenadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUtilisateurDataGridViewTextBoxColumn
            // 
            this.idUtilisateurDataGridViewTextBoxColumn.DataPropertyName = "idUtilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.HeaderText = "idUtilisateur";
            this.idUtilisateurDataGridViewTextBoxColumn.Name = "idUtilisateurDataGridViewTextBoxColumn";
            this.idUtilisateurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idChienDataGridViewTextBoxColumn
            // 
            this.idChienDataGridViewTextBoxColumn.DataPropertyName = "idChien";
            this.idChienDataGridViewTextBoxColumn.HeaderText = "idChien";
            this.idChienDataGridViewTextBoxColumn.Name = "idChienDataGridViewTextBoxColumn";
            this.idChienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PromenadeShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.showUsersTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PromenadeShow";
            this.Text = "Promène mon chien";
            this.Load += new System.EventHandler(this.PromenadeShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromenades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label showUsersTitle;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.BindingSource bindingSourcePromenades;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.promenadeTableAdapter promenadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPromenadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePromenadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChienDataGridViewTextBoxColumn;
    }
}