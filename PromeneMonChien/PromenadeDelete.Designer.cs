namespace PromeneMonChien
{
    partial class PromenadeDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromenadeDelete));
            this.validateButton = new System.Windows.Forms.Button();
            this.comboBoxDog = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDog = new System.Windows.Forms.Label();
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.idPromenadeLabel = new System.Windows.Forms.Label();
            this.deletePromenadeTitle = new System.Windows.Forms.Label();
            this.bindingSourcePromenade = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.promenadeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.promenadeTableAdapter();
            this.bindingSourceDog = new System.Windows.Forms.BindingSource(this.components);
            this.chienTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.chienTableAdapter();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromenade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            this.SuspendLayout();
            // 
            // validateButton
            // 
            this.validateButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(696, 411);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(92, 33);
            this.validateButton.TabIndex = 49;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // comboBoxDog
            // 
            this.comboBoxDog.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourcePromenade, "idChien", true));
            this.comboBoxDog.DataSource = this.bindingSourceDog;
            this.comboBoxDog.DisplayMember = "nomChien";
            this.comboBoxDog.Enabled = false;
            this.comboBoxDog.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDog.FormattingEnabled = true;
            this.comboBoxDog.Location = new System.Drawing.Point(377, 238);
            this.comboBoxDog.Name = "comboBoxDog";
            this.comboBoxDog.Size = new System.Drawing.Size(146, 31);
            this.comboBoxDog.TabIndex = 42;
            this.comboBoxDog.ValueMember = "idChien";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(254, 292);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(97, 23);
            this.labelUser.TabIndex = 48;
            this.labelUser.Text = "Promeneur";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourcePromenade, "idUtilisateur", true));
            this.comboBoxUser.DataSource = this.bindingSourceUser;
            this.comboBoxUser.DisplayMember = "nomUtilisateur";
            this.comboBoxUser.Enabled = false;
            this.comboBoxUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(377, 289);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(146, 31);
            this.comboBoxUser.TabIndex = 43;
            this.comboBoxUser.ValueMember = "idUtilisateur";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.CustomFormat = "yyyy-mm-dd hh:mm";
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourcePromenade, "datePromenade", true));
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(377, 188);
            this.dateTimePicker.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(180, 26);
            this.dateTimePicker.TabIndex = 41;
            // 
            // labelDog
            // 
            this.labelDog.AutoSize = true;
            this.labelDog.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDog.Location = new System.Drawing.Point(298, 241);
            this.labelDog.Name = "labelDog";
            this.labelDog.Size = new System.Drawing.Size(53, 23);
            this.labelDog.TabIndex = 47;
            this.labelDog.Text = "Chien";
            // 
            // comboBoxId
            // 
            this.comboBoxId.DataSource = this.bindingSourcePromenade;
            this.comboBoxId.DisplayMember = "idPromenade";
            this.comboBoxId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(377, 133);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(146, 31);
            this.comboBoxId.TabIndex = 40;
            this.comboBoxId.ValueMember = "idPromenade";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(305, 191);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(46, 23);
            this.dateLabel.TabIndex = 46;
            this.dateLabel.Text = "Date";
            // 
            // idPromenadeLabel
            // 
            this.idPromenadeLabel.AutoSize = true;
            this.idPromenadeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPromenadeLabel.Location = new System.Drawing.Point(260, 136);
            this.idPromenadeLabel.Name = "idPromenadeLabel";
            this.idPromenadeLabel.Size = new System.Drawing.Size(91, 23);
            this.idPromenadeLabel.TabIndex = 45;
            this.idPromenadeLabel.Text = "Identifiant";
            // 
            // deletePromenadeTitle
            // 
            this.deletePromenadeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.deletePromenadeTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePromenadeTitle.Location = new System.Drawing.Point(0, 0);
            this.deletePromenadeTitle.Name = "deletePromenadeTitle";
            this.deletePromenadeTitle.Size = new System.Drawing.Size(800, 100);
            this.deletePromenadeTitle.TabIndex = 44;
            this.deletePromenadeTitle.Text = "Supprimer une promenade";
            this.deletePromenadeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingSourcePromenade
            // 
            this.bindingSourcePromenade.DataMember = "promenade";
            this.bindingSourcePromenade.DataSource = this.promenemonchienDataSet;
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
            // bindingSourceDog
            // 
            this.bindingSourceDog.DataMember = "chien";
            this.bindingSourceDog.DataSource = this.promenemonchienDataSet;
            // 
            // chienTableAdapter
            // 
            this.chienTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataMember = "utilisateur";
            this.bindingSourceUser.DataSource = this.promenemonchienDataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // PromenadeDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.comboBoxDog);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDog);
            this.Controls.Add(this.comboBoxId);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.idPromenadeLabel);
            this.Controls.Add(this.deletePromenadeTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PromenadeDelete";
            this.Text = "Promène mon chien";
            this.Load += new System.EventHandler(this.PromenadeDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromenade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.ComboBox comboBoxDog;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDog;
        private System.Windows.Forms.ComboBox comboBoxId;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label idPromenadeLabel;
        private System.Windows.Forms.Label deletePromenadeTitle;
        private System.Windows.Forms.BindingSource bindingSourcePromenade;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.promenadeTableAdapter promenadeTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceDog;
        private promenemonchienDataSetTableAdapters.chienTableAdapter chienTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
    }
}