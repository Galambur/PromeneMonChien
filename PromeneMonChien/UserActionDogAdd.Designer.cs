namespace PromeneMonChien
{
    partial class UserActionDogAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserActionDogAdd));
            this.validateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dogNameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.comboBoxDogType = new System.Windows.Forms.ComboBox();
            this.bindingSourceType = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.textBoxDogName = new System.Windows.Forms.TextBox();
            this.createDogTitle = new System.Windows.Forms.Label();
            this.typeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.typeTableAdapter();
            this.labelDays = new System.Windows.Forms.Label();
            this.checkBoxLundi = new System.Windows.Forms.CheckBox();
            this.checkBoxJeudi = new System.Windows.Forms.CheckBox();
            this.checkBoxMercredi = new System.Windows.Forms.CheckBox();
            this.checkBoxMardi = new System.Windows.Forms.CheckBox();
            this.checkBoxDimanche = new System.Windows.Forms.CheckBox();
            this.checkBoxSamedi = new System.Windows.Forms.CheckBox();
            this.checkBoxVendredi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.validateButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(1100, 536);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(112, 52);
            this.validateButton.TabIndex = 22;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "Description du chien";
            // 
            // dogNameLabel
            // 
            this.dogNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dogNameLabel.AutoSize = true;
            this.dogNameLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogNameLabel.Location = new System.Drawing.Point(391, 195);
            this.dogNameLabel.Name = "dogNameLabel";
            this.dogNameLabel.Size = new System.Drawing.Size(200, 39);
            this.dogNameLabel.TabIndex = 20;
            this.dogNameLabel.Text = "Nom du chien";
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(394, 265);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(197, 39);
            this.typeLabel.TabIndex = 19;
            this.typeLabel.Text = "Type de chien";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionBox.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(616, 331);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(308, 114);
            this.descriptionBox.TabIndex = 17;
            // 
            // comboBoxDogType
            // 
            this.comboBoxDogType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDogType.DataSource = this.bindingSourceType;
            this.comboBoxDogType.DisplayMember = "nomType";
            this.comboBoxDogType.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDogType.FormattingEnabled = true;
            this.comboBoxDogType.Location = new System.Drawing.Point(616, 262);
            this.comboBoxDogType.Name = "comboBoxDogType";
            this.comboBoxDogType.Size = new System.Drawing.Size(249, 47);
            this.comboBoxDogType.TabIndex = 16;
            this.comboBoxDogType.ValueMember = "idType";
            // 
            // bindingSourceType
            // 
            this.bindingSourceType.DataMember = "type";
            this.bindingSourceType.DataSource = this.promenemonchienDataSet;
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxDogName
            // 
            this.textBoxDogName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDogName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDogName.Location = new System.Drawing.Point(616, 192);
            this.textBoxDogName.Name = "textBoxDogName";
            this.textBoxDogName.Size = new System.Drawing.Size(249, 47);
            this.textBoxDogName.TabIndex = 14;
            // 
            // createDogTitle
            // 
            this.createDogTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.createDogTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDogTitle.Location = new System.Drawing.Point(0, 0);
            this.createDogTitle.Name = "createDogTitle";
            this.createDogTitle.Size = new System.Drawing.Size(1224, 100);
            this.createDogTitle.TabIndex = 15;
            this.createDogTitle.Text = "Ajouter un chien";
            this.createDogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // labelDays
            // 
            this.labelDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDays.Location = new System.Drawing.Point(26, 472);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(359, 39);
            this.labelDays.TabIndex = 23;
            this.labelDays.Text = "Jour de non disponibilité ?";
            // 
            // checkBoxLundi
            // 
            this.checkBoxLundi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxLundi.AutoSize = true;
            this.checkBoxLundi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLundi.Location = new System.Drawing.Point(401, 475);
            this.checkBoxLundi.Name = "checkBoxLundi";
            this.checkBoxLundi.Size = new System.Drawing.Size(99, 35);
            this.checkBoxLundi.TabIndex = 31;
            this.checkBoxLundi.Text = "Lundi";
            this.checkBoxLundi.UseVisualStyleBackColor = true;
            // 
            // checkBoxJeudi
            // 
            this.checkBoxJeudi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxJeudi.AutoSize = true;
            this.checkBoxJeudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJeudi.Location = new System.Drawing.Point(839, 475);
            this.checkBoxJeudi.Name = "checkBoxJeudi";
            this.checkBoxJeudi.Size = new System.Drawing.Size(98, 35);
            this.checkBoxJeudi.TabIndex = 32;
            this.checkBoxJeudi.Text = "Jeudi";
            this.checkBoxJeudi.UseVisualStyleBackColor = true;
            // 
            // checkBoxMercredi
            // 
            this.checkBoxMercredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMercredi.AutoSize = true;
            this.checkBoxMercredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMercredi.Location = new System.Drawing.Point(678, 475);
            this.checkBoxMercredi.Name = "checkBoxMercredi";
            this.checkBoxMercredi.Size = new System.Drawing.Size(138, 35);
            this.checkBoxMercredi.TabIndex = 33;
            this.checkBoxMercredi.Text = "Mercredi";
            this.checkBoxMercredi.UseVisualStyleBackColor = true;
            // 
            // checkBoxMardi
            // 
            this.checkBoxMardi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMardi.AutoSize = true;
            this.checkBoxMardi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMardi.Location = new System.Drawing.Point(548, 475);
            this.checkBoxMardi.Name = "checkBoxMardi";
            this.checkBoxMardi.Size = new System.Drawing.Size(100, 35);
            this.checkBoxMardi.TabIndex = 34;
            this.checkBoxMardi.Text = "Mardi";
            this.checkBoxMardi.UseVisualStyleBackColor = true;
            // 
            // checkBoxDimanche
            // 
            this.checkBoxDimanche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDimanche.AutoSize = true;
            this.checkBoxDimanche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDimanche.Location = new System.Drawing.Point(678, 516);
            this.checkBoxDimanche.Name = "checkBoxDimanche";
            this.checkBoxDimanche.Size = new System.Drawing.Size(155, 35);
            this.checkBoxDimanche.TabIndex = 35;
            this.checkBoxDimanche.Text = "Dimanche";
            this.checkBoxDimanche.UseVisualStyleBackColor = true;
            // 
            // checkBoxSamedi
            // 
            this.checkBoxSamedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSamedi.AutoSize = true;
            this.checkBoxSamedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSamedi.Location = new System.Drawing.Point(548, 516);
            this.checkBoxSamedi.Name = "checkBoxSamedi";
            this.checkBoxSamedi.Size = new System.Drawing.Size(124, 35);
            this.checkBoxSamedi.TabIndex = 36;
            this.checkBoxSamedi.Text = "Samedi";
            this.checkBoxSamedi.UseVisualStyleBackColor = true;
            // 
            // checkBoxVendredi
            // 
            this.checkBoxVendredi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxVendredi.AutoSize = true;
            this.checkBoxVendredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVendredi.Location = new System.Drawing.Point(401, 516);
            this.checkBoxVendredi.Name = "checkBoxVendredi";
            this.checkBoxVendredi.Size = new System.Drawing.Size(141, 35);
            this.checkBoxVendredi.TabIndex = 37;
            this.checkBoxVendredi.Text = "Vendredi";
            this.checkBoxVendredi.UseVisualStyleBackColor = true;
            // 
            // UserActionDogAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1224, 600);
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
            this.Controls.Add(this.createDogTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserActionDogAdd";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserActionDogAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dogNameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.ComboBox comboBoxDogType;
        private System.Windows.Forms.TextBox textBoxDogName;
        private System.Windows.Forms.Label createDogTitle;
        private System.Windows.Forms.BindingSource bindingSourceType;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.typeTableAdapter typeTableAdapter;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.CheckBox checkBoxLundi;
        private System.Windows.Forms.CheckBox checkBoxJeudi;
        private System.Windows.Forms.CheckBox checkBoxMercredi;
        private System.Windows.Forms.CheckBox checkBoxMardi;
        private System.Windows.Forms.CheckBox checkBoxDimanche;
        private System.Windows.Forms.CheckBox checkBoxSamedi;
        private System.Windows.Forms.CheckBox checkBoxVendredi;
    }
}