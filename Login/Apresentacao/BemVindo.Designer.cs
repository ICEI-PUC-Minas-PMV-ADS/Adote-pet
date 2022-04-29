namespace Login.Apresentacao
{
    partial class BemVindo
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
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Brush Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBemVindo.Location = new System.Drawing.Point(209, 158);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(352, 98);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem Vindo!";
            this.lblBemVindo.Click += new System.EventHandler(this.label1_Click);
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BemVindo";
            this.Text = "BemVindo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBemVindo;
    }
}