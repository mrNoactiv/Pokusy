namespace VIS_desktop
{
    partial class mainForm
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
            this.albaButton = new System.Windows.Forms.Button();
            this.pisnickyButton = new System.Windows.Forms.Button();
            this.prehledZanruButton = new System.Windows.Forms.Button();
            this.profilButton = new System.Windows.Forms.Button();
            this.prehledInterpretuButton = new System.Windows.Forms.Button();
            this.registraceButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hesloBox = new System.Windows.Forms.TextBox();
            this.prezdivkaBox = new System.Windows.Forms.TextBox();
            this.prihlasenyUzivatelLabel = new System.Windows.Forms.Label();
            this.odhlasitButton = new System.Windows.Forms.Button();
            this.kosikButton = new System.Windows.Forms.Button();
            this.kosikLabel = new System.Windows.Forms.Label();
            this.objednavkyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // albaButton
            // 
            this.albaButton.Location = new System.Drawing.Point(1, 12);
            this.albaButton.Name = "albaButton";
            this.albaButton.Size = new System.Drawing.Size(75, 23);
            this.albaButton.TabIndex = 2;
            this.albaButton.Text = "Přehled Alb";
            this.albaButton.UseVisualStyleBackColor = true;
            this.albaButton.Click += new System.EventHandler(this.albaButton_Click);
            // 
            // pisnickyButton
            // 
            this.pisnickyButton.Location = new System.Drawing.Point(1, 166);
            this.pisnickyButton.Name = "pisnickyButton";
            this.pisnickyButton.Size = new System.Drawing.Size(99, 23);
            this.pisnickyButton.TabIndex = 3;
            this.pisnickyButton.Text = "Přehled písniček";
            this.pisnickyButton.UseVisualStyleBackColor = true;
            this.pisnickyButton.Click += new System.EventHandler(this.pisnickyButton_Click);
            // 
            // prehledZanruButton
            // 
            this.prehledZanruButton.Location = new System.Drawing.Point(1, 67);
            this.prehledZanruButton.Name = "prehledZanruButton";
            this.prehledZanruButton.Size = new System.Drawing.Size(85, 23);
            this.prehledZanruButton.TabIndex = 4;
            this.prehledZanruButton.Text = "Přehled žánrů";
            this.prehledZanruButton.UseVisualStyleBackColor = true;
            this.prehledZanruButton.Click += new System.EventHandler(this.prehledZanruButton_Click);
            // 
            // profilButton
            // 
            this.profilButton.Location = new System.Drawing.Point(96, 5);
            this.profilButton.Name = "profilButton";
            this.profilButton.Size = new System.Drawing.Size(152, 37);
            this.profilButton.TabIndex = 5;
            this.profilButton.Text = "Zobrazit profil";
            this.profilButton.UseVisualStyleBackColor = true;
            this.profilButton.Visible = false;
            this.profilButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // prehledInterpretuButton
            // 
            this.prehledInterpretuButton.Location = new System.Drawing.Point(1, 109);
            this.prehledInterpretuButton.Name = "prehledInterpretuButton";
            this.prehledInterpretuButton.Size = new System.Drawing.Size(99, 23);
            this.prehledInterpretuButton.TabIndex = 6;
            this.prehledInterpretuButton.Text = "Přehled interpretů";
            this.prehledInterpretuButton.UseVisualStyleBackColor = true;
            this.prehledInterpretuButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // registraceButton
            // 
            this.registraceButton.Location = new System.Drawing.Point(399, 137);
            this.registraceButton.Name = "registraceButton";
            this.registraceButton.Size = new System.Drawing.Size(75, 23);
            this.registraceButton.TabIndex = 7;
            this.registraceButton.Text = "Registrovat";
            this.registraceButton.UseVisualStyleBackColor = true;
            this.registraceButton.Click += new System.EventHandler(this.registraceButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(80, 77);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Přihlásit";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hesloBox);
            this.panel1.Controls.Add(this.prezdivkaBox);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Location = new System.Drawing.Point(298, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 107);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "heslo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Přezdívka";
            // 
            // hesloBox
            // 
            this.hesloBox.Location = new System.Drawing.Point(67, 39);
            this.hesloBox.Name = "hesloBox";
            this.hesloBox.Size = new System.Drawing.Size(100, 20);
            this.hesloBox.TabIndex = 10;
            // 
            // prezdivkaBox
            // 
            this.prezdivkaBox.Location = new System.Drawing.Point(67, 14);
            this.prezdivkaBox.Name = "prezdivkaBox";
            this.prezdivkaBox.Size = new System.Drawing.Size(100, 20);
            this.prezdivkaBox.TabIndex = 9;
            // 
            // prihlasenyUzivatelLabel
            // 
            this.prihlasenyUzivatelLabel.AutoSize = true;
            this.prihlasenyUzivatelLabel.Location = new System.Drawing.Point(147, 79);
            this.prihlasenyUzivatelLabel.Name = "prihlasenyUzivatelLabel";
            this.prihlasenyUzivatelLabel.Size = new System.Drawing.Size(0, 13);
            this.prihlasenyUzivatelLabel.TabIndex = 10;
            // 
            // odhlasitButton
            // 
            this.odhlasitButton.Location = new System.Drawing.Point(141, 53);
            this.odhlasitButton.Name = "odhlasitButton";
            this.odhlasitButton.Size = new System.Drawing.Size(75, 23);
            this.odhlasitButton.TabIndex = 11;
            this.odhlasitButton.Text = "Odhlásit";
            this.odhlasitButton.UseVisualStyleBackColor = true;
            this.odhlasitButton.Visible = false;
            this.odhlasitButton.Click += new System.EventHandler(this.odhlasitButton_Click);
            // 
            // kosikButton
            // 
            this.kosikButton.Location = new System.Drawing.Point(367, 201);
            this.kosikButton.Name = "kosikButton";
            this.kosikButton.Size = new System.Drawing.Size(88, 65);
            this.kosikButton.TabIndex = 12;
            this.kosikButton.Text = "Zobrazit košík";
            this.kosikButton.UseVisualStyleBackColor = true;
            this.kosikButton.Visible = false;
            this.kosikButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // kosikLabel
            // 
            this.kosikLabel.AutoSize = true;
            this.kosikLabel.Location = new System.Drawing.Point(367, 291);
            this.kosikLabel.Name = "kosikLabel";
            this.kosikLabel.Size = new System.Drawing.Size(0, 13);
            this.kosikLabel.TabIndex = 13;
            // 
            // objednavkyButton
            // 
            this.objednavkyButton.Location = new System.Drawing.Point(1, 327);
            this.objednavkyButton.Name = "objednavkyButton";
            this.objednavkyButton.Size = new System.Drawing.Size(236, 45);
            this.objednavkyButton.TabIndex = 14;
            this.objednavkyButton.Text = "Zobrazit objednávky";
            this.objednavkyButton.UseVisualStyleBackColor = true;
            this.objednavkyButton.Visible = false;
            this.objednavkyButton.Click += new System.EventHandler(this.objednavkyButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 384);
            this.Controls.Add(this.objednavkyButton);
            this.Controls.Add(this.kosikLabel);
            this.Controls.Add(this.kosikButton);
            this.Controls.Add(this.odhlasitButton);
            this.Controls.Add(this.prihlasenyUzivatelLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registraceButton);
            this.Controls.Add(this.prehledInterpretuButton);
            this.Controls.Add(this.profilButton);
            this.Controls.Add(this.prehledZanruButton);
            this.Controls.Add(this.pisnickyButton);
            this.Controls.Add(this.albaButton);
            this.Name = "mainForm";
            this.Text = "Hlavnní stránka";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button albaButton;
        private System.Windows.Forms.Button pisnickyButton;
        private System.Windows.Forms.Button prehledZanruButton;
        private System.Windows.Forms.Button profilButton;
        private System.Windows.Forms.Button prehledInterpretuButton;
        private System.Windows.Forms.Button registraceButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hesloBox;
        private System.Windows.Forms.TextBox prezdivkaBox;
        private System.Windows.Forms.Label prihlasenyUzivatelLabel;
        private System.Windows.Forms.Button odhlasitButton;
        private System.Windows.Forms.Button kosikButton;
        private System.Windows.Forms.Label kosikLabel;
        private System.Windows.Forms.Button objednavkyButton;
    }
}

