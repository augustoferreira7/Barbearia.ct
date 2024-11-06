namespace Barbearia
{
    partial class ScreenLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenLogin));
            this.txbsenhadenovo = new System.Windows.Forms.TextBox();
            this.txbPasswordUser = new System.Windows.Forms.TextBox();
            this.txbEmailUser = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbsenhadenovo
            // 
            this.txbsenhadenovo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbsenhadenovo.BackColor = System.Drawing.Color.White;
            this.txbsenhadenovo.Location = new System.Drawing.Point(408, 346);
            this.txbsenhadenovo.Margin = new System.Windows.Forms.Padding(2);
            this.txbsenhadenovo.MaxLength = 20;
            this.txbsenhadenovo.Name = "txbsenhadenovo";
            this.txbsenhadenovo.PasswordChar = '*';
            this.txbsenhadenovo.Size = new System.Drawing.Size(128, 20);
            this.txbsenhadenovo.TabIndex = 15;
            // 
            // txbPasswordUser
            // 
            this.txbPasswordUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPasswordUser.BackColor = System.Drawing.Color.White;
            this.txbPasswordUser.Location = new System.Drawing.Point(408, 283);
            this.txbPasswordUser.Margin = new System.Windows.Forms.Padding(2);
            this.txbPasswordUser.MaxLength = 20;
            this.txbPasswordUser.Name = "txbPasswordUser";
            this.txbPasswordUser.PasswordChar = '*';
            this.txbPasswordUser.Size = new System.Drawing.Size(128, 20);
            this.txbPasswordUser.TabIndex = 16;
            // 
            // txbEmailUser
            // 
            this.txbEmailUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbEmailUser.BackColor = System.Drawing.Color.White;
            this.txbEmailUser.Location = new System.Drawing.Point(408, 222);
            this.txbEmailUser.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmailUser.MaxLength = 20;
            this.txbEmailUser.Name = "txbEmailUser";
            this.txbEmailUser.Size = new System.Drawing.Size(128, 20);
            this.txbEmailUser.TabIndex = 14;
            this.txbEmailUser.Tag = "";
            this.txbEmailUser.TextChanged += new System.EventHandler(this.txb_nomeusuario_TextChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Location = new System.Drawing.Point(507, 396);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(68, 24);
            this.btnEntrar.TabIndex = 17;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.Location = new System.Drawing.Point(315, 396);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(68, 24);
            this.btnRegister.TabIndex = 18;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ScreenLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 510);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txbEmailUser);
            this.Controls.Add(this.txbsenhadenovo);
            this.Controls.Add(this.txbPasswordUser);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScreenLogin";
            this.Text = "ScreenRegisterr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbsenhadenovo;
        private System.Windows.Forms.TextBox txbPasswordUser;
        private System.Windows.Forms.TextBox txbEmailUser;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnRegister;
    }
}