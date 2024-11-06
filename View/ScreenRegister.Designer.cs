namespace Barbearia.View
{
    partial class ScreenRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenRegister));
            this.btnRegister = new System.Windows.Forms.Button();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbNameUser = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.Location = new System.Drawing.Point(617, 347);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(68, 24);
            this.btnRegister.TabIndex = 21;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txbTelephone
            // 
            this.txbTelephone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTelephone.BackColor = System.Drawing.Color.White;
            this.txbTelephone.Location = new System.Drawing.Point(528, 236);
            this.txbTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txbTelephone.MaxLength = 20;
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(128, 20);
            this.txbTelephone.TabIndex = 19;
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.Location = new System.Drawing.Point(528, 289);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txbPassword.MaxLength = 20;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(128, 20);
            this.txbPassword.TabIndex = 20;
            // 
            // txbNameUser
            // 
            this.txbNameUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNameUser.BackColor = System.Drawing.Color.White;
            this.txbNameUser.Location = new System.Drawing.Point(277, 236);
            this.txbNameUser.Margin = new System.Windows.Forms.Padding(2);
            this.txbNameUser.MaxLength = 20;
            this.txbNameUser.Name = "txbNameUser";
            this.txbNameUser.Size = new System.Drawing.Size(128, 20);
            this.txbNameUser.TabIndex = 18;
            this.txbNameUser.Tag = "";
            this.txbNameUser.TextChanged += new System.EventHandler(this.txb_nomeusuario_TextChanged);
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbEmail.BackColor = System.Drawing.Color.White;
            this.txbEmail.Location = new System.Drawing.Point(277, 289);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.MaxLength = 20;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(128, 20);
            this.txbEmail.TabIndex = 22;
            this.txbEmail.Tag = "";
            // 
            // ScreenRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 463);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txbNameUser);
            this.Controls.Add(this.txbTelephone);
            this.Controls.Add(this.txbPassword);
            this.DoubleBuffered = true;
            this.Name = "ScreenRegister";
            this.Text = "ScreenCadastre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbNameUser;
        private System.Windows.Forms.TextBox txbEmail;
    }
}