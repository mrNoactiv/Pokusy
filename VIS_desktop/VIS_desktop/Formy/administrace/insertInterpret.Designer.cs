namespace VIS_desktop.Formy.administrace
{
    partial class insertInterpret
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jmenoBox = new System.Windows.Forms.TextBox();
            this.datumnarozeniBox = new System.Windows.Forms.TextBox();
            this.zemeBox = new System.Windows.Forms.TextBox();
            this.umeleckeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "jmeno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "umeleckeJmeno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "země";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "datum narozeni";
            // 
            // jmenoBox
            // 
            this.jmenoBox.Location = new System.Drawing.Point(102, 19);
            this.jmenoBox.Name = "jmenoBox";
            this.jmenoBox.Size = new System.Drawing.Size(100, 20);
            this.jmenoBox.TabIndex = 4;
            // 
            // datumnarozeniBox
            // 
            this.datumnarozeniBox.Location = new System.Drawing.Point(102, 107);
            this.datumnarozeniBox.Name = "datumnarozeniBox";
            this.datumnarozeniBox.Size = new System.Drawing.Size(100, 20);
            this.datumnarozeniBox.TabIndex = 5;
            // 
            // zemeBox
            // 
            this.zemeBox.Location = new System.Drawing.Point(102, 75);
            this.zemeBox.Name = "zemeBox";
            this.zemeBox.Size = new System.Drawing.Size(100, 20);
            this.zemeBox.TabIndex = 6;
            // 
            // umeleckeBox
            // 
            this.umeleckeBox.Location = new System.Drawing.Point(102, 45);
            this.umeleckeBox.Name = "umeleckeBox";
            this.umeleckeBox.Size = new System.Drawing.Size(100, 20);
            this.umeleckeBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "YYYY-MM-DD";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(139, 172);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 9;
            this.insertButton.Text = "vloz";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(16, 172);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 10;
            // 
            // insertInterpret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.umeleckeBox);
            this.Controls.Add(this.zemeBox);
            this.Controls.Add(this.datumnarozeniBox);
            this.Controls.Add(this.jmenoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insertInterpret";
            this.Text = "insertInterpret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jmenoBox;
        private System.Windows.Forms.TextBox datumnarozeniBox;
        private System.Windows.Forms.TextBox zemeBox;
        private System.Windows.Forms.TextBox umeleckeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label infoLabel;
    }
}