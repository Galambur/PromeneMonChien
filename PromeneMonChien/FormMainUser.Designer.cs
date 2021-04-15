namespace PromeneMonChien
{
    partial class FormMainUser
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
            this.connectionLabel = new System.Windows.Forms.LinkLabel();
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
            this.CreateUserLabel.Location = new System.Drawing.Point(0, 203);
            this.CreateUserLabel.Name = "CreateUserLabel";
            this.CreateUserLabel.Size = new System.Drawing.Size(800, 75);
            this.CreateUserLabel.TabIndex = 1;
            this.CreateUserLabel.TabStop = true;
            this.CreateUserLabel.Text = "Créer un compte";
            this.CreateUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateUserLabel.VisitedLinkColor = System.Drawing.Color.Green;
            this.CreateUserLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createUser_clicked);
            // 
            // connectionLabel
            // 
            this.connectionLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.connectionLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLabel.LinkColor = System.Drawing.Color.DarkGreen;
            this.connectionLabel.Location = new System.Drawing.Point(0, 288);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(800, 75);
            this.connectionLabel.TabIndex = 2;
            this.connectionLabel.TabStop = true;
            this.connectionLabel.Text = "Se connecter";
            this.connectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectionLabel.VisitedLinkColor = System.Drawing.Color.Green;
            this.connectionLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.connexion_clicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.CreateUserLabel);
            this.Controls.Add(this.mainTitle);
            this.Name = "FormMain";
            this.Text = "Promène mon chien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.LinkLabel CreateUserLabel;
        private System.Windows.Forms.LinkLabel connectionLabel;
    }
}