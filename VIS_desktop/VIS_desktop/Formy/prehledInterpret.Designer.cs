namespace VIS_desktop.Formy
{
    partial class prehledInterpret
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
            this.prehledInterpretu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.varovaniLabel = new System.Windows.Forms.Label();
            this.administraceNovzInterpretButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prehledInterpretu
            // 
            this.prehledInterpretu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.prehledInterpretu.Location = new System.Drawing.Point(25, 68);
            this.prehledInterpretu.Name = "prehledInterpretu";
            this.prehledInterpretu.Size = new System.Drawing.Size(166, 202);
            this.prehledInterpretu.TabIndex = 0;
            this.prehledInterpretu.UseCompatibleStateImageBehavior = false;
            this.prehledInterpretu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "1";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Přehled intepretů";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zobrazit detail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.Location = new System.Drawing.Point(234, 255);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(112, 13);
            this.exceptionLabel.TabIndex = 6;
            this.exceptionLabel.Text = "Vyberte číslo písničky";
            this.exceptionLabel.Visible = false;
            // 
            // varovaniLabel
            // 
            this.varovaniLabel.AutoSize = true;
            this.varovaniLabel.Location = new System.Drawing.Point(234, 231);
            this.varovaniLabel.Name = "varovaniLabel";
            this.varovaniLabel.Size = new System.Drawing.Size(54, 13);
            this.varovaniLabel.TabIndex = 5;
            this.varovaniLabel.Text = "Varování:";
            this.varovaniLabel.Visible = false;
            // 
            // administraceNovzInterpretButton
            // 
            this.administraceNovzInterpretButton.ForeColor = System.Drawing.Color.Coral;
            this.administraceNovzInterpretButton.Location = new System.Drawing.Point(289, 49);
            this.administraceNovzInterpretButton.Name = "administraceNovzInterpretButton";
            this.administraceNovzInterpretButton.Size = new System.Drawing.Size(75, 40);
            this.administraceNovzInterpretButton.TabIndex = 7;
            this.administraceNovzInterpretButton.Text = "novy interpret";
            this.administraceNovzInterpretButton.UseVisualStyleBackColor = true;
            this.administraceNovzInterpretButton.Visible = false;
            this.administraceNovzInterpretButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.Coral;
            this.deleteButton.Location = new System.Drawing.Point(289, 96);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Smazat";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(289, 133);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 9;
            // 
            // prehledInterpret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 359);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.administraceNovzInterpretButton);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.varovaniLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prehledInterpretu);
            this.Name = "prehledInterpret";
            this.Text = "prehledInterpret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView prehledInterpretu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.Label varovaniLabel;
        private System.Windows.Forms.Button administraceNovzInterpretButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label infoLabel;
    }
}