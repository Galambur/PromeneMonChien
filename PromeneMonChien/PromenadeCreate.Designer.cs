namespace PromeneMonChien
{
    partial class PromenadeCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromenadeCreate));
            this.createPromenadeTitle = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.comboBoxDog = new System.Windows.Forms.ComboBox();
            this.bindingSourceDog = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.labelDog = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.labelUser = new System.Windows.Forms.Label();
            this.chienTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.chienTableAdapter();
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            this.SuspendLayout();
            // 
            // createPromenadeTitle
            // 
            this.createPromenadeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.createPromenadeTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPromenadeTitle.Location = new System.Drawing.Point(0, 0);
            this.createPromenadeTitle.Name = "createPromenadeTitle";
            this.createPromenadeTitle.Size = new System.Drawing.Size(800, 100);
            this.createPromenadeTitle.TabIndex = 43;
            this.createPromenadeTitle.Text = "Prévoir une promenade";
            this.createPromenadeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validateButton.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(682, 395);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(106, 43);
            this.validateButton.TabIndex = 44;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // comboBoxDog
            // 
            this.comboBoxDog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDog.DataSource = this.bindingSourceDog;
            this.comboBoxDog.DisplayMember = "nomChien";
            this.comboBoxDog.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDog.FormattingEnabled = true;
            this.comboBoxDog.Location = new System.Drawing.Point(353, 207);
            this.comboBoxDog.Name = "comboBoxDog";
            this.comboBoxDog.Size = new System.Drawing.Size(249, 47);
            this.comboBoxDog.TabIndex = 45;
            this.comboBoxDog.ValueMember = "idChien";
            // 
            // bindingSourceDog
            // 
            this.bindingSourceDog.DataMember = "chien";
            this.bindingSourceDog.DataSource = this.promenemonchienDataSet;
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelDog
            // 
            this.labelDog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDog.AutoSize = true;
            this.labelDog.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDog.Location = new System.Drawing.Point(232, 210);
            this.labelDog.Name = "labelDog";
            this.labelDog.Size = new System.Drawing.Size(91, 39);
            this.labelDog.TabIndex = 46;
            this.labelDog.Text = "Chien";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUser.DataSource = this.bindingSourceUser;
            this.comboBoxUser.DisplayMember = "nomUtilisateur";
            this.comboBoxUser.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(353, 277);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(249, 47);
            this.comboBoxUser.TabIndex = 47;
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
            this.labelUser.Location = new System.Drawing.Point(159, 280);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(164, 39);
            this.labelUser.TabIndex = 48;
            this.labelUser.Text = "Promeneur";
            // 
            // chienTableAdapter
            // 
            this.chienTableAdapter.ClearBeforeFill = true;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(353, 152);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(249, 31);
            this.dateTimePicker.TabIndex = 50;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(244, 147);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(79, 39);
            this.labelDate.TabIndex = 51;
            this.labelDate.Text = "Date";
            // 
            // PromenadeCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.labelDog);
            this.Controls.Add(this.comboBoxDog);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.createPromenadeTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PromenadeCreate";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PromenadeCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label createPromenadeTitle;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.ComboBox comboBoxDog;
        private System.Windows.Forms.Label labelDog;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.BindingSource bindingSourceDog;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.chienTableAdapter chienTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDate;
    }
}