namespace VIS_desktop.Formy.administrace
{
    partial class prehledObjednavekForm
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
            this.prehledView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vybratButton = new System.Windows.Forms.Button();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.varovaniLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prehledView
            // 
            this.prehledView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.prehledView.Location = new System.Drawing.Point(12, 51);
            this.prehledView.Name = "prehledView";
            this.prehledView.Size = new System.Drawing.Size(159, 314);
            this.prehledView.TabIndex = 0;
            this.prehledView.UseCompatibleStateImageBehavior = false;
            this.prehledView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "0";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1";
            this.columnHeader2.Width = 57;
            // 
            // vybratButton
            // 
            this.vybratButton.Location = new System.Drawing.Point(255, 117);
            this.vybratButton.Name = "vybratButton";
            this.vybratButton.Size = new System.Drawing.Size(75, 34);
            this.vybratButton.TabIndex = 1;
            this.vybratButton.Text = "Vybrat";
            this.vybratButton.UseVisualStyleBackColor = true;
            this.vybratButton.Click += new System.EventHandler(this.vybratButton_Click);
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(228, 272);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(127, 13);
            this.exceptionLabel.TabIndex = 6;
            this.exceptionLabel.Text = "Vyberte číslo objednávky";
            this.exceptionLabel.Visible = false;
            // 
            // varovaniLabel
            // 
            this.varovaniLabel.AutoSize = true;
            this.varovaniLabel.Location = new System.Drawing.Point(228, 248);
            this.varovaniLabel.Name = "varovaniLabel";
            this.varovaniLabel.Size = new System.Drawing.Size(54, 13);
            this.varovaniLabel.TabIndex = 5;
            this.varovaniLabel.Text = "Varování:";
            this.varovaniLabel.Visible = false;
            // 
            // prehledObjednavekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 401);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.varovaniLabel);
            this.Controls.Add(this.vybratButton);
            this.Controls.Add(this.prehledView);
            this.Name = "prehledObjednavekForm";
            this.Text = "prehledObjednavekForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView prehledView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button vybratButton;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.Label varovaniLabel;
    }
}