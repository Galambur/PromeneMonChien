﻿namespace PromeneMonChien
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
            this.modifyDogTitle.Size = new System.Drawing.Size(1071, 100);
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
            this.comboBoxDog.Location = new System.Drawing.Point(467, 127);
            this.comboBoxDog.Name = "comboBoxDog";
            this.comboBoxDog.Size = new System.Drawing.Size(249, 47);
            this.comboBoxDog.TabIndex = 27;
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
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourceDog, "idType", true));
            this.comboBoxType.DataSource = this.bindingSourceType;
            this.comboBoxType.DisplayMember = "nomType";
            this.comboBoxType.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(467, 201);
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
            this.typeLabel.Location = new System.Drawing.Point(346, 204);
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
            this.proprietaireLabel.Location = new System.Drawing.Point(253, 284);
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
            this.nameLabel.Location = new System.Drawing.Point(344, 130);
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
            this.comboBoxProprietaire.Location = new System.Drawing.Point(467, 281);
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
            this.description.Location = new System.Drawing.Point(258, 369);
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
            this.descriptionBox.Location = new System.Drawing.Point(467, 366);
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
            this.validateButton.Location = new System.Drawing.Point(947, 507);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(112, 52);
            this.validateButton.TabIndex = 39;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // DogModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1071, 571);
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
    }
}