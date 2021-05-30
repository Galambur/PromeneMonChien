namespace PromeneMonChien
{
    partial class PromenadeModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromenadeModify));
            this.modifyPromenadeTitle = new System.Windows.Forms.Label();
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            this.bindingSourcePromenade = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.dateLabel = new System.Windows.Forms.Label();
            this.idPromenadeLabel = new System.Windows.Forms.Label();
            this.promenadeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.promenadeTableAdapter();
            this.labelDog = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.labelUser = new System.Windows.Forms.Label();
            this.comboBoxDog = new System.Windows.Forms.ComboBox();
            this.bindingSourceDog = new System.Windows.Forms.BindingSource(this.components);
            this.chienTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.chienTableAdapter();
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            this.validateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromenade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyPromenadeTitle
            // 
            this.modifyPromenadeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.modifyPromenadeTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPromenadeTitle.Location = new System.Drawing.Point(0, 0);
            this.modifyPromenadeTitle.Name = "modifyPromenadeTitle";
            this.modifyPromenadeTitle.Size = new System.Drawing.Size(800, 100);
            this.modifyPromenadeTitle.TabIndex = 17;
            this.modifyPromenadeTitle.Text = "Modifier une promenade";
            this.modifyPromenadeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxId
            // 
            this.comboBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxId.DataSource = this.bindingSourcePromenade;
            this.comboBoxId.DisplayMember = "idPromenade";
            this.comboBoxId.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Location = new System.Drawing.Point(374, 120);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(249, 47);
            this.comboBoxId.TabIndex = 1;
            this.comboBoxId.ValueMember = "idPromenade";
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
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(276, 184);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(79, 39);
            this.dateLabel.TabIndex = 30;
            this.dateLabel.Text = "Date";
            // 
            // idPromenadeLabel
            // 
            this.idPromenadeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idPromenadeLabel.AutoSize = true;
            this.idPromenadeLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPromenadeLabel.Location = new System.Drawing.Point(202, 123);
            this.idPromenadeLabel.Name = "idPromenadeLabel";
            this.idPromenadeLabel.Size = new System.Drawing.Size(153, 39);
            this.idPromenadeLabel.TabIndex = 29;
            this.idPromenadeLabel.Text = "Identifiant";
            // 
            // promenadeTableAdapter
            // 
            this.promenadeTableAdapter.ClearBeforeFill = true;
            // 
            // labelDog
            // 
            this.labelDog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDog.AutoSize = true;
            this.labelDog.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDog.Location = new System.Drawing.Point(264, 248);
            this.labelDog.Name = "labelDog";
            this.labelDog.Size = new System.Drawing.Size(91, 39);
            this.labelDog.TabIndex = 32;
            this.labelDog.Text = "Chien";
            this.labelDog.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourcePromenade, "datePromenade", true));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(374, 188);
            this.dateTimePicker.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(249, 35);
            this.dateTimePicker.TabIndex = 2;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourcePromenade, "idUtilisateur", true));
            this.comboBoxUser.DataSource = this.bindingSourceUser;
            this.comboBoxUser.DisplayMember = "nomUtilisateur";
            this.comboBoxUser.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(374, 316);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(249, 47);
            this.comboBoxUser.TabIndex = 4;
            this.comboBoxUser.ValueMember = "idUtilisateur";
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataMember = "utilisateur";
            this.bindingSourceUser.DataSource = this.promenemonchienDataSet;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(191, 319);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(164, 39);
            this.labelUser.TabIndex = 37;
            this.labelUser.Text = "Promeneur";
            // 
            // comboBoxDog
            // 
            this.comboBoxDog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDog.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourcePromenade, "idChien", true));
            this.comboBoxDog.DataSource = this.bindingSourceDog;
            this.comboBoxDog.DisplayMember = "nomChien";
            this.comboBoxDog.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDog.FormattingEnabled = true;
            this.comboBoxDog.Location = new System.Drawing.Point(374, 245);
            this.comboBoxDog.Name = "comboBoxDog";
            this.comboBoxDog.Size = new System.Drawing.Size(249, 47);
            this.comboBoxDog.TabIndex = 3;
            this.comboBoxDog.ValueMember = "idChien";
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
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validateButton.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(677, 397);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(111, 41);
            this.validateButton.TabIndex = 39;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // PromenadeModify
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
            this.Controls.Add(this.modifyPromenadeTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PromenadeModify";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PromenadeModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePromenade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyPromenadeTitle;
        private System.Windows.Forms.ComboBox comboBoxId;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label idPromenadeLabel;
        private System.Windows.Forms.BindingSource bindingSourcePromenade;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.promenadeTableAdapter promenadeTableAdapter;
        private System.Windows.Forms.Label labelDog;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboBoxDog;
        private System.Windows.Forms.BindingSource bindingSourceDog;
        private promenemonchienDataSetTableAdapters.chienTableAdapter chienTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.Button validateButton;
    }
}