namespace VIS_desktop.Formy
{
    partial class detailZanruForm
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
            this.nazevLabel = new System.Windows.Forms.Label();
            this.popisLabel = new System.Windows.Forms.Label();
            this.listPisnicekView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vyberPisnickuButton = new System.Windows.Forms.Button();
            this.varovaniLabel = new System.Windows.Forms.Label();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazevLabel
            // 
            this.nazevLabel.AutoSize = true;
            this.nazevLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazevLabel.Location = new System.Drawing.Point(21, 9);
            this.nazevLabel.Name = "nazevLabel";
            this.nazevLabel.Size = new System.Drawing.Size(70, 25);
            this.nazevLabel.TabIndex = 0;
            this.nazevLabel.Text = "label1";
            // 
            // popisLabel
            // 
            this.popisLabel.AutoSize = true;
            this.popisLabel.Location = new System.Drawing.Point(181, 21);
            this.popisLabel.Name = "popisLabel";
            this.popisLabel.Size = new System.Drawing.Size(35, 13);
            this.popisLabel.TabIndex = 1;
            this.popisLabel.Text = "label1";
            // 
            // listPisnicekView
            // 
            this.listPisnicekView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listPisnicekView.Location = new System.Drawing.Point(12, 54);
            this.listPisnicekView.Name = "listPisnicekView";
            this.listPisnicekView.Size = new System.Drawing.Size(184, 244);
            this.listPisnicekView.TabIndex = 2;
            this.listPisnicekView.UseCompatibleStateImageBehavior = false;
            this.listPisnicekView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "1";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "2";
            this.columnHeader2.Width = 77;
            // 
            // vyberPisnickuButton
            // 
            this.vyberPisnickuButton.Location = new System.Drawing.Point(254, 152);
            this.vyberPisnickuButton.Name = "vyberPisnickuButton";
            this.vyberPisnickuButton.Size = new System.Drawing.Size(75, 40);
            this.vyberPisnickuButton.TabIndex = 3;
            this.vyberPisnickuButton.Text = "Vybrat písničku";
            this.vyberPisnickuButton.UseVisualStyleBackColor = true;
            this.vyberPisnickuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // varovaniLabel
            // 
            this.varovaniLabel.AutoSize = true;
            this.varovaniLabel.Location = new System.Drawing.Point(254, 243);
            this.varovaniLabel.Name = "varovaniLabel";
            this.varovaniLabel.Size = new System.Drawing.Size(35, 13);
            this.varovaniLabel.TabIndex = 4;
            this.varovaniLabel.Text = "label1";
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(257, 284);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(35, 13);
            this.exceptionLabel.TabIndex = 5;
            this.exceptionLabel.Text = "label1";
            // 
            // detailZanruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 327);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.varovaniLabel);
            this.Controls.Add(this.vyberPisnickuButton);
            this.Controls.Add(this.listPisnicekView);
            this.Controls.Add(this.popisLabel);
            this.Controls.Add(this.nazevLabel);
            this.Name = "detailZanruForm";
            this.Text = "detailZanruForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazevLabel;
        private System.Windows.Forms.Label popisLabel;
        private System.Windows.Forms.ListView listPisnicekView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button vyberPisnickuButton;
        private System.Windows.Forms.Label varovaniLabel;
        private System.Windows.Forms.Label exceptionLabel;
    }
}