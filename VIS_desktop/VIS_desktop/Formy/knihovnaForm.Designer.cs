namespace VIS_desktop.Formy
{
    partial class knihovnaForm
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
            this.prehledKnihovnyView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idUzivateleLabel = new System.Windows.Forms.Label();
            this.idKnihovnyLabel = new System.Windows.Forms.Label();
            this.detailButton = new System.Windows.Forms.Button();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.varovaniLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prehledKnihovnyView
            // 
            this.prehledKnihovnyView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.prehledKnihovnyView.Location = new System.Drawing.Point(21, 54);
            this.prehledKnihovnyView.Name = "prehledKnihovnyView";
            this.prehledKnihovnyView.Size = new System.Drawing.Size(148, 174);
            this.prehledKnihovnyView.TabIndex = 0;
            this.prehledKnihovnyView.UseCompatibleStateImageBehavior = false;
            this.prehledKnihovnyView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "1";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "2";
            this.columnHeader2.Width = 81;
            // 
            // idUzivateleLabel
            // 
            this.idUzivateleLabel.AutoSize = true;
            this.idUzivateleLabel.Location = new System.Drawing.Point(74, 13);
            this.idUzivateleLabel.Name = "idUzivateleLabel";
            this.idUzivateleLabel.Size = new System.Drawing.Size(35, 13);
            this.idUzivateleLabel.TabIndex = 1;
            this.idUzivateleLabel.Text = "label1";
            // 
            // idKnihovnyLabel
            // 
            this.idKnihovnyLabel.AutoSize = true;
            this.idKnihovnyLabel.Location = new System.Drawing.Point(213, 13);
            this.idKnihovnyLabel.Name = "idKnihovnyLabel";
            this.idKnihovnyLabel.Size = new System.Drawing.Size(35, 13);
            this.idKnihovnyLabel.TabIndex = 2;
            this.idKnihovnyLabel.Text = "label2";
            // 
            // detailButton
            // 
            this.detailButton.Location = new System.Drawing.Point(197, 54);
            this.detailButton.Name = "detailButton";
            this.detailButton.Size = new System.Drawing.Size(75, 37);
            this.detailButton.TabIndex = 3;
            this.detailButton.Text = "Detail písničky";
            this.detailButton.UseVisualStyleBackColor = true;
            this.detailButton.Click += new System.EventHandler(this.detailButton_Click);
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(194, 239);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(112, 13);
            this.exceptionLabel.TabIndex = 6;
            this.exceptionLabel.Text = "Vyberte číslo písničky";
            this.exceptionLabel.Visible = false;
            // 
            // varovaniLabel
            // 
            this.varovaniLabel.AutoSize = true;
            this.varovaniLabel.Location = new System.Drawing.Point(194, 215);
            this.varovaniLabel.Name = "varovaniLabel";
            this.varovaniLabel.Size = new System.Drawing.Size(54, 13);
            this.varovaniLabel.TabIndex = 5;
            this.varovaniLabel.Text = "Varování:";
            this.varovaniLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id uživatele: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id knihovny: ";
            // 
            // knihovnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.varovaniLabel);
            this.Controls.Add(this.detailButton);
            this.Controls.Add(this.idKnihovnyLabel);
            this.Controls.Add(this.idUzivateleLabel);
            this.Controls.Add(this.prehledKnihovnyView);
            this.Name = "knihovnaForm";
            this.Text = "knihovnaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView prehledKnihovnyView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label idUzivateleLabel;
        private System.Windows.Forms.Label idKnihovnyLabel;
        private System.Windows.Forms.Button detailButton;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.Label varovaniLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}