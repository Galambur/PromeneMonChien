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
            this.textBoxDogName = new System.Windows.Forms.TextBox();
            this.createDogTitle = new System.Windows.Forms.Label();
            this.bindingSourceType = new System.Windows.Forms.BindingSource(this.components);
            this.promenemonchienDataSet = new PromeneMonChien.promenemonchienDataSet();
            this.typeTableAdapter = new PromeneMonChien.promenemonchienDataSetTableAdapters.typeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promenemonchienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // validateButton
            // 
            this.validateButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.Location = new System.Drawing.Point(704, 404);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(84, 40);
            this.validateButton.TabIndex = 22;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Description du chien";
            // 
            // dogNameLabel
            // 
            this.dogNameLabel.AutoSize = true;
            this.dogNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogNameLabel.Location = new System.Drawing.Point(222, 158);
            this.dogNameLabel.Name = "dogNameLabel";
            this.dogNameLabel.Size = new System.Drawing.Size(116, 23);
            this.dogNameLabel.TabIndex = 20;
            this.dogNameLabel.Text = "Nom du chien";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(224, 206);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(114, 23);
            this.typeLabel.TabIndex = 19;
            this.typeLabel.Text = "Type de chien";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(363, 253);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(233, 85);
            this.descriptionBox.TabIndex = 17;
            // 
            // comboBoxDogType
            // 
            this.comboBoxDogType.DataSource = this.bindingSourceType;
            this.comboBoxDogType.DisplayMember = "nomType";
            this.comboBoxDogType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDogType.FormattingEnabled = true;
            this.comboBoxDogType.Location = new System.Drawing.Point(363, 203);
            this.comboBoxDogType.Name = "comboBoxDogType";
            this.comboBoxDogType.Size = new System.Drawing.Size(146, 31);
            this.comboBoxDogType.TabIndex = 16;
            this.comboBoxDogType.ValueMember = "idType";
            // 
            // textBoxDogName
            // 
            this.textBoxDogName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDogName.Location = new System.Drawing.Point(363, 155);
            this.textBoxDogName.Name = "textBoxDogName";
            this.textBoxDogName.Size = new System.Drawing.Size(146, 31);
            this.textBoxDogName.TabIndex = 14;
            // 
            // createDogTitle
            // 
            this.createDogTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.createDogTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDogTitle.Location = new System.Drawing.Point(0, 0);
            this.createDogTitle.Name = "createDogTitle";
            this.createDogTitle.Size = new System.Drawing.Size(800, 100);
            this.createDogTitle.TabIndex = 15;
            this.createDogTitle.Text = "Ajouter un chien";
            this.createDogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // UserActionDogAdd
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
            this.Controls.Add(this.createDogTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserActionDogAdd";
            this.Text = "Promène mon chien";
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
    }
}