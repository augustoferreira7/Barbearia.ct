namespace Barbearia
{
    partial class ScreenRegister
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenRegister));
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPasswordAgain = new System.Windows.Forms.TextBox();
            this.txb_UserCd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.White;
            this.txbEmail.Location = new System.Drawing.Point(605, 367);
            this.txbEmail.MaxLength = 20;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(169, 30);
            this.txbEmail.TabIndex = 12;
            // 
            // txbPasswordAgain
            // 
            this.txbPasswordAgain.BackColor = System.Drawing.Color.White;
            this.txbPasswordAgain.Location = new System.Drawing.Point(605, 444);
            this.txbPasswordAgain.MaxLength = 20;
            this.txbPasswordAgain.Name = "txbPasswordAgain";
            this.txbPasswordAgain.Size = new System.Drawing.Size(169, 30);
            this.txbPasswordAgain.TabIndex = 11;
            // 
            // txb_UserCd
            // 
            this.txb_UserCd.BackColor = System.Drawing.Color.White;
            this.txb_UserCd.Location = new System.Drawing.Point(605, 287);
            this.txb_UserCd.MaxLength = 20;
            this.txb_UserCd.Name = "txb_UserCd";
            this.txb_UserCd.Size = new System.Drawing.Size(169, 30);
            this.txb_UserCd.TabIndex = 1;
            this.txb_UserCd.Tag = "";
            // 
            // ScreenRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1359, 666);
            this.Controls.Add(this.txb_UserCd);
            this.Controls.Add(this.txbPasswordAgain);
            this.Controls.Add(this.txbEmail);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScreenRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "ok";
            this.Text = "Faça seu login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_UserCd;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPasswordAgain;
    }
}

