﻿namespace PromeneMonChien
{
    partial class UserActionPromenadeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserActionPromenadeAdd));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDog = new System.Windows.Forms.Label();
            this.comboBoxDog = new System.Windows.Forms.ComboBox();
            this.createPromenadeTitle = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.bindingSourceDog = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.chienTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.chienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-mm-dd hh:mm";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(328, 204);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 56;
            // 
            // labelDog
            // 
            this.labelDog.AutoSize = true;
            this.labelDog.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDog.Location = new System.Drawing.Point(316, 266);
            this.labelDog.Name = "labelDog";
            this.labelDog.Size = new System.Drawing.Size(53, 23);
            this.labelDog.TabIndex = 53;
            this.labelDog.Text = "Chien";
            // 
            // comboBoxDog
            // 
            this.comboBoxDog.DataSource = this.bindingSourceDog;
            this.comboBoxDog.DisplayMember = "nomChien";
            this.comboBoxDog.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDog.FormattingEnabled = true;
            this.comboBoxDog.Location = new System.Drawing.Point(382, 263);
            this.comboBoxDog.Name = "comboBoxDog";
            this.comboBoxDog.Size = new System.Drawing.Size(146, 31);
            this.comboBoxDog.TabIndex = 52;
            this.comboBoxDog.ValueMember = "idChien";
            // 
            // createPromenadeTitle
            // 
            this.createPromenadeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.createPromenadeTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPromenadeTitle.Location = new System.Drawing.Point(0, 0);
            this.createPromenadeTitle.Name = "createPromenadeTitle";
            this.createPromenadeTitle.Size = new System.Drawing.Size(800, 100);
            this.createPromenadeTitle.TabIndex = 51;
            this.createPromenadeTitle.Text = "Prévoir une promenade";
            this.createPromenadeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validateButton
            // 
            this.validateButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(696, 405);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(92, 33);
            this.validateButton.TabIndex = 57;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
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
            // UserActionPromenadeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDog);
            this.Controls.Add(this.comboBoxDog);
            this.Controls.Add(this.createPromenadeTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserActionPromenadeAdd";
            this.Text = "Promène mon chien";
            this.Load += new System.EventHandler(this.UserActionPromenadeAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDog;
        private System.Windows.Forms.ComboBox comboBoxDog;
        private System.Windows.Forms.Label createPromenadeTitle;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.BindingSource bindingSourceDog;
        private promenemonchienDataSet promenemonchienDataSet;
        private promenemonchienDataSetTableAdapters.chienTableAdapter chienTableAdapter;
    }
}