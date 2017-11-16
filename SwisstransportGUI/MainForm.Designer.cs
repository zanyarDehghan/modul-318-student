namespace SwisstransportGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl12 = new SwisstransportGUI.UserControl1();
            this.userControl11 = new SwisstransportGUI.UserControl1();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(20, 18);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(1165, 675);
            this.userControl12.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 10);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1165, 675);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 697);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl12;
        private UserControl1 userControl11;
    }
}

