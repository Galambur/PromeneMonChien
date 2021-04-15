namespace PromeneMonChien
{
    partial class PromenadeCreate
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
            this.monthCalendarPromenade = new System.Windows.Forms.MonthCalendar();
            this.createPromenadeTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendarPromenade
            // 
            this.monthCalendarPromenade.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendarPromenade.Location = new System.Drawing.Point(269, 159);
            this.monthCalendarPromenade.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.monthCalendarPromenade.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.monthCalendarPromenade.Name = "monthCalendarPromenade";
            this.monthCalendarPromenade.TabIndex = 0;
            // 
            // createPromenadeTitle
            // 
            this.createPromenadeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.createPromenadeTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPromenadeTitle.Location = new System.Drawing.Point(0, 0);
            this.createPromenadeTitle.Name = "createPromenadeTitle";
            this.createPromenadeTitle.Size = new System.Drawing.Size(800, 100);
            this.createPromenadeTitle.TabIndex = 43;
            this.createPromenadeTitle.Text = "Prévoir une promenade";
            this.createPromenadeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PromenadeCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createPromenadeTitle);
            this.Controls.Add(this.monthCalendarPromenade);
            this.Name = "PromenadeCreate";
            this.Text = "Promène mon chien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarPromenade;
        private System.Windows.Forms.Label createPromenadeTitle;
    }
}