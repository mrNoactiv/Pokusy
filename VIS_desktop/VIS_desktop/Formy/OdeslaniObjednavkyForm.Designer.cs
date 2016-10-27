namespace VIS_desktop.Formy
{
    partial class OdeslaniObjednavkyForm
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
            this.prezdivkaLabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.emialHostLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucetBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.varovani1Label = new System.Windows.Forms.Label();
            this.varovani2Label = new System.Windows.Forms.Label();
            this.vytvoreniLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prezdivkaLabel
            // 
            this.prezdivkaLabel.AutoSize = true;
            this.prezdivkaLabel.Location = new System.Drawing.Point(33, 57);
            this.prezdivkaLabel.Name = "prezdivkaLabel";
            this.prezdivkaLabel.Size = new System.Drawing.Size(35, 13);
            this.prezdivkaLabel.TabIndex = 0;
            this.prezdivkaLabel.Text = "label1";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(33, 85);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(35, 13);
            this.emaillabel.TabIndex = 1;
            this.emaillabel.Text = "label2";
            // 
            // emialHostLabel
            // 
            this.emialHostLabel.AutoSize = true;
            this.emialHostLabel.Location = new System.Drawing.Point(12, 111);
            this.emialHostLabel.Name = "emialHostLabel";
            this.emialHostLabel.Size = new System.Drawing.Size(112, 13);
            this.emialHostLabel.TabIndex = 3;
            this.emialHostLabel.Text = "Zde zadejte svůj email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Potvrzení objednávky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Platba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zadejte číslo účtu";
            // 
            // ucetBox
            // 
            this.ucetBox.Location = new System.Drawing.Point(131, 222);
            this.ucetBox.Name = "ucetBox";
            this.ucetBox.Size = new System.Drawing.Size(100, 20);
            this.ucetBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Odeslat ke zpracování";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // varovani1Label
            // 
            this.varovani1Label.AutoSize = true;
            this.varovani1Label.Location = new System.Drawing.Point(131, 322);
            this.varovani1Label.Name = "varovani1Label";
            this.varovani1Label.Size = new System.Drawing.Size(0, 13);
            this.varovani1Label.TabIndex = 10;
            // 
            // varovani2Label
            // 
            this.varovani2Label.AutoSize = true;
            this.varovani2Label.Location = new System.Drawing.Point(131, 344);
            this.varovani2Label.Name = "varovani2Label";
            this.varovani2Label.Size = new System.Drawing.Size(0, 13);
            this.varovani2Label.TabIndex = 11;
            // 
            // vytvoreniLabel
            // 
            this.vytvoreniLabel.AutoSize = true;
            this.vytvoreniLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vytvoreniLabel.Location = new System.Drawing.Point(67, 344);
            this.vytvoreniLabel.Name = "vytvoreniLabel";
            this.vytvoreniLabel.Size = new System.Drawing.Size(164, 20);
            this.vytvoreniLabel.TabIndex = 12;
            this.vytvoreniLabel.Text = "Objednávka vytvořena";
            this.vytvoreniLabel.Visible = false;
            // 
            // OdeslaniObjednavkyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 429);
            this.Controls.Add(this.vytvoreniLabel);
            this.Controls.Add(this.varovani2Label);
            this.Controls.Add(this.varovani1Label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucetBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.emialHostLabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.prezdivkaLabel);
            this.Name = "OdeslaniObjednavkyForm";
            this.Text = "OdeslaniObjednavkyForm";
            this.Load += new System.EventHandler(this.OdeslaniObjednavkyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prezdivkaLabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label emialHostLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ucetBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label varovani1Label;
        private System.Windows.Forms.Label varovani2Label;
        private System.Windows.Forms.Label vytvoreniLabel;
    }
}