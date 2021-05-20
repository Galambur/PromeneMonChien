namespace PromeneMonChien
{
    partial class FormMainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainAdmin));
            this.mainTitle = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.dogLabel = new System.Windows.Forms.Label();
            this.promenadeLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.modifyUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.showUserButton = new System.Windows.Forms.Button();
            this.showDogsButton = new System.Windows.Forms.Button();
            this.addDogButton = new System.Windows.Forms.Button();
            this.modifyDogButton = new System.Windows.Forms.Button();
            this.deleteDogButton = new System.Windows.Forms.Button();
            this.showPromenadesButton = new System.Windows.Forms.Button();
            this.addPromenadeButton = new System.Windows.Forms.Button();
            this.modifyPromenadeButton = new System.Windows.Forms.Button();
            this.deletePromenadeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(0, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(1074, 100);
            this.mainTitle.TabIndex = 1;
            this.mainTitle.Text = "Bienvenue sur Promène mon chien ! ";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientLabel
            // 
            this.clientLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.clientLabel.Location = new System.Drawing.Point(207, 164);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(115, 42);
            this.clientLabel.TabIndex = 3;
            this.clientLabel.Text = "Clients";
            // 
            // dogLabel
            // 
            this.dogLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dogLabel.AutoSize = true;
            this.dogLabel.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.dogLabel.Location = new System.Drawing.Point(479, 164);
            this.dogLabel.Name = "dogLabel";
            this.dogLabel.Size = new System.Drawing.Size(112, 42);
            this.dogLabel.TabIndex = 4;
            this.dogLabel.Text = "Chiens";
            // 
            // promenadeLabel
            // 
            this.promenadeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.promenadeLabel.AutoSize = true;
            this.promenadeLabel.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promenadeLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.promenadeLabel.Location = new System.Drawing.Point(710, 164);
            this.promenadeLabel.Name = "promenadeLabel";
            this.promenadeLabel.Size = new System.Drawing.Size(197, 42);
            this.promenadeLabel.TabIndex = 5;
            this.promenadeLabel.Text = "Promenades";
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Location = new System.Drawing.Point(176, 306);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(170, 48);
            this.addUserButton.TabIndex = 2;
            this.addUserButton.Text = "Ajouter";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // modifyUserButton
            // 
            this.modifyUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyUserButton.Location = new System.Drawing.Point(176, 370);
            this.modifyUserButton.Name = "modifyUserButton";
            this.modifyUserButton.Size = new System.Drawing.Size(170, 48);
            this.modifyUserButton.TabIndex = 3;
            this.modifyUserButton.Text = "Modifier";
            this.modifyUserButton.UseVisualStyleBackColor = true;
            this.modifyUserButton.Click += new System.EventHandler(this.modifyUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.Location = new System.Drawing.Point(176, 430);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(170, 48);
            this.deleteUserButton.TabIndex = 4;
            this.deleteUserButton.Text = "Supprimer";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // showUserButton
            // 
            this.showUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showUserButton.Location = new System.Drawing.Point(176, 238);
            this.showUserButton.Name = "showUserButton";
            this.showUserButton.Size = new System.Drawing.Size(170, 48);
            this.showUserButton.TabIndex = 1;
            this.showUserButton.Text = "Afficher";
            this.showUserButton.UseVisualStyleBackColor = true;
            this.showUserButton.Click += new System.EventHandler(this.showUserButton_Click);
            // 
            // showDogsButton
            // 
            this.showDogsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showDogsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDogsButton.Location = new System.Drawing.Point(451, 238);
            this.showDogsButton.Name = "showDogsButton";
            this.showDogsButton.Size = new System.Drawing.Size(170, 48);
            this.showDogsButton.TabIndex = 5;
            this.showDogsButton.Text = "Afficher";
            this.showDogsButton.UseVisualStyleBackColor = true;
            this.showDogsButton.Click += new System.EventHandler(this.showDogsButton_Click);
            // 
            // addDogButton
            // 
            this.addDogButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDogButton.Location = new System.Drawing.Point(451, 306);
            this.addDogButton.Name = "addDogButton";
            this.addDogButton.Size = new System.Drawing.Size(170, 48);
            this.addDogButton.TabIndex = 6;
            this.addDogButton.Text = "Ajouter";
            this.addDogButton.UseVisualStyleBackColor = true;
            this.addDogButton.Click += new System.EventHandler(this.addDogButton_Click);
            // 
            // modifyDogButton
            // 
            this.modifyDogButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyDogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyDogButton.Location = new System.Drawing.Point(451, 370);
            this.modifyDogButton.Name = "modifyDogButton";
            this.modifyDogButton.Size = new System.Drawing.Size(170, 48);
            this.modifyDogButton.TabIndex = 7;
            this.modifyDogButton.Text = "Modifier";
            this.modifyDogButton.UseVisualStyleBackColor = true;
            this.modifyDogButton.Click += new System.EventHandler(this.modifyDogButton_Click);
            // 
            // deleteDogButton
            // 
            this.deleteDogButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteDogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDogButton.Location = new System.Drawing.Point(451, 430);
            this.deleteDogButton.Name = "deleteDogButton";
            this.deleteDogButton.Size = new System.Drawing.Size(170, 48);
            this.deleteDogButton.TabIndex = 8;
            this.deleteDogButton.Text = "Supprimer";
            this.deleteDogButton.UseVisualStyleBackColor = true;
            this.deleteDogButton.Click += new System.EventHandler(this.deleteDogButton_Click);
            // 
            // showPromenadesButton
            // 
            this.showPromenadesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPromenadesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPromenadesButton.Location = new System.Drawing.Point(727, 238);
            this.showPromenadesButton.Name = "showPromenadesButton";
            this.showPromenadesButton.Size = new System.Drawing.Size(170, 48);
            this.showPromenadesButton.TabIndex = 9;
            this.showPromenadesButton.Text = "Afficher";
            this.showPromenadesButton.UseVisualStyleBackColor = true;
            this.showPromenadesButton.Click += new System.EventHandler(this.showPromenadesButton_Click);
            // 
            // addPromenadeButton
            // 
            this.addPromenadeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addPromenadeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPromenadeButton.Location = new System.Drawing.Point(727, 306);
            this.addPromenadeButton.Name = "addPromenadeButton";
            this.addPromenadeButton.Size = new System.Drawing.Size(170, 48);
            this.addPromenadeButton.TabIndex = 10;
            this.addPromenadeButton.Text = "Ajouter";
            this.addPromenadeButton.UseVisualStyleBackColor = true;
            this.addPromenadeButton.Click += new System.EventHandler(this.addPromenadeButton_Click);
            // 
            // modifyPromenadeButton
            // 
            this.modifyPromenadeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyPromenadeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPromenadeButton.Location = new System.Drawing.Point(727, 370);
            this.modifyPromenadeButton.Name = "modifyPromenadeButton";
            this.modifyPromenadeButton.Size = new System.Drawing.Size(170, 48);
            this.modifyPromenadeButton.TabIndex = 11;
            this.modifyPromenadeButton.Text = "Modifier";
            this.modifyPromenadeButton.UseVisualStyleBackColor = true;
            this.modifyPromenadeButton.Click += new System.EventHandler(this.modifyPromenadeButton_Click);
            // 
            // deletePromenadeButton
            // 
            this.deletePromenadeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletePromenadeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePromenadeButton.Location = new System.Drawing.Point(727, 430);
            this.deletePromenadeButton.Name = "deletePromenadeButton";
            this.deletePromenadeButton.Size = new System.Drawing.Size(170, 48);
            this.deletePromenadeButton.TabIndex = 12;
            this.deletePromenadeButton.Text = "Supprimer";
            this.deletePromenadeButton.UseVisualStyleBackColor = true;
            this.deletePromenadeButton.Click += new System.EventHandler(this.deletePromenadeButton_Click);
            // 
            // FormMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1074, 627);
            this.Controls.Add(this.deletePromenadeButton);
            this.Controls.Add(this.modifyPromenadeButton);
            this.Controls.Add(this.addPromenadeButton);
            this.Controls.Add(this.showPromenadesButton);
            this.Controls.Add(this.deleteDogButton);
            this.Controls.Add(this.modifyDogButton);
            this.Controls.Add(this.addDogButton);
            this.Controls.Add(this.showDogsButton);
            this.Controls.Add(this.showUserButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.modifyUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.promenadeLabel);
            this.Controls.Add(this.dogLabel);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.mainTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainAdmin";
            this.Text = "Promène mon chien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Label dogLabel;
        private System.Windows.Forms.Label promenadeLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button modifyUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button showUserButton;
        private System.Windows.Forms.Button showDogsButton;
        private System.Windows.Forms.Button addDogButton;
        private System.Windows.Forms.Button modifyDogButton;
        private System.Windows.Forms.Button deleteDogButton;
        private System.Windows.Forms.Button showPromenadesButton;
        private System.Windows.Forms.Button addPromenadeButton;
        private System.Windows.Forms.Button modifyPromenadeButton;
        private System.Windows.Forms.Button deletePromenadeButton;
    }
}