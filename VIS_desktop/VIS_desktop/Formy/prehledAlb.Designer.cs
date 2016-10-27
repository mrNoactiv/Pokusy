namespace VIS_desktop.Formy
{
    partial class prehledAlb
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
            this.prehledAlbView = new System.Windows.Forms.ListView();
            this.vyberAlbumButton = new System.Windows.Forms.Button();
            this.nadpisPřehledLabel = new System.Windows.Forms.Label();
            this.insertAlbum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prehledAlbView
            // 
            this.prehledAlbView.Location = new System.Drawing.Point(12, 52);
            this.prehledAlbView.Name = "prehledAlbView";
            this.prehledAlbView.Size = new System.Drawing.Size(121, 156);
            this.prehledAlbView.TabIndex = 0;
            this.prehledAlbView.UseCompatibleStateImageBehavior = false;
            this.prehledAlbView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // vyberAlbumButton
            // 
            this.vyberAlbumButton.Location = new System.Drawing.Point(179, 134);
            this.vyberAlbumButton.Name = "vyberAlbumButton";
            this.vyberAlbumButton.Size = new System.Drawing.Size(75, 43);
            this.vyberAlbumButton.TabIndex = 1;
            this.vyberAlbumButton.Text = "Vybrat album";
            this.vyberAlbumButton.UseVisualStyleBackColor = true;
            this.vyberAlbumButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nadpisPřehledLabel
            // 
            this.nadpisPřehledLabel.AutoSize = true;
            this.nadpisPřehledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpisPřehledLabel.Location = new System.Drawing.Point(86, 9);
            this.nadpisPřehledLabel.Name = "nadpisPřehledLabel";
            this.nadpisPřehledLabel.Size = new System.Drawing.Size(107, 24);
            this.nadpisPřehledLabel.TabIndex = 2;
            this.nadpisPřehledLabel.Text = "Přehled alb";
            // 
            // insertAlbum
            // 
            this.insertAlbum.ForeColor = System.Drawing.Color.Coral;
            this.insertAlbum.Location = new System.Drawing.Point(179, 52);
            this.insertAlbum.Name = "insertAlbum";
            this.insertAlbum.Size = new System.Drawing.Size(75, 23);
            this.insertAlbum.TabIndex = 3;
            this.insertAlbum.Text = "Nové album";
            this.insertAlbum.UseVisualStyleBackColor = true;
            this.insertAlbum.Visible = false;
            this.insertAlbum.Click += new System.EventHandler(this.insertAlbum_Click);
            // 
            // prehledAlb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.insertAlbum);
            this.Controls.Add(this.nadpisPřehledLabel);
            this.Controls.Add(this.vyberAlbumButton);
            this.Controls.Add(this.prehledAlbView);
            this.Name = "prehledAlb";
            this.Text = "prehledAlb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView prehledAlbView;
        private System.Windows.Forms.Button vyberAlbumButton;
        private System.Windows.Forms.Label nadpisPřehledLabel;
        private System.Windows.Forms.Button insertAlbum;
    }
}