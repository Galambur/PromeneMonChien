namespace PromeneMonChien
{
    partial class DogAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogAdd));
            this.createDogTitle = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.userLabel = new System.Windows.Forms.Label();
            this.textBoxDogName = new System.Windows.Forms.TextBox();
            this.comboBoxDogType = new System.Windows.Forms.ComboBox();
            this.bindingSourceType = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.dogNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            this.typeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.typeTableAdapter();
            this.validateButton = new System.Windows.Forms.Button();
            this.checkBoxVendredi = new System.Windows.Forms.CheckBox();
            this.checkBoxSamedi = new System.Windows.Forms.CheckBox();
            this.checkBoxDimanche = new System.Windows.Forms.CheckBox();
            this.checkBoxMardi = new System.Windows.Forms.CheckBox();
            this.checkBoxMercredi = new System.Windows.Forms.CheckBox();
            this.checkBoxJeudi = new System.Windows.Forms.CheckBox();
            this.checkBoxLundi = new System.Windows.Forms.CheckBox();
            this.labelDays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).BeginInit();
            this.SuspendLayout();
            // 
            // createDogTitle
            // 
            this.createDogTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.createDogTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDogTitle.Location = new System.Drawing.Point(0, 0);
            this.createDogTitle.Name = "createDogTitle";
            this.createDogTitle.Size = new System.Drawing.Size(1270, 100);
            this.createDogTitle.TabIndex = 2;
            this.createDogTitle.Text = "Ajouter un chien";
            this.createDogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUser.DataSource = this.bindingSourceUser;
            this.comboBoxUser.DisplayMember = "nomUtilisateur";
            this.comboBoxUser.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(616, 144);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(249, 47);
            this.comboBoxUser.TabIndex = 1;
            this.comboBoxUser.ValueMember = "idUtilisateur";
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
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(442, 147);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(153, 39);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Utilisateur";
            // 
            // textBoxDogName
            // 
            this.textBoxDogName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDogName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDogName.Location = new System.Drawing.Point(616, 213);
            this.textBoxDogName.Name = "textBoxDogName";
            this.textBoxDogName.Size = new System.Drawing.Size(249, 47);
            this.textBoxDogName.TabIndex = 2;
            // 
            // comboBoxDogType
            // 
            this.comboBoxDogType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDogType.DataSource = this.bindingSourceType;
            this.comboBoxDogType.DisplayMember = "nomType";
            this.comboBoxDogType.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDogType.FormattingEnabled = true;
            this.comboBoxDogType.Location = new System.Drawing.Point(616, 284);
            this.comboBoxDogType.Name = "comboBoxDogType";
            this.comboBoxDogType.Size = new System.Drawing.Size(249, 47);
            this.comboBoxDogType.TabIndex = 3;
            this.comboBoxDogType.ValueMember = "idType";
            // 
            // bindingSourceType
            // 
            this.bindingSourceType.DataMember = "type";
            this.bindingSourceType.DataSource = this.promenemonchienDataSet;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(616, 352);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(290, 101);
            this.descriptionBox.TabIndex = 4;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(398, 287);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(197, 39);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Type de chien";
            // 
            // dogNameLabel
            // 
            this.dogNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dogNameLabel.AutoSize = true;
            this.dogNameLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogNameLabel.Location = new System.Drawing.Point(395, 216);
            this.dogNameLabel.Name = "dogNameLabel";
            this.dogNameLabel.Size = new System.Drawing.Size(200, 39);
            this.dogNameLabel.TabIndex = 10;
            this.dogNameLabel.Text = "Nom du chien";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description du chien";
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validateButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(1139, 605);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(119, 49);
            this.validateButton.TabIndex = 12;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_clicked);
            // 
            // checkBoxVendredi
            // 
            this.checkBoxVendredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxVendredi.AutoSize = true;
            this.checkBoxVendredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVendredi.Location = new System.Drawing.Point(491, 536);
            this.checkBoxVendredi.Name = "checkBoxVendredi";
            this.checkBoxVendredi.Size = new System.Drawing.Size(141, 35);
            this.checkBoxVendredi.TabIndex = 45;
            this.checkBoxVendredi.Text = "Vendredi";
            this.checkBoxVendredi.UseVisualStyleBackColor = true;
            // 
            // checkBoxSamedi
            // 
            this.checkBoxSamedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSamedi.AutoSize = true;
            this.checkBoxSamedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSamedi.Location = new System.Drawing.Point(638, 536);
            this.checkBoxSamedi.Name = "checkBoxSamedi";
            this.checkBoxSamedi.Size = new System.Drawing.Size(124, 35);
            this.checkBoxSamedi.TabIndex = 44;
            this.checkBoxSamedi.Text = "Samedi";
            this.checkBoxSamedi.UseVisualStyleBackColor = true;
            // 
            // checkBoxDimanche
            // 
            this.checkBoxDimanche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDimanche.AutoSize = true;
            this.checkBoxDimanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDimanche.Location = new System.Drawing.Point(768, 536);
            this.checkBoxDimanche.Name = "checkBoxDimanche";
            this.checkBoxDimanche.Size = new System.Drawing.Size(155, 35);
            this.checkBoxDimanche.TabIndex = 43;
            this.checkBoxDimanche.Text = "Dimanche";
            this.checkBoxDimanche.UseVisualStyleBackColor = true;
            // 
            // checkBoxMardi
            // 
            this.checkBoxMardi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMardi.AutoSize = true;
            this.checkBoxMardi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMardi.Location = new System.Drawing.Point(638, 495);
            this.checkBoxMardi.Name = "checkBoxMardi";
            this.checkBoxMardi.Size = new System.Drawing.Size(100, 35);
            this.checkBoxMardi.TabIndex = 42;
            this.checkBoxMardi.Text = "Mardi";
            this.checkBoxMardi.UseVisualStyleBackColor = true;
            // 
            // checkBoxMercredi
            // 
            this.checkBoxMercredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMercredi.AutoSize = true;
            this.checkBoxMercredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMercredi.Location = new System.Drawing.Point(768, 495);
            this.checkBoxMercredi.Name = "checkBoxMercredi";
            this.checkBoxMercredi.Size = new System.Drawing.Size(138, 35);
            this.checkBoxMercredi.TabIndex = 41;
            this.checkBoxMercredi.Text = "Mercredi";
            this.checkBoxMercredi.UseVisualStyleBackColor = true;
            // 
            // checkBoxJeudi
            // 
            this.checkBoxJeudi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxJeudi.AutoSize = true;
            this.checkBoxJeudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJeudi.Location = new System.Drawing.Point(929, 495);
            this.checkBoxJeudi.Name = "checkBoxJeudi";
            this.checkBoxJeudi.Size = new System.Drawing.Size(98, 35);
            this.checkBoxJeudi.TabIndex = 40;
            this.checkBoxJeudi.Text = "Jeudi";
            this.checkBoxJeudi.UseVisualStyleBackColor = true;
            // 
            // checkBoxLundi
            // 
            this.checkBoxLundi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxLundi.AutoSize = true;
            this.checkBoxLundi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLundi.Location = new System.Drawing.Point(491, 495);
            this.checkBoxLundi.Name = "checkBoxLundi";
            this.checkBoxLundi.Size = new System.Drawing.Size(99, 35);
            this.checkBoxLundi.TabIndex = 39;
            this.checkBoxLundi.Text = "Lundi";
            this.checkBoxLundi.UseVisualStyleBackColor = true;
            // 
            // labelDays
            // 
            this.labelDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(116, 492);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(359, 39);
            this.labelDays.TabIndex = 38;
            this.labelDays.Text = "Jour de non disponibilité ?";
            // 
            // DogAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1270, 666);
            this.Controls.Add(this.checkBoxVendredi);
            this.Controls.Add(this.checkBoxSamedi);
            this.Controls.Add(this.checkBoxDimanche);
            this.Controls.Add(this.checkBoxMardi);
            this.Controls.Add(this.checkBoxMercredi);
            this.Controls.Add(this.checkBoxJeudi);
            this.Controls.Add(this.checkBoxLundi);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dogNameLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.comboBoxDogType);
            this.Controls.Add(this.textBoxDogName);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.createDogTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DogAdd";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddDog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createDogTitle;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox textBoxDogName;
        private System.Windows.Forms.ComboBox comboBoxDogType;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label dogNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceType;
        private promenemonchienDataSetTableAdapters.typeTableAdapter typeTableAdapter;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.CheckBox checkBoxVendredi;
        private System.Windows.Forms.CheckBox checkBoxSamedi;
        private System.Windows.Forms.CheckBox checkBoxDimanche;
        private System.Windows.Forms.CheckBox checkBoxMardi;
        private System.Windows.Forms.CheckBox checkBoxMercredi;
        private System.Windows.Forms.CheckBox checkBoxJeudi;
        private System.Windows.Forms.CheckBox checkBoxLundi;
        private System.Windows.Forms.Label labelDays;
    }
}