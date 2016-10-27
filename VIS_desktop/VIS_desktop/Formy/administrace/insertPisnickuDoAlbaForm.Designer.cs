namespace VIS_desktop.Formy.administrace
{
    partial class insertPisnickuDoAlbaForm
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
            this.nazevBox = new System.Windows.Forms.TextBox();
            this.delkaBox = new System.Windows.Forms.TextBox();
            this.zanrBox = new System.Windows.Forms.TextBox();
            this.albumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.interpretBox = new System.Windows.Forms.TextBox();
            this.interpretLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazevBox
            // 
            this.nazevBox.Location = new System.Drawing.Point(59, 39);
            this.nazevBox.Name = "nazevBox";
            this.nazevBox.Size = new System.Drawing.Size(100, 20);
            this.nazevBox.TabIndex = 0;
            // 
            // delkaBox
            // 
            this.delkaBox.Location = new System.Drawing.Point(59, 65);
            this.delkaBox.Name = "delkaBox";
            this.delkaBox.Size = new System.Drawing.Size(100, 20);
            this.delkaBox.TabIndex = 1;
            // 
            // zanrBox
            // 
            this.zanrBox.Location = new System.Drawing.Point(59, 91);
            this.zanrBox.Name = "zanrBox";
            this.zanrBox.Size = new System.Drawing.Size(27, 20);
            this.zanrBox.TabIndex = 2;
            // 
            // albumBox
            // 
            this.albumBox.Location = new System.Drawing.Point(59, 120);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(27, 20);
            this.albumBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "nazev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "delka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "id zanru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "id alba";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(154, 159);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "vloz";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // interpretBox
            // 
            this.interpretBox.Location = new System.Drawing.Point(59, 152);
            this.interpretBox.Name = "interpretBox";
            this.interpretBox.Size = new System.Drawing.Size(27, 20);
            this.interpretBox.TabIndex = 9;
            // 
            // interpretLabel
            // 
            this.interpretLabel.AutoSize = true;
            this.interpretLabel.Location = new System.Drawing.Point(6, 159);
            this.interpretLabel.Name = "interpretLabel";
            this.interpretLabel.Size = new System.Drawing.Size(50, 13);
            this.interpretLabel.TabIndex = 10;
            this.interpretLabel.Text = "id interpr.";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(178, 221);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 11;
            // 
            // insertPisnickuDoAlbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.interpretLabel);
            this.Controls.Add(this.interpretBox);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.zanrBox);
            this.Controls.Add(this.delkaBox);
            this.Controls.Add(this.nazevBox);
            this.Name = "insertPisnickuDoAlbaForm";
            this.Text = "insertPisnickuDoAlbaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazevBox;
        private System.Windows.Forms.TextBox delkaBox;
        private System.Windows.Forms.TextBox zanrBox;
        private System.Windows.Forms.TextBox albumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox interpretBox;
        private System.Windows.Forms.Label interpretLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}