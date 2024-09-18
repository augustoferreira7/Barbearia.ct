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
            this.pnllogin = new System.Windows.Forms.Panel();
            this.btn_ja_cds = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPasswordAgain = new System.Windows.Forms.TextBox();
            this.lblPasswordAgain = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.ckb_cadastro = new System.Windows.Forms.CheckBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senhal = new System.Windows.Forms.Label();
            this.txb_PassowordCd = new System.Windows.Forms.TextBox();
            this.txb_UserCd = new System.Windows.Forms.TextBox();
            this.lbllogin = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.pnllogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnllogin
            // 
            this.pnllogin.BackColor = System.Drawing.Color.Peru;
            this.pnllogin.Controls.Add(this.btn_ja_cds);
            this.pnllogin.Controls.Add(this.panel1);
            this.pnllogin.Controls.Add(this.lbllogin);
            this.pnllogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnllogin.Location = new System.Drawing.Point(207, 43);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(799, 582);
            this.pnllogin.TabIndex = 1;
            // 
            // btn_ja_cds
            // 
            this.btn_ja_cds.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ja_cds.Location = new System.Drawing.Point(655, 529);
            this.btn_ja_cds.Name = "btn_ja_cds";
            this.btn_ja_cds.Size = new System.Drawing.Size(118, 29);
            this.btn_ja_cds.TabIndex = 7;
            this.btn_ja_cds.Text = "Ir Agendar";
            this.btn_ja_cds.UseVisualStyleBackColor = true;
            this.btn_ja_cds.Click += new System.EventHandler(this.btn_ja_cds_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.lbltelefone);
            this.panel1.Controls.Add(this.txttelefone);
            this.panel1.Controls.Add(this.txbEmail);
            this.panel1.Controls.Add(this.txbPasswordAgain);
            this.panel1.Controls.Add(this.lblPasswordAgain);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.ckb_cadastro);
            this.panel1.Controls.Add(this.lbl_usuario);
            this.panel1.Controls.Add(this.lbl_senhal);
            this.panel1.Controls.Add(this.txb_PassowordCd);
            this.panel1.Controls.Add(this.txb_UserCd);
            this.panel1.Location = new System.Drawing.Point(108, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 280);
            this.panel1.TabIndex = 6;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.White;
            this.txbEmail.Location = new System.Drawing.Point(327, 54);
            this.txbEmail.MaxLength = 20;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(237, 26);
            this.txbEmail.TabIndex = 12;
            // 
            // txbPasswordAgain
            // 
            this.txbPasswordAgain.BackColor = System.Drawing.Color.White;
            this.txbPasswordAgain.Location = new System.Drawing.Point(327, 153);
            this.txbPasswordAgain.MaxLength = 20;
            this.txbPasswordAgain.Name = "txbPasswordAgain";
            this.txbPasswordAgain.PasswordChar = '*';
            this.txbPasswordAgain.Size = new System.Drawing.Size(237, 26);
            this.txbPasswordAgain.TabIndex = 11;
            // 
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordAgain.Location = new System.Drawing.Point(322, 105);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(206, 21);
            this.lblPasswordAgain.TabIndex = 10;
            this.lblPasswordAgain.Text = "enter your password again";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(322, 14);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // ckb_cadastro
            // 
            this.ckb_cadastro.AutoSize = true;
            this.ckb_cadastro.Location = new System.Drawing.Point(36, 206);
            this.ckb_cadastro.Name = "ckb_cadastro";
            this.ckb_cadastro.Size = new System.Drawing.Size(149, 23);
            this.ckb_cadastro.TabIndex = 8;
            this.ckb_cadastro.Text = "Quero me cadastrar";
            this.ckb_cadastro.UseVisualStyleBackColor = true;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(31, 14);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(84, 21);
            this.lbl_usuario.TabIndex = 4;
            this.lbl_usuario.Text = "Username";
            // 
            // lbl_senhal
            // 
            this.lbl_senhal.AutoSize = true;
            this.lbl_senhal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhal.Location = new System.Drawing.Point(31, 105);
            this.lbl_senhal.Name = "lbl_senhal";
            this.lbl_senhal.Size = new System.Drawing.Size(166, 21);
            this.lbl_senhal.TabIndex = 5;
            this.lbl_senhal.Text = "Enter your password";
            // 
            // txb_PassowordCd
            // 
            this.txb_PassowordCd.BackColor = System.Drawing.Color.White;
            this.txb_PassowordCd.Location = new System.Drawing.Point(36, 153);
            this.txb_PassowordCd.MaxLength = 20;
            this.txb_PassowordCd.Name = "txb_PassowordCd";
            this.txb_PassowordCd.PasswordChar = '*';
            this.txb_PassowordCd.Size = new System.Drawing.Size(200, 26);
            this.txb_PassowordCd.TabIndex = 2;
            this.txb_PassowordCd.TextChanged += new System.EventHandler(this.txb_senhaCadastro);
            // 
            // txb_UserCd
            // 
            this.txb_UserCd.BackColor = System.Drawing.Color.White;
            this.txb_UserCd.Location = new System.Drawing.Point(36, 54);
            this.txb_UserCd.MaxLength = 20;
            this.txb_UserCd.Name = "txb_UserCd";
            this.txb_UserCd.Size = new System.Drawing.Size(200, 26);
            this.txb_UserCd.TabIndex = 1;
            this.txb_UserCd.Tag = "";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(299, 69);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(151, 31);
            this.lbllogin.TabIndex = 0;
            this.lbllogin.Text = "Sign up here\r\n";
            // 
            // txttelefone
            // 
            this.txttelefone.BackColor = System.Drawing.Color.White;
            this.txttelefone.Location = new System.Drawing.Point(326, 226);
            this.txttelefone.MaxLength = 20;
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(237, 26);
            this.txttelefone.TabIndex = 13;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(323, 192);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(81, 21);
            this.lbltelefone.TabIndex = 14;
            this.lbltelefone.Text = "telephone";
            // 
            // ScreenRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1193, 666);
            this.Controls.Add(this.pnllogin);
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
            this.pnllogin.ResumeLayout(false);
            this.pnllogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnllogin;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txb_UserCd;
        private System.Windows.Forms.Label lbl_senhal;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txb_PassowordCd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ja_cds;
        private System.Windows.Forms.CheckBox ckb_cadastro;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPasswordAgain;
        private System.Windows.Forms.Label lblPasswordAgain;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.TextBox txttelefone;
    }
}

