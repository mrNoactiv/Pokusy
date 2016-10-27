namespace VIS_desktop.Formy
{
    partial class detailPisnickaForm
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
            this.nazevLabel = new System.Windows.Forms.Label();
            this.delkaPisnickyLabel = new System.Windows.Forms.Label();
            this.hodnoceniLabel = new System.Windows.Forms.Label();
            this.jmenoInterpretaLabel = new System.Windows.Forms.Label();
            this.albumLabel = new System.Windows.Forms.Label();
            this.zanrLabel = new System.Windows.Forms.Label();
            this.komentareView = new System.Windows.Forms.ListView();
            this.textKomentareBox = new System.Windows.Forms.RichTextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.koupitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nazevLabel
            // 
            this.nazevLabel.AutoSize = true;
            this.nazevLabel.Location = new System.Drawing.Point(32, 32);
            this.nazevLabel.Name = "nazevLabel";
            this.nazevLabel.Size = new System.Drawing.Size(0, 13);
            this.nazevLabel.TabIndex = 0;
            // 
            // delkaPisnickyLabel
            // 
            this.delkaPisnickyLabel.AutoSize = true;
            this.delkaPisnickyLabel.Location = new System.Drawing.Point(110, 32);
            this.delkaPisnickyLabel.Name = "delkaPisnickyLabel";
            this.delkaPisnickyLabel.Size = new System.Drawing.Size(35, 13);
            this.delkaPisnickyLabel.TabIndex = 1;
            this.delkaPisnickyLabel.Text = "label1";
            this.delkaPisnickyLabel.Click += new System.EventHandler(this.delkaPisnickyLabel_Click);
            // 
            // hodnoceniLabel
            // 
            this.hodnoceniLabel.AutoSize = true;
            this.hodnoceniLabel.Location = new System.Drawing.Point(45, 82);
            this.hodnoceniLabel.Name = "hodnoceniLabel";
            this.hodnoceniLabel.Size = new System.Drawing.Size(35, 13);
            this.hodnoceniLabel.TabIndex = 2;
            this.hodnoceniLabel.Text = "label1";
            // 
            // jmenoInterpretaLabel
            // 
            this.jmenoInterpretaLabel.AutoSize = true;
            this.jmenoInterpretaLabel.Location = new System.Drawing.Point(192, 32);
            this.jmenoInterpretaLabel.Name = "jmenoInterpretaLabel";
            this.jmenoInterpretaLabel.Size = new System.Drawing.Size(35, 13);
            this.jmenoInterpretaLabel.TabIndex = 3;
            this.jmenoInterpretaLabel.Text = "label1";
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(192, 72);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(35, 13);
            this.albumLabel.TabIndex = 4;
            this.albumLabel.Text = "label1";
            this.albumLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // zanrLabel
            // 
            this.zanrLabel.AutoSize = true;
            this.zanrLabel.Location = new System.Drawing.Point(192, 107);
            this.zanrLabel.Name = "zanrLabel";
            this.zanrLabel.Size = new System.Drawing.Size(35, 13);
            this.zanrLabel.TabIndex = 5;
            this.zanrLabel.Text = "label2";
            // 
            // komentareView
            // 
            this.komentareView.Location = new System.Drawing.Point(13, 136);
            this.komentareView.Name = "komentareView";
            this.komentareView.Size = new System.Drawing.Size(214, 268);
            this.komentareView.TabIndex = 6;
            this.komentareView.UseCompatibleStateImageBehavior = false;
            this.komentareView.View = System.Windows.Forms.View.Tile;
            // 
            // textKomentareBox
            // 
            this.textKomentareBox.Location = new System.Drawing.Point(3, 27);
            this.textKomentareBox.Name = "textKomentareBox";
            this.textKomentareBox.Size = new System.Drawing.Size(168, 91);
            this.textKomentareBox.TabIndex = 7;
            this.textKomentareBox.Text = "";
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(6, 159);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 8;
            this.insertButton.Text = "Vložit";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zde vložte komentář";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(177, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(81, 94);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hodnocení";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(43, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(43, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(422, 367);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textKomentareBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.insertButton);
            this.panel1.Location = new System.Drawing.Point(233, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 185);
            this.panel1.TabIndex = 12;
            // 
            // koupitButton
            // 
            this.koupitButton.ForeColor = System.Drawing.Color.Crimson;
            this.koupitButton.Location = new System.Drawing.Point(347, 62);
            this.koupitButton.Name = "koupitButton";
            this.koupitButton.Size = new System.Drawing.Size(75, 23);
            this.koupitButton.TabIndex = 13;
            this.koupitButton.Text = "Koupit";
            this.koupitButton.UseVisualStyleBackColor = true;
            this.koupitButton.Visible = false;
            this.koupitButton.Click += new System.EventHandler(this.koupitButton_Click);
            // 
            // detailPisnickaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 436);
            this.Controls.Add(this.koupitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.komentareView);
            this.Controls.Add(this.zanrLabel);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.jmenoInterpretaLabel);
            this.Controls.Add(this.hodnoceniLabel);
            this.Controls.Add(this.delkaPisnickyLabel);
            this.Controls.Add(this.nazevLabel);
            this.Name = "detailPisnickaForm";
            this.Text = "detailPisnickaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazevLabel;
        private System.Windows.Forms.Label delkaPisnickyLabel;
        private System.Windows.Forms.Label hodnoceniLabel;
        private System.Windows.Forms.Label jmenoInterpretaLabel;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label zanrLabel;
        private System.Windows.Forms.ListView komentareView;
        private System.Windows.Forms.RichTextBox textKomentareBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button koupitButton;
    }
}