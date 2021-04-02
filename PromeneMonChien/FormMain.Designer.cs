namespace PromeneMonChien
{
    partial class FormMain
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
            this.mainTitle = new System.Windows.Forms.Label();
            this.CreateUserLabel = new System.Windows.Forms.LinkLabel();
            this.addDogs = new System.Windows.Forms.LinkLabel();
            this.showUsersLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabelModify = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(0, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(800, 100);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Bienvenue sur Promène mon chien !";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateUserLabel
            // 
            this.CreateUserLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CreateUserLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserLabel.LinkColor = System.Drawing.Color.DarkGreen;
            this.CreateUserLabel.Location = new System.Drawing.Point(0, 283);
            this.CreateUserLabel.Name = "CreateUserLabel";
            this.CreateUserLabel.Size = new System.Drawing.Size(800, 75);
            this.CreateUserLabel.TabIndex = 1;
            this.CreateUserLabel.TabStop = true;
            this.CreateUserLabel.Text = "CreateUser";
            this.CreateUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateUserLabel.VisitedLinkColor = System.Drawing.Color.Green;
            this.CreateUserLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createUser_clicked);
            // 
            // addDogs
            // 
            this.addDogs.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addDogs.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDogs.LinkColor = System.Drawing.Color.DarkGreen;
            this.addDogs.Location = new System.Drawing.Point(0, 208);
            this.addDogs.Name = "addDogs";
            this.addDogs.Size = new System.Drawing.Size(800, 75);
            this.addDogs.TabIndex = 4;
            this.addDogs.TabStop = true;
            this.addDogs.Text = "Add dogs";
            this.addDogs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addDogs.VisitedLinkColor = System.Drawing.Color.Green;
            this.addDogs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addDogs_clicked);
            // 
            // showUsersLabel
            // 
            this.showUsersLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showUsersLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUsersLabel.LinkColor = System.Drawing.Color.DarkGreen;
            this.showUsersLabel.Location = new System.Drawing.Point(0, 129);
            this.showUsersLabel.Name = "showUsersLabel";
            this.showUsersLabel.Size = new System.Drawing.Size(800, 79);
            this.showUsersLabel.TabIndex = 5;
            this.showUsersLabel.TabStop = true;
            this.showUsersLabel.Text = "ShowUsers";
            this.showUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showUsersLabel.VisitedLinkColor = System.Drawing.Color.Green;
            this.showUsersLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showUsers_clicked);
            // 
            // linkLabelModify
            // 
            this.linkLabelModify.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabelModify.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelModify.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkLabelModify.Location = new System.Drawing.Point(0, 358);
            this.linkLabelModify.Name = "linkLabelModify";
            this.linkLabelModify.Size = new System.Drawing.Size(800, 75);
            this.linkLabelModify.TabIndex = 6;
            this.linkLabelModify.TabStop = true;
            this.linkLabelModify.Text = "Modify user";
            this.linkLabelModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelModify.VisitedLinkColor = System.Drawing.Color.Green;
            this.linkLabelModify.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.modifyLink_clicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelModify);
            this.Controls.Add(this.showUsersLabel);
            this.Controls.Add(this.addDogs);
            this.Controls.Add(this.CreateUserLabel);
            this.Controls.Add(this.mainTitle);
            this.Name = "FormMain";
            this.Text = "Promène mon chien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.LinkLabel CreateUserLabel;
        private System.Windows.Forms.LinkLabel addDogs;
        private System.Windows.Forms.LinkLabel showUsersLabel;
        private System.Windows.Forms.LinkLabel linkLabelModify;
    }
}