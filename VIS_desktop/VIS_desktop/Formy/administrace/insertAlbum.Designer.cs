namespace VIS_desktop.Formy.administrace
{
    partial class insertAlbum
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
            this.insertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazevBox = new System.Windows.Forms.TextBox();
            this.datumBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(168, 162);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "vloz";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum vydani";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "nazev";
            // 
            // nazevBox
            // 
            this.nazevBox.Location = new System.Drawing.Point(91, 65);
            this.nazevBox.Name = "nazevBox";
            this.nazevBox.Size = new System.Drawing.Size(100, 20);
            this.nazevBox.TabIndex = 3;
            // 
            // datumBox
            // 
            this.datumBox.Location = new System.Drawing.Point(91, 95);
            this.datumBox.Name = "datumBox";
            this.datumBox.Size = new System.Drawing.Size(100, 20);
            this.datumBox.TabIndex = 4;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 171);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 5;
            // 
            // insertAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.datumBox);
            this.Controls.Add(this.nazevBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertButton);
            this.Name = "insertAlbum";
            this.Text = "insertAlbum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazevBox;
        private System.Windows.Forms.TextBox datumBox;
        private System.Windows.Forms.Label infoLabel;
    }
}