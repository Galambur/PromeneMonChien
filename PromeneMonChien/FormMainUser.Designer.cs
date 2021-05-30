namespace PromeneMonChien
{
    partial class FormMainUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainUser));
            this.mainTitle = new System.Windows.Forms.Label();
            this.buttonAddDog = new System.Windows.Forms.Button();
            this.dataGridViewDogs = new System.Windows.Forms.DataGridView();
            this.bindingSourceDog = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            this.chienTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.chienTableAdapter();
            this.buttonAddPromenade = new System.Windows.Forms.Button();
            this.dataGridViewPromenades = new System.Windows.Forms.DataGridView();
            this.bindingSourcePromenades = new System.Windows.Forms.BindingSource(this.components);
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.promenadeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.promenadeTableAdapter();
            this.promenemonchienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySqlDataAdapter2 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.clientLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDogPromenade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromenades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromenades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogPromenade)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(0, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(1630, 100);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Bienvenue sur Promène mon chien !";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddDog
            // 
            this.buttonAddDog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDog.Location = new System.Drawing.Point(193, 239);
            this.buttonAddDog.Name = "buttonAddDog";
            this.buttonAddDog.Size = new System.Drawing.Size(314, 46);
            this.buttonAddDog.TabIndex = 1;
            this.buttonAddDog.Text = "Ajouter mes chiens";
            this.buttonAddDog.UseVisualStyleBackColor = true;
            this.buttonAddDog.Click += new System.EventHandler(this.buttonAddDog_Click);
            // 
            // dataGridViewDogs
            // 
            this.dataGridViewDogs.AllowUserToAddRows = false;
            this.dataGridViewDogs.AllowUserToDeleteRows = false;
            this.dataGridViewDogs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogs.Location = new System.Drawing.Point(623, 180);
            this.dataGridViewDogs.Name = "dataGridViewDogs";
            this.dataGridViewDogs.Size = new System.Drawing.Size(395, 167);
            this.dataGridViewDogs.TabIndex = 2;
            // 
            // bindingSourceDog
            // 
            this.bindingSourceDog.AllowNew = false;
            this.bindingSourceDog.DataMember = "chien";
            this.bindingSourceDog.DataSource = this.promenemonchienDataSet;
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.AllowNew = false;
            this.bindingSourceUser.DataMember = "utilisateur";
            this.bindingSourceUser.DataSource = this.promenemonchienDataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // chienTableAdapter
            // 
            this.chienTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddPromenade
            // 
            this.buttonAddPromenade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddPromenade.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPromenade.Location = new System.Drawing.Point(193, 590);
            this.buttonAddPromenade.Name = "buttonAddPromenade";
            this.buttonAddPromenade.Size = new System.Drawing.Size(372, 46);
            this.buttonAddPromenade.TabIndex = 3;
            this.buttonAddPromenade.Text = "Réserver une promenade";
            this.buttonAddPromenade.UseVisualStyleBackColor = true;
            this.buttonAddPromenade.Click += new System.EventHandler(this.buttonAddPromenade_Click);
            // 
            // dataGridViewPromenades
            // 
            this.dataGridViewPromenades.AllowUserToAddRows = false;
            this.dataGridViewPromenades.AllowUserToDeleteRows = false;
            this.dataGridViewPromenades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPromenades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPromenades.Location = new System.Drawing.Point(623, 503);
            this.dataGridViewPromenades.Name = "dataGridViewPromenades";
            this.dataGridViewPromenades.ReadOnly = true;
            this.dataGridViewPromenades.Size = new System.Drawing.Size(550, 167);
            this.dataGridViewPromenades.TabIndex = 4;
            // 
            // bindingSourcePromenades
            // 
            this.bindingSourcePromenades.DataMember = "promenade";
            this.bindingSourcePromenades.DataSource = this.promenemonchienDataSet;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // promenadeTableAdapter
            // 
            this.promenadeTableAdapter.ClearBeforeFill = true;
            // 
            // promenemonchienDataSetBindingSource
            // 
            this.promenemonchienDataSetBindingSource.DataSource = this.promenemonchienDataSet;
            this.promenemonchienDataSetBindingSource.Position = 0;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // clientLabel
            // 
            this.clientLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.clientLabel.Location = new System.Drawing.Point(193, 173);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(178, 42);
            this.clientLabel.TabIndex = 5;
            this.clientLabel.Text = "Mes chiens";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(193, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mes promenades";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(193, 898);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Promenades de mes chiens";
            // 
            // dataGridViewDogPromenade
            // 
            this.dataGridViewDogPromenade.AllowUserToAddRows = false;
            this.dataGridViewDogPromenade.AllowUserToDeleteRows = false;
            this.dataGridViewDogPromenade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewDogPromenade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDogPromenade.Location = new System.Drawing.Point(623, 828);
            this.dataGridViewDogPromenade.Name = "dataGridViewDogPromenade";
            this.dataGridViewDogPromenade.ReadOnly = true;
            this.dataGridViewDogPromenade.Size = new System.Drawing.Size(550, 167);
            this.dataGridViewDogPromenade.TabIndex = 8;
            // 
            // FormMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1630, 1042);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDogPromenade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.dataGridViewPromenades);
            this.Controls.Add(this.buttonAddPromenade);
            this.Controls.Add(this.dataGridViewDogs);
            this.Controls.Add(this.buttonAddDog);
            this.Controls.Add(this.mainTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainUser";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMainUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromenades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromenades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDogPromenade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button buttonAddDog;
        private System.Windows.Forms.DataGridView dataGridViewDogs;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceDog;
        private promenemonchienDataSetTableAdapters.chienTableAdapter chienTableAdapter;
        private System.Windows.Forms.Button buttonAddPromenade;
        private System.Windows.Forms.DataGridView dataGridViewPromenades;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.BindingSource bindingSourcePromenades;
        private promenemonchienDataSetTableAdapters.promenadeTableAdapter promenadeTableAdapter;
        private System.Windows.Forms.BindingSource promenemonchienDataSetBindingSource;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter2;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDogPromenade;
    }
}