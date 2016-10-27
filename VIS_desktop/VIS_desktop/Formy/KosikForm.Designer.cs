namespace VIS_desktop.Formy
{
    partial class KosikForm
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
            this.znicitKosikButton = new System.Windows.Forms.Button();
            this.potvrditButton = new System.Windows.Forms.Button();
            this.obsahKosikuView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // znicitKosikButton
            // 
            this.znicitKosikButton.Location = new System.Drawing.Point(235, 43);
            this.znicitKosikButton.Name = "znicitKosikButton";
            this.znicitKosikButton.Size = new System.Drawing.Size(75, 23);
            this.znicitKosikButton.TabIndex = 1;
            this.znicitKosikButton.Text = "zničit košík";
            this.znicitKosikButton.UseVisualStyleBackColor = true;
            this.znicitKosikButton.Click += new System.EventHandler(this.znicitKosikButton_Click);
            // 
            // potvrditButton
            // 
            this.potvrditButton.Location = new System.Drawing.Point(235, 82);
            this.potvrditButton.Name = "potvrditButton";
            this.potvrditButton.Size = new System.Drawing.Size(75, 23);
            this.potvrditButton.TabIndex = 2;
            this.potvrditButton.Text = "Potvrdit košík";
            this.potvrditButton.UseVisualStyleBackColor = true;
            this.potvrditButton.Click += new System.EventHandler(this.potvrditButton_Click);
            // 
            // obsahKosikuView
            // 
            this.obsahKosikuView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.obsahKosikuView.Location = new System.Drawing.Point(12, 43);
            this.obsahKosikuView.Name = "obsahKosikuView";
            this.obsahKosikuView.Size = new System.Drawing.Size(131, 310);
            this.obsahKosikuView.TabIndex = 3;
            this.obsahKosikuView.UseCompatibleStateImageBehavior = false;
            this.obsahKosikuView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "0";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1";
            // 
            // KosikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 373);
            this.Controls.Add(this.obsahKosikuView);
            this.Controls.Add(this.potvrditButton);
            this.Controls.Add(this.znicitKosikButton);
            this.Name = "KosikForm";
            this.Text = "KosikForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button znicitKosikButton;
        private System.Windows.Forms.Button potvrditButton;
        private System.Windows.Forms.ListView obsahKosikuView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}