namespace VIS_desktop.Formy.administrace
{
    partial class insertZanr
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
            this.label2 = new System.Windows.Forms.Label();
            this.nazevBox = new System.Windows.Forms.TextBox();
            this.popisBox = new System.Windows.Forms.TextBox();
            this.vlozButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nazev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "popis";
            // 
            // nazevBox
            // 
            this.nazevBox.Location = new System.Drawing.Point(62, 42);
            this.nazevBox.Name = "nazevBox";
            this.nazevBox.Size = new System.Drawing.Size(100, 20);
            this.nazevBox.TabIndex = 2;
            // 
            // popisBox
            // 
            this.popisBox.Location = new System.Drawing.Point(62, 77);
            this.popisBox.Name = "popisBox";
            this.popisBox.Size = new System.Drawing.Size(100, 20);
            this.popisBox.TabIndex = 3;
            // 
            // vlozButton
            // 
            this.vlozButton.Location = new System.Drawing.Point(167, 121);
            this.vlozButton.Name = "vlozButton";
            this.vlozButton.Size = new System.Drawing.Size(75, 23);
            this.vlozButton.TabIndex = 4;
            this.vlozButton.Text = "vloz";
            this.vlozButton.UseVisualStyleBackColor = true;
            this.vlozButton.Click += new System.EventHandler(this.vlozButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(21, 144);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 5;
            // 
            // insertZanr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.vlozButton);
            this.Controls.Add(this.popisBox);
            this.Controls.Add(this.nazevBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insertZanr";
            this.Text = "insertZanr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazevBox;
        private System.Windows.Forms.TextBox popisBox;
        private System.Windows.Forms.Button vlozButton;
        private System.Windows.Forms.Label infoLabel;
    }
}