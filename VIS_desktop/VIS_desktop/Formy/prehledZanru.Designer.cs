namespace VIS_desktop.Formy
{
    partial class prehledZanru
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
            this.label1 = new System.Windows.Forms.Label();
            this.prehledZanrView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vyberZanrButton = new System.Windows.Forms.Button();
            this.varovaniLabel = new System.Windows.Forms.Label();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.administraceNovyzanrButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prehled žánrů";
            // 
            // prehledZanrView
            // 
            this.prehledZanrView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.prehledZanrView.Location = new System.Drawing.Point(12, 41);
            this.prehledZanrView.Name = "prehledZanrView";
            this.prehledZanrView.Size = new System.Drawing.Size(135, 209);
            this.prehledZanrView.TabIndex = 1;
            this.prehledZanrView.UseCompatibleStateImageBehavior = false;
            this.prehledZanrView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "2";
            // 
            // vyberZanrButton
            // 
            this.vyberZanrButton.Location = new System.Drawing.Point(178, 127);
            this.vyberZanrButton.Name = "vyberZanrButton";
            this.vyberZanrButton.Size = new System.Drawing.Size(75, 27);
            this.vyberZanrButton.TabIndex = 2;
            this.vyberZanrButton.Text = "Vyber žánr";
            this.vyberZanrButton.UseVisualStyleBackColor = true;
            this.vyberZanrButton.Click += new System.EventHandler(this.vyberZanrButton_Click);
            // 
            // varovaniLabel
            // 
            this.varovaniLabel.AutoSize = true;
            this.varovaniLabel.Location = new System.Drawing.Point(178, 194);
            this.varovaniLabel.Name = "varovaniLabel";
            this.varovaniLabel.Size = new System.Drawing.Size(54, 13);
            this.varovaniLabel.TabIndex = 3;
            this.varovaniLabel.Text = "Varování:";
            this.varovaniLabel.Visible = false;
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(178, 222);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(98, 13);
            this.exceptionLabel.TabIndex = 4;
            this.exceptionLabel.Text = "Vyberte číslo žánru";
            this.exceptionLabel.Visible = false;
            // 
            // administraceNovyzanrButton
            // 
            this.administraceNovyzanrButton.ForeColor = System.Drawing.Color.Coral;
            this.administraceNovyzanrButton.Location = new System.Drawing.Point(178, 57);
            this.administraceNovyzanrButton.Name = "administraceNovyzanrButton";
            this.administraceNovyzanrButton.Size = new System.Drawing.Size(75, 23);
            this.administraceNovyzanrButton.TabIndex = 5;
            this.administraceNovyzanrButton.Text = "Nový žánr";
            this.administraceNovyzanrButton.UseVisualStyleBackColor = true;
            this.administraceNovyzanrButton.Visible = false;
            this.administraceNovyzanrButton.Click += new System.EventHandler(this.insertzanrButton_Click);
            // 
            // prehledZanru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 286);
            this.Controls.Add(this.administraceNovyzanrButton);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.varovaniLabel);
            this.Controls.Add(this.vyberZanrButton);
            this.Controls.Add(this.prehledZanrView);
            this.Controls.Add(this.label1);
            this.Name = "prehledZanru";
            this.Text = "prehledZanru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView prehledZanrView;
        private System.Windows.Forms.Button vyberZanrButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label varovaniLabel;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.Button administraceNovyzanrButton;
    }
}