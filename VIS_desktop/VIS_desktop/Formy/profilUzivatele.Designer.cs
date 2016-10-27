namespace VIS_desktop.Formy
{
    partial class profilUzivatele
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
            this.prezdivkaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hesloBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.zobrazButton = new System.Windows.Forms.Button();
            this.knihovnaJePrazdnaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prezdivkaBox
            // 
            this.prezdivkaBox.Location = new System.Drawing.Point(95, 30);
            this.prezdivkaBox.Name = "prezdivkaBox";
            this.prezdivkaBox.Size = new System.Drawing.Size(100, 20);
            this.prezdivkaBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Typ účtu: ";
            // 
            // typLabel
            // 
            this.typLabel.AutoSize = true;
            this.typLabel.Location = new System.Drawing.Point(92, 71);
            this.typLabel.Name = "typLabel";
            this.typLabel.Size = new System.Drawing.Size(35, 13);
            this.typLabel.TabIndex = 2;
            this.typLabel.Text = "label2";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(95, 104);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 3;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(161, 189);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Změnit údaje";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Přezdívka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heslo";
            // 
            // hesloBox
            // 
            this.hesloBox.Location = new System.Drawing.Point(95, 137);
            this.hesloBox.Name = "hesloBox";
            this.hesloBox.Size = new System.Drawing.Size(100, 20);
            this.hesloBox.TabIndex = 8;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 189);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 9;
            // 
            // zobrazButton
            // 
            this.zobrazButton.Location = new System.Drawing.Point(228, 63);
            this.zobrazButton.Name = "zobrazButton";
            this.zobrazButton.Size = new System.Drawing.Size(108, 61);
            this.zobrazButton.TabIndex = 10;
            this.zobrazButton.Text = "zobraz knihovnu";
            this.zobrazButton.UseVisualStyleBackColor = true;
            this.zobrazButton.Click += new System.EventHandler(this.zobrazButton_Click);
            // 
            // knihovnaJePrazdnaLabel
            // 
            this.knihovnaJePrazdnaLabel.AutoSize = true;
            this.knihovnaJePrazdnaLabel.Location = new System.Drawing.Point(19, 236);
            this.knihovnaJePrazdnaLabel.Name = "knihovnaJePrazdnaLabel";
            this.knihovnaJePrazdnaLabel.Size = new System.Drawing.Size(104, 13);
            this.knihovnaJePrazdnaLabel.TabIndex = 11;
            this.knihovnaJePrazdnaLabel.Text = "Knihovna je prázdná";
            this.knihovnaJePrazdnaLabel.Visible = false;
            // 
            // profilUzivatele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 286);
            this.Controls.Add(this.knihovnaJePrazdnaLabel);
            this.Controls.Add(this.zobrazButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.hesloBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.typLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezdivkaBox);
            this.Name = "profilUzivatele";
            this.Text = "profilUzivatele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prezdivkaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label typLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hesloBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button zobrazButton;
        private System.Windows.Forms.Label knihovnaJePrazdnaLabel;
    }
}