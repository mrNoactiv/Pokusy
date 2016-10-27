namespace VIS_desktop.Formy
{
    partial class prehledPisnicek
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
            this.prehledPisnicekView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.vyberButton = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.varovaniLabel = new System.Windows.Forms.Label();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prehledPisnicekView
            // 
            this.prehledPisnicekView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.prehledPisnicekView.Location = new System.Drawing.Point(38, 45);
            this.prehledPisnicekView.Name = "prehledPisnicekView";
            this.prehledPisnicekView.Size = new System.Drawing.Size(193, 237);
            this.prehledPisnicekView.TabIndex = 0;
            this.prehledPisnicekView.UseCompatibleStateImageBehavior = false;
            this.prehledPisnicekView.View = System.Windows.Forms.View.Details;
            this.prehledPisnicekView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Přehled písniček";
            // 
            // vyberButton
            // 
            this.vyberButton.Location = new System.Drawing.Point(237, 93);
            this.vyberButton.Name = "vyberButton";
            this.vyberButton.Size = new System.Drawing.Size(75, 40);
            this.vyberButton.TabIndex = 2;
            this.vyberButton.Text = "Vybrat písničku";
            this.vyberButton.UseVisualStyleBackColor = true;
            this.vyberButton.Click += new System.EventHandler(this.vyberButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "1";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "2";
            this.columnHeader2.Width = 88;
            // 
            // varovaniLabel
            // 
            this.varovaniLabel.AutoSize = true;
            this.varovaniLabel.Location = new System.Drawing.Point(258, 197);
            this.varovaniLabel.Name = "varovaniLabel";
            this.varovaniLabel.Size = new System.Drawing.Size(54, 13);
            this.varovaniLabel.TabIndex = 3;
            this.varovaniLabel.Text = "Varování:";
            this.varovaniLabel.Visible = false;
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(258, 221);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(112, 13);
            this.exceptionLabel.TabIndex = 4;
            this.exceptionLabel.Text = "Vyberte číslo písničky";
            this.exceptionLabel.Visible = false;
            // 
            // prehledPisnicek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 338);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.varovaniLabel);
            this.Controls.Add(this.vyberButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prehledPisnicekView);
            this.Name = "prehledPisnicek";
            this.Text = "prehledPisnicek";
            this.Load += new System.EventHandler(this.prehledPisnicek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView prehledPisnicekView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vyberButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label varovaniLabel;
        private System.Windows.Forms.Label exceptionLabel;
    }
}