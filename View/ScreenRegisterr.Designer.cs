namespace Barbearia
{
    partial class ScreenRegisterr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenRegisterr));
            this.txbsenhadenovo = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txb_nomeusuario = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbsenhadenovo
            // 
            this.txbsenhadenovo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbsenhadenovo.BackColor = System.Drawing.Color.White;
            this.txbsenhadenovo.Location = new System.Drawing.Point(408, 346);
            this.txbsenhadenovo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbsenhadenovo.MaxLength = 20;
            this.txbsenhadenovo.Name = "txbsenhadenovo";
            this.txbsenhadenovo.PasswordChar = '*';
            this.txbsenhadenovo.Size = new System.Drawing.Size(128, 20);
            this.txbsenhadenovo.TabIndex = 15;
            // 
            // txbsenha
            // 
            this.txbsenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbsenha.BackColor = System.Drawing.Color.White;
            this.txbsenha.Location = new System.Drawing.Point(408, 283);
            this.txbsenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbsenha.MaxLength = 20;
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.PasswordChar = '*';
            this.txbsenha.Size = new System.Drawing.Size(128, 20);
            this.txbsenha.TabIndex = 16;
            // 
            // txb_nomeusuario
            // 
            this.txb_nomeusuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txb_nomeusuario.BackColor = System.Drawing.Color.White;
            this.txb_nomeusuario.Location = new System.Drawing.Point(408, 222);
            this.txb_nomeusuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_nomeusuario.MaxLength = 20;
            this.txb_nomeusuario.Name = "txb_nomeusuario";
            this.txb_nomeusuario.Size = new System.Drawing.Size(128, 20);
            this.txb_nomeusuario.TabIndex = 14;
            this.txb_nomeusuario.Tag = "";
            this.txb_nomeusuario.TextChanged += new System.EventHandler(this.txb_nomeusuario_TextChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Location = new System.Drawing.Point(507, 396);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(68, 24);
            this.btnEntrar.TabIndex = 17;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // ScreenRegisterr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 510);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txb_nomeusuario);
            this.Controls.Add(this.txbsenhadenovo);
            this.Controls.Add(this.txbsenha);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ScreenRegisterr";
            this.Text = "ScreenRegisterr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbsenhadenovo;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.TextBox txb_nomeusuario;
        private System.Windows.Forms.Button btnEntrar;
    }
}