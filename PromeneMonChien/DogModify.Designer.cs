namespace PromeneMonChien
{
    partial class DogModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogModify));
            this.modifyDogTitle = new System.Windows.Forms.Label();
            this.comboBoxDog = new System.Windows.Forms.ComboBox();
            this.bindingSourceDog = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.bindingSourceType = new System.Windows.Forms.BindingSource(this.components);
            this.typeLabel = new System.Windows.Forms.Label();
            this.proprietaireLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.typeTableAdapter();
            this.chienTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.chienTableAdapter();
            this.comboBoxProprietaire = new System.Windows.Forms.ComboBox();
            this.bindingSourceProprietaire = new System.Windows.Forms.BindingSource(this.components);
            this.description = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.utilisateurTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.utilisateurTableAdapter();
            this.validateButton = new System.Windows.Forms.Button();
            this.checkBoxVendredi = new System.Windows.Forms.CheckBox();
            this.checkBoxSamedi = new System.Windows.Forms.CheckBox();
            this.checkBoxDimanche = new System.Windows.Forms.CheckBox();
            this.checkBoxMardi = new System.Windows.Forms.CheckBox();
            this.checkBoxMercredi = new System.Windows.Forms.CheckBox();
            this.checkBoxJeudi = new System.Windows.Forms.CheckBox();
            this.checkBoxLundi = new System.Windows.Forms.CheckBox();
            this.labelDays = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProprietaire)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyDogTitle
            // 
            this.modifyDogTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.modifyDogTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyDogTitle.Location = new System.Drawing.Point(0, 0);
            this.modifyDogTitle.Name = "modifyDogTitle";
            this.modifyDogTitle.Size = new System.Drawing.Size(1285, 100);
            this.modifyDogTitle.TabIndex = 17;
            this.modifyDogTitle.Text = "Modifier les informations d\'un chien";
            this.modifyDogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDog
            // 
            this.comboBoxDog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDog.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceDog, "nomChien", true));
            this.comboBoxDog.DataSource = this.bindingSourceDog;
            this.comboBoxDog.DisplayMember = "nomChien";
            this.comboBoxDog.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDog.FormattingEnabled = true;
            this.comboBoxDog.Location = new System.Drawing.Point(574, 140);
            this.comboBoxDog.Name = "comboBoxDog";
            this.comboBoxDog.Size = new System.Drawing.Size(249, 47);
            this.comboBoxDog.TabIndex = 27;
            this.comboBoxDog.ValueMember = "idChien";
            this.comboBoxDog.SelectedIndexChanged += new System.EventHandler(this.comboBoxDog_SelectedIndexChanged);
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
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceDog, "idType", true));
            this.comboBoxType.DataSource = this.bindingSourceType;
            this.comboBoxType.DisplayMember = "nomType";
            this.comboBoxType.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(574, 214);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(249, 47);
            this.comboBoxType.TabIndex = 30;
            this.comboBoxType.ValueMember = "idType";
            // 
            // bindingSourceType
            // 
            this.bindingSourceType.DataMember = "type";
            this.bindingSourceType.DataSource = this.promenemonchienDataSet;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(453, 217);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(79, 39);
            this.typeLabel.TabIndex = 35;
            this.typeLabel.Text = "Type";
            // 
            // proprietaireLabel
            // 
            this.proprietaireLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proprietaireLabel.AutoSize = true;
            this.proprietaireLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proprietaireLabel.Location = new System.Drawing.Point(360, 297);
            this.proprietaireLabel.Name = "proprietaireLabel";
            this.proprietaireLabel.Size = new System.Drawing.Size(172, 39);
            this.proprietaireLabel.TabIndex = 33;
            this.proprietaireLabel.Text = "Propriétaire";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(451, 143);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 39);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "Nom";
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // chienTableAdapter
            // 
            this.chienTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxProprietaire
            // 
            this.comboBoxProprietaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxProprietaire.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceDog, "idUtilisateur", true));
            this.comboBoxProprietaire.DataSource = this.bindingSourceProprietaire;
            this.comboBoxProprietaire.DisplayMember = "nomUtilisateur";
            this.comboBoxProprietaire.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProprietaire.FormattingEnabled = true;
            this.comboBoxProprietaire.Location = new System.Drawing.Point(574, 294);
            this.comboBoxProprietaire.Name = "comboBoxProprietaire";
            this.comboBoxProprietaire.Size = new System.Drawing.Size(249, 47);
            this.comboBoxProprietaire.TabIndex = 36;
            this.comboBoxProprietaire.ValueMember = "idUtilisateur";
            // 
            // bindingSourceProprietaire
            // 
            this.bindingSourceProprietaire.DataMember = "utilisateur";
            this.bindingSourceProprietaire.DataSource = this.promenemonchienDataSet;
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(365, 382);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(167, 39);
            this.description.TabIndex = 37;
            this.description.Text = "Description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceDog, "description", true));
            this.descriptionBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(574, 379);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(307, 103);
            this.descriptionBox.TabIndex = 38;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validateButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(1161, 643);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(112, 52);
            this.validateButton.TabIndex = 39;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // checkBoxVendredi
            // 
            this.checkBoxVendredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxVendredi.AutoSize = true;
            this.checkBoxVendredi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "vendredi", true));
            this.checkBoxVendredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVendredi.Location = new System.Drawing.Point(507, 574);
            this.checkBoxVendredi.Name = "checkBoxVendredi";
            this.checkBoxVendredi.Size = new System.Drawing.Size(141, 35);
            this.checkBoxVendredi.TabIndex = 53;
            this.checkBoxVendredi.Text = "Vendredi";
            this.checkBoxVendredi.UseVisualStyleBackColor = true;
            // 
            // checkBoxSamedi
            // 
            this.checkBoxSamedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSamedi.AutoSize = true;
            this.checkBoxSamedi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "samedi", true));
            this.checkBoxSamedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSamedi.Location = new System.Drawing.Point(654, 574);
            this.checkBoxSamedi.Name = "checkBoxSamedi";
            this.checkBoxSamedi.Size = new System.Drawing.Size(124, 35);
            this.checkBoxSamedi.TabIndex = 52;
            this.checkBoxSamedi.Text = "Samedi";
            this.checkBoxSamedi.UseVisualStyleBackColor = true;
            // 
            // checkBoxDimanche
            // 
            this.checkBoxDimanche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDimanche.AutoSize = true;
            this.checkBoxDimanche.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "dimanche", true));
            this.checkBoxDimanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDimanche.Location = new System.Drawing.Point(784, 574);
            this.checkBoxDimanche.Name = "checkBoxDimanche";
            this.checkBoxDimanche.Size = new System.Drawing.Size(155, 35);
            this.checkBoxDimanche.TabIndex = 51;
            this.checkBoxDimanche.Text = "Dimanche";
            this.checkBoxDimanche.UseVisualStyleBackColor = true;
            // 
            // checkBoxMardi
            // 
            this.checkBoxMardi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMardi.AutoSize = true;
            this.checkBoxMardi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "mardi", true));
            this.checkBoxMardi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMardi.Location = new System.Drawing.Point(654, 533);
            this.checkBoxMardi.Name = "checkBoxMardi";
            this.checkBoxMardi.Size = new System.Drawing.Size(100, 35);
            this.checkBoxMardi.TabIndex = 50;
            this.checkBoxMardi.Text = "Mardi";
            this.checkBoxMardi.UseVisualStyleBackColor = true;
            // 
            // checkBoxMercredi
            // 
            this.checkBoxMercredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMercredi.AutoSize = true;
            this.checkBoxMercredi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "mercredi", true));
            this.checkBoxMercredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMercredi.Location = new System.Drawing.Point(784, 533);
            this.checkBoxMercredi.Name = "checkBoxMercredi";
            this.checkBoxMercredi.Size = new System.Drawing.Size(138, 35);
            this.checkBoxMercredi.TabIndex = 49;
            this.checkBoxMercredi.Text = "Mercredi";
            this.checkBoxMercredi.UseVisualStyleBackColor = true;
            // 
            // checkBoxJeudi
            // 
            this.checkBoxJeudi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxJeudi.AutoSize = true;
            this.checkBoxJeudi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "jeudi", true));
            this.checkBoxJeudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJeudi.Location = new System.Drawing.Point(945, 533);
            this.checkBoxJeudi.Name = "checkBoxJeudi";
            this.checkBoxJeudi.Size = new System.Drawing.Size(98, 35);
            this.checkBoxJeudi.TabIndex = 48;
            this.checkBoxJeudi.Text = "Jeudi";
            this.checkBoxJeudi.UseVisualStyleBackColor = true;
            // 
            // checkBoxLundi
            // 
            this.checkBoxLundi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxLundi.AutoSize = true;
            this.checkBoxLundi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "lundi", true));
            this.checkBoxLundi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLundi.Location = new System.Drawing.Point(507, 533);
            this.checkBoxLundi.Name = "checkBoxLundi";
            this.checkBoxLundi.Size = new System.Drawing.Size(99, 35);
            this.checkBoxLundi.TabIndex = 47;
            this.checkBoxLundi.Text = "Lundi";
            this.checkBoxLundi.UseVisualStyleBackColor = true;
            // 
            // labelDays
            // 
            this.labelDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(132, 530);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(359, 39);
            this.labelDays.TabIndex = 46;
            this.labelDays.Text = "Jour de non disponibilité ?";
            // 
            // DogModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1285, 707);
            this.Controls.Add(this.checkBoxVendredi);
            this.Controls.Add(this.checkBoxSamedi);
            this.Controls.Add(this.checkBoxDimanche);
            this.Controls.Add(this.checkBoxMardi);
            this.Controls.Add(this.checkBoxMercredi);
            this.Controls.Add(this.checkBoxJeudi);
            this.Controls.Add(this.checkBoxLundi);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.comboBoxProprietaire);
            this.Controls.Add(this.comboBoxDog);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.proprietaireLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.modifyDogTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DogModify";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DogModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProprietaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyDogTitle;
        private System.Windows.Forms.ComboBox comboBoxDog;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label proprietaireLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource bindingSourceType;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.typeTableAdapter typeTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceDog;
        private promenemonchienDataSetTableAdapters.chienTableAdapter chienTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxProprietaire;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.BindingSource bindingSourceProprietaire;
        private promenemonchienDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
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