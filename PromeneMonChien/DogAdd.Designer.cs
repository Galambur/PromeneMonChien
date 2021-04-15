﻿namespace PromeneMonChien
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).BeginInit();
            this.SuspendLayout();
            // 
            // createDogTitle
            // 
            this.createDogTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.createDogTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDogTitle.Location = new System.Drawing.Point(0, 0);
            this.createDogTitle.Name = "createDogTitle";
            this.createDogTitle.Size = new System.Drawing.Size(800, 100);
            this.createDogTitle.TabIndex = 2;
            this.createDogTitle.Text = "Ajouter un chien";
            this.createDogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.DataSource = this.bindingSourceUser;
            this.comboBoxUser.DisplayMember = "nomUtilisateur";
            this.comboBoxUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(363, 103);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(146, 31);
            this.comboBoxUser.TabIndex = 1;
            this.comboBoxUser.ValueMember = "idUtilisateur";
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataMember = "utilisateur";
            this.bindingSourceUser.DataSource = this.promenemonchienDataSet;
            this.bindingSourceUser.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // promenemonchienDataSet
            // 
            this.promenemonchienDataSet.DataSetName = "promenemonchienDataSet";
            this.promenemonchienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(248, 106);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(90, 23);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Utilisateur";
            // 
            // textBoxDogName
            // 
            this.textBoxDogName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDogName.Location = new System.Drawing.Point(363, 149);
            this.textBoxDogName.Name = "textBoxDogName";
            this.textBoxDogName.Size = new System.Drawing.Size(146, 31);
            this.textBoxDogName.TabIndex = 2;
            // 
            // comboBoxDogType
            // 
            this.comboBoxDogType.DataSource = this.bindingSourceType;
            this.comboBoxDogType.DisplayMember = "nomType";
            this.comboBoxDogType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDogType.FormattingEnabled = true;
            this.comboBoxDogType.Location = new System.Drawing.Point(363, 197);
            this.comboBoxDogType.Name = "comboBoxDogType";
            this.comboBoxDogType.Size = new System.Drawing.Size(146, 31);
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
            this.descriptionBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(363, 247);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(233, 85);
            this.descriptionBox.TabIndex = 4;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(224, 200);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(114, 23);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Type de chien";
            // 
            // dogNameLabel
            // 
            this.dogNameLabel.AutoSize = true;
            this.dogNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogNameLabel.Location = new System.Drawing.Point(222, 152);
            this.dogNameLabel.Name = "dogNameLabel";
            this.dogNameLabel.Size = new System.Drawing.Size(116, 23);
            this.dogNameLabel.TabIndex = 10;
            this.dogNameLabel.Text = "Nom du chien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
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
            this.validateButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(600, 382);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(84, 40);
            this.validateButton.TabIndex = 12;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_clicked);
            // 
            // AddDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "AddDog";
            this.Text = "Promène mon chien";
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
    }
}