namespace Barbearia.View
{
    partial class ScreenCadastre
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txb_nomeusuario = new System.Windows.Forms.TextBox();
            this.txbsenhadenovo = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Location = new System.Drawing.Point(416, 300);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(68, 24);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txb_nomeusuario
            // 
            this.txb_nomeusuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txb_nomeusuario.BackColor = System.Drawing.Color.White;
            this.txb_nomeusuario.Location = new System.Drawing.Point(317, 126);
            this.txb_nomeusuario.Margin = new System.Windows.Forms.Padding(2);
            this.txb_nomeusuario.MaxLength = 20;
            this.txb_nomeusuario.Name = "txb_nomeusuario";
            this.txb_nomeusuario.Size = new System.Drawing.Size(128, 20);
            this.txb_nomeusuario.TabIndex = 18;
            this.txb_nomeusuario.Tag = "";
            // 
            // txbsenhadenovo
            // 
            this.txbsenhadenovo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbsenhadenovo.BackColor = System.Drawing.Color.White;
            this.txbsenhadenovo.Location = new System.Drawing.Point(317, 250);
            this.txbsenhadenovo.Margin = new System.Windows.Forms.Padding(2);
            this.txbsenhadenovo.MaxLength = 20;
            this.txbsenhadenovo.Name = "txbsenhadenovo";
            this.txbsenhadenovo.PasswordChar = '*';
            this.txbsenhadenovo.Size = new System.Drawing.Size(128, 20);
            this.txbsenhadenovo.TabIndex = 19;
            // 
            // txbsenha
            // 
            this.txbsenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbsenha.BackColor = System.Drawing.Color.White;
            this.txbsenha.Location = new System.Drawing.Point(317, 187);
            this.txbsenha.Margin = new System.Windows.Forms.Padding(2);
            this.txbsenha.MaxLength = 20;
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.PasswordChar = '*';
            this.txbsenha.Size = new System.Drawing.Size(128, 20);
            this.txbsenha.TabIndex = 20;
            // 
            // ScreenCadastre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txb_nomeusuario);
            this.Controls.Add(this.txbsenhadenovo);
            this.Controls.Add(this.txbsenha);
            this.Name = "ScreenCadastre";
            this.Text = "ScreenCadastre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txb_nomeusuario;
        private System.Windows.Forms.TextBox txbsenhadenovo;
        private System.Windows.Forms.TextBox txbsenha;
    }
}