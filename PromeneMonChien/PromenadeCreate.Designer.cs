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
            this.labelDog = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.bindingSourceDog = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.chienTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.chienTableAdapter();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            this.SuspendLayout();
            // 
            // createPromenadeTitle
            // 
            this.createPromenadeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.createPromenadeTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPromenadeTitle.Location = new System.Drawing.Point(0, 0);
            this.createPromenadeTitle.Name = "createPromenadeTitle";
            this.createPromenadeTitle.Size = new System.Drawing.Size(800, 100);
            this.createPromenadeTitle.TabIndex = 43;
            this.createPromenadeTitle.Text = "Prévoir une promenade";
            this.createPromenadeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validateButton
            // 
            this.validateButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(696, 405);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(92, 33);
            this.validateButton.TabIndex = 44;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // comboBoxDog
            // 
            this.comboBoxDog.DataSource = this.bindingSourceDog;
            this.comboBoxDog.DisplayMember = "nomChien";
            this.comboBoxDog.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDog.FormattingEnabled = true;
            this.comboBoxDog.Location = new System.Drawing.Point(380, 227);
            this.comboBoxDog.Name = "comboBoxDog";
            this.comboBoxDog.Size = new System.Drawing.Size(146, 31);
            this.comboBoxDog.TabIndex = 45;
            this.comboBoxDog.ValueMember = "idChien";
            // 
            // labelDog
            // 
            this.labelDog.AutoSize = true;
            this.labelDog.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDog.Location = new System.Drawing.Point(314, 230);
            this.labelDog.Name = "labelDog";
            this.labelDog.Size = new System.Drawing.Size(53, 23);
            this.labelDog.TabIndex = 46;
            this.labelDog.Text = "Chien";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DataSource = this.bindingSourceUser;
            this.comboBoxUser.DisplayMember = "nomUtilisateur";
            this.comboBoxUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(380, 278);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(146, 31);
            this.comboBoxUser.TabIndex = 47;
            this.comboBoxUser.ValueMember = "idUtilisateur";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(270, 281);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(97, 23);
            this.labelUser.TabIndex = 48;
            this.labelUser.Text = "Promeneur";
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
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-mm-dd hh:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(326, 168);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 50;
            // 
            // PromenadeCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}