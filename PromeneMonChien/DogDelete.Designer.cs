namespace PromeneMonChien
{
    partial class DogDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogDelete));
            this.deleteUserTitle = new System.Windows.Forms.Label();
            this.comboBoxDogName = new System.Windows.Forms.ComboBox();
            this.bindingSourceDog = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.nameLabel = new System.Windows.Forms.Label();
            this.chienTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.chienTableAdapter();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // deleteUserTitle
            // 
            this.deleteUserTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteUserTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserTitle.Location = new System.Drawing.Point(0, 0);
            this.deleteUserTitle.Name = "deleteUserTitle";
            this.deleteUserTitle.Size = new System.Drawing.Size(1185, 100);
            this.deleteUserTitle.TabIndex = 43;
            this.deleteUserTitle.Text = "Supprimer un chien de la base";
            this.deleteUserTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDogName
            // 
            this.comboBoxDogName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDogName.DataSource = this.bindingSourceDog;
            this.comboBoxDogName.DisplayMember = "nomChien";
            this.comboBoxDogName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDogName.FormattingEnabled = true;
            this.comboBoxDogName.Location = new System.Drawing.Point(543, 136);
            this.comboBoxDogName.Name = "comboBoxDogName";
            this.comboBoxDogName.Size = new System.Drawing.Size(249, 47);
            this.comboBoxDogName.TabIndex = 44;
            this.comboBoxDogName.ValueMember = "idChien";
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
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(431, 139);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 39);
            this.nameLabel.TabIndex = 45;
            this.nameLabel.Text = "Nom";
            // 
            // chienTableAdapter
            // 
            this.chienTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxType
            // 
            this.textBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceDog, "idType", true));
            this.textBoxType.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxType.Location = new System.Drawing.Point(543, 212);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(249, 47);
            this.textBoxType.TabIndex = 46;
            // 
            // labelType
            // 
            this.labelType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(433, 215);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(79, 39);
            this.labelType.TabIndex = 47;
            this.labelType.Text = "Type";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceDog, "idUtilisateur", true));
            this.textBoxUser.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(543, 291);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(249, 47);
            this.textBoxUser.TabIndex = 48;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(340, 294);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(172, 39);
            this.labelUser.TabIndex = 49;
            this.labelUser.Text = "Propriétaire";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceDog, "description", true));
            this.textBoxDescription.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(543, 372);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(272, 112);
            this.textBoxDescription.TabIndex = 50;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(345, 375);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(167, 39);
            this.labelDescription.TabIndex = 51;
            this.labelDescription.Text = "Description";
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validateButton.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(1037, 617);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(136, 49);
            this.validateButton.TabIndex = 52;
            this.validateButton.Text = "Supprimer";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // checkBoxVendredi
            // 
            this.checkBoxVendredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxVendredi.AutoSize = true;
            this.checkBoxVendredi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "vendredi", true));
            this.checkBoxVendredi.Enabled = false;
            this.checkBoxVendredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVendredi.Location = new System.Drawing.Point(479, 543);
            this.checkBoxVendredi.Name = "checkBoxVendredi";
            this.checkBoxVendredi.Size = new System.Drawing.Size(141, 35);
            this.checkBoxVendredi.TabIndex = 60;
            this.checkBoxVendredi.Text = "Vendredi";
            this.checkBoxVendredi.UseVisualStyleBackColor = true;
            // 
            // checkBoxSamedi
            // 
            this.checkBoxSamedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSamedi.AutoSize = true;
            this.checkBoxSamedi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "samedi", true));
            this.checkBoxSamedi.Enabled = false;
            this.checkBoxSamedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSamedi.Location = new System.Drawing.Point(626, 543);
            this.checkBoxSamedi.Name = "checkBoxSamedi";
            this.checkBoxSamedi.Size = new System.Drawing.Size(124, 35);
            this.checkBoxSamedi.TabIndex = 59;
            this.checkBoxSamedi.Text = "Samedi";
            this.checkBoxSamedi.UseVisualStyleBackColor = true;
            // 
            // checkBoxDimanche
            // 
            this.checkBoxDimanche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDimanche.AutoSize = true;
            this.checkBoxDimanche.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "dimanche", true));
            this.checkBoxDimanche.Enabled = false;
            this.checkBoxDimanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDimanche.Location = new System.Drawing.Point(756, 543);
            this.checkBoxDimanche.Name = "checkBoxDimanche";
            this.checkBoxDimanche.Size = new System.Drawing.Size(155, 35);
            this.checkBoxDimanche.TabIndex = 58;
            this.checkBoxDimanche.Text = "Dimanche";
            this.checkBoxDimanche.UseVisualStyleBackColor = true;
            // 
            // checkBoxMardi
            // 
            this.checkBoxMardi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMardi.AutoSize = true;
            this.checkBoxMardi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "mardi", true));
            this.checkBoxMardi.Enabled = false;
            this.checkBoxMardi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMardi.Location = new System.Drawing.Point(626, 502);
            this.checkBoxMardi.Name = "checkBoxMardi";
            this.checkBoxMardi.Size = new System.Drawing.Size(100, 35);
            this.checkBoxMardi.TabIndex = 57;
            this.checkBoxMardi.Text = "Mardi";
            this.checkBoxMardi.UseVisualStyleBackColor = true;
            // 
            // checkBoxMercredi
            // 
            this.checkBoxMercredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMercredi.AutoSize = true;
            this.checkBoxMercredi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "mercredi", true));
            this.checkBoxMercredi.Enabled = false;
            this.checkBoxMercredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMercredi.Location = new System.Drawing.Point(756, 502);
            this.checkBoxMercredi.Name = "checkBoxMercredi";
            this.checkBoxMercredi.Size = new System.Drawing.Size(138, 35);
            this.checkBoxMercredi.TabIndex = 56;
            this.checkBoxMercredi.Text = "Mercredi";
            this.checkBoxMercredi.UseVisualStyleBackColor = true;
            // 
            // checkBoxJeudi
            // 
            this.checkBoxJeudi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxJeudi.AutoSize = true;
            this.checkBoxJeudi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "jeudi", true));
            this.checkBoxJeudi.Enabled = false;
            this.checkBoxJeudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJeudi.Location = new System.Drawing.Point(917, 502);
            this.checkBoxJeudi.Name = "checkBoxJeudi";
            this.checkBoxJeudi.Size = new System.Drawing.Size(98, 35);
            this.checkBoxJeudi.TabIndex = 55;
            this.checkBoxJeudi.Text = "Jeudi";
            this.checkBoxJeudi.UseVisualStyleBackColor = true;
            // 
            // checkBoxLundi
            // 
            this.checkBoxLundi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxLundi.AutoSize = true;
            this.checkBoxLundi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceDog, "lundi", true));
            this.checkBoxLundi.Enabled = false;
            this.checkBoxLundi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLundi.Location = new System.Drawing.Point(479, 502);
            this.checkBoxLundi.Name = "checkBoxLundi";
            this.checkBoxLundi.Size = new System.Drawing.Size(99, 35);
            this.checkBoxLundi.TabIndex = 54;
            this.checkBoxLundi.Text = "Lundi";
            this.checkBoxLundi.UseVisualStyleBackColor = true;
            // 
            // labelDays
            // 
            this.labelDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(104, 499);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(359, 39);
            this.labelDays.TabIndex = 53;
            this.labelDays.Text = "Jour de non disponibilité ?";
            // 
            // DogDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1185, 678);
            this.Controls.Add(this.checkBoxVendredi);
            this.Controls.Add(this.checkBoxSamedi);
            this.Controls.Add(this.checkBoxDimanche);
            this.Controls.Add(this.checkBoxMardi);
            this.Controls.Add(this.checkBoxMercredi);
            this.Controls.Add(this.checkBoxJeudi);
            this.Controls.Add(this.checkBoxLundi);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.comboBoxDogName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.deleteUserTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DogDelete";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DogDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteUserTitle;
        private System.Windows.Forms.ComboBox comboBoxDogName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.BindingSource bindingSourceDog;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.chienTableAdapter chienTableAdapter;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
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