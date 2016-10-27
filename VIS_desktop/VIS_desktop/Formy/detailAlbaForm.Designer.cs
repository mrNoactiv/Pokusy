namespace VIS_desktop.Formy
{
    partial class detailAlbaForm
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
            this.listPisnicekView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazevAlbaLabel = new System.Windows.Forms.Label();
            this.interpretLabel = new System.Windows.Forms.Label();
            this.vyberPisnickuButton = new System.Windows.Forms.Button();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.varovaniLabel = new System.Windows.Forms.Label();
            this.administraceInsertPisnicka = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPisnicekView
            // 
            this.listPisnicekView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listPisnicekView.Location = new System.Drawing.Point(12, 39);
            this.listPisnicekView.Name = "listPisnicekView";
            this.listPisnicekView.Size = new System.Drawing.Size(198, 262);
            this.listPisnicekView.TabIndex = 2;
            this.listPisnicekView.UseCompatibleStateImageBehavior = false;
            this.listPisnicekView.View = System.Windows.Forms.View.Details;
            this.listPisnicekView.SelectedIndexChanged += new System.EventHandler(this.listPisnicekView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "1";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "2";
            this.columnHeader2.Width = 73;
            // 
            // nazevAlbaLabel
            // 
            this.nazevAlbaLabel.AutoSize = true;
            this.nazevAlbaLabel.Location = new System.Drawing.Point(58, 13);
            this.nazevAlbaLabel.Name = "nazevAlbaLabel";
            this.nazevAlbaLabel.Size = new System.Drawing.Size(0, 13);
            this.nazevAlbaLabel.TabIndex = 0;
            // 
            // interpretLabel
            // 
            this.interpretLabel.AutoSize = true;
            this.interpretLabel.Location = new System.Drawing.Point(153, 13);
            this.interpretLabel.Name = "interpretLabel";
            this.interpretLabel.Size = new System.Drawing.Size(35, 13);
            this.interpretLabel.TabIndex = 3;
            this.interpretLabel.Text = "label1";
            // 
            // vyberPisnickuButton
            // 
            this.vyberPisnickuButton.Location = new System.Drawing.Point(300, 139);
            this.vyberPisnickuButton.Name = "vyberPisnickuButton";
            this.vyberPisnickuButton.Size = new System.Drawing.Size(75, 37);
            this.vyberPisnickuButton.TabIndex = 4;
            this.vyberPisnickuButton.Text = "Vybrat písničku";
            this.vyberPisnickuButton.UseVisualStyleBackColor = true;
            this.vyberPisnickuButton.Click += new System.EventHandler(this.vyberPisnickuButton_Click);
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(310, 211);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(103, 13);
            this.exceptionLabel.TabIndex = 5;
            this.exceptionLabel.Text = "Vyberte číselný údaj";
            this.exceptionLabel.Visible = false;
            // 
            // varovaniLabel
            // 
            this.varovaniLabel.AutoSize = true;
            this.varovaniLabel.Location = new System.Drawing.Point(310, 188);
            this.varovaniLabel.Name = "varovaniLabel";
            this.varovaniLabel.Size = new System.Drawing.Size(54, 13);
            this.varovaniLabel.TabIndex = 6;
            this.varovaniLabel.Text = "Varování:";
            this.varovaniLabel.Visible = false;
            // 
            // administraceInsertPisnicka
            // 
            this.administraceInsertPisnicka.ForeColor = System.Drawing.Color.Coral;
            this.administraceInsertPisnicka.Location = new System.Drawing.Point(352, 274);
            this.administraceInsertPisnicka.Name = "administraceInsertPisnicka";
            this.administraceInsertPisnicka.Size = new System.Drawing.Size(75, 44);
            this.administraceInsertPisnicka.TabIndex = 7;
            this.administraceInsertPisnicka.Text = "Nová písnička";
            this.administraceInsertPisnicka.UseVisualStyleBackColor = true;
            this.administraceInsertPisnicka.Visible = false;
            this.administraceInsertPisnicka.Click += new System.EventHandler(this.administraceInsertPisnicka_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.Coral;
            this.deleteButton.Location = new System.Drawing.Point(265, 277);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 41);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Smazat písničku";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(233, 239);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 9;
            // 
            // detailAlbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 330);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.administraceInsertPisnicka);
            this.Controls.Add(this.varovaniLabel);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.vyberPisnickuButton);
            this.Controls.Add(this.interpretLabel);
            this.Controls.Add(this.listPisnicekView);
            this.Controls.Add(this.nazevAlbaLabel);
            this.Name = "detailAlbaForm";
            this.Text = "detailAlbaForm";
            this.Load += new System.EventHandler(this.detailAlbaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listPisnicekView;
        private System.Windows.Forms.Label nazevAlbaLabel;
        private System.Windows.Forms.Label interpretLabel;
        private System.Windows.Forms.Button vyberPisnickuButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.Label varovaniLabel;
        private System.Windows.Forms.Button administraceInsertPisnicka;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label infoLabel;
    }
}