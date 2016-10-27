namespace VIS_desktop.Formy
{
    partial class detailInterpretaForm
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
            this.umeleckeJmenoLabel = new System.Windows.Forms.Label();
            this.jmenoLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.zemeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // umeleckeJmenoLabel
            // 
            this.umeleckeJmenoLabel.AutoSize = true;
            this.umeleckeJmenoLabel.Location = new System.Drawing.Point(27, 35);
            this.umeleckeJmenoLabel.Name = "umeleckeJmenoLabel";
            this.umeleckeJmenoLabel.Size = new System.Drawing.Size(35, 13);
            this.umeleckeJmenoLabel.TabIndex = 0;
            this.umeleckeJmenoLabel.Text = "label1";
            // 
            // jmenoLabel
            // 
            this.jmenoLabel.AutoSize = true;
            this.jmenoLabel.Location = new System.Drawing.Point(30, 63);
            this.jmenoLabel.Name = "jmenoLabel";
            this.jmenoLabel.Size = new System.Drawing.Size(35, 13);
            this.jmenoLabel.TabIndex = 1;
            this.jmenoLabel.Text = "label2";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(30, 102);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(35, 13);
            this.datumLabel.TabIndex = 2;
            this.datumLabel.Text = "label3";
            // 
            // zemeLabel
            // 
            this.zemeLabel.AutoSize = true;
            this.zemeLabel.Location = new System.Drawing.Point(30, 137);
            this.zemeLabel.Name = "zemeLabel";
            this.zemeLabel.Size = new System.Drawing.Size(35, 13);
            this.zemeLabel.TabIndex = 3;
            this.zemeLabel.Text = "label4";
            // 
            // detailInterpretaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.zemeLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.jmenoLabel);
            this.Controls.Add(this.umeleckeJmenoLabel);
            this.Name = "detailInterpretaForm";
            this.Text = "detailInterpretaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label umeleckeJmenoLabel;
        private System.Windows.Forms.Label jmenoLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label zemeLabel;
    }
}