namespace Barbearia
{
    partial class screenadd
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
            this.pnlNomeAdd = new System.Windows.Forms.Panel();
            this.PnlPasswordAdd = new System.Windows.Forms.Panel();
            this.PnlEmailAdd = new System.Windows.Forms.Panel();
            this.PnlTelephoneAdd = new System.Windows.Forms.Panel();
            this.TxbNomeAdd = new System.Windows.Forms.TextBox();
            this.TxbEmailAdd = new System.Windows.Forms.TextBox();
            this.TxbTelephoneAdd = new System.Windows.Forms.TextBox();
            this.TxbPasswordAdd = new System.Windows.Forms.TextBox();
            this.LtvAdd = new System.Windows.Forms.ListView();
            this.BtnInsertAdd = new System.Windows.Forms.Button();
            this.BtnDeleteAdd = new System.Windows.Forms.Button();
            this.BtnUpadeteAdd = new System.Windows.Forms.Button();
            this.BtnClearAdd = new System.Windows.Forms.Button();
            this.LblNameAdd = new System.Windows.Forms.Label();
            this.LblEmailAdd = new System.Windows.Forms.Label();
            this.LblTelephoneAdd = new System.Windows.Forms.Label();
            this.LblPasswordAdd = new System.Windows.Forms.Label();
            this.ChNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChSenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblCodCli = new System.Windows.Forms.Label();
            this.PnlCodCli = new System.Windows.Forms.Panel();
            this.TxbCodCli = new System.Windows.Forms.TextBox();
            this.ChCodCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlNomeAdd.SuspendLayout();
            this.PnlPasswordAdd.SuspendLayout();
            this.PnlEmailAdd.SuspendLayout();
            this.PnlTelephoneAdd.SuspendLayout();
            this.PnlCodCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNomeAdd
            // 
            this.pnlNomeAdd.Controls.Add(this.TxbNomeAdd);
            this.pnlNomeAdd.Location = new System.Drawing.Point(596, 126);
            this.pnlNomeAdd.Name = "pnlNomeAdd";
            this.pnlNomeAdd.Size = new System.Drawing.Size(370, 58);
            this.pnlNomeAdd.TabIndex = 0;
            // 
            // PnlPasswordAdd
            // 
            this.PnlPasswordAdd.Controls.Add(this.TxbPasswordAdd);
            this.PnlPasswordAdd.Location = new System.Drawing.Point(1033, 334);
            this.PnlPasswordAdd.Name = "PnlPasswordAdd";
            this.PnlPasswordAdd.Size = new System.Drawing.Size(370, 60);
            this.PnlPasswordAdd.TabIndex = 1;
            // 
            // PnlEmailAdd
            // 
            this.PnlEmailAdd.Controls.Add(this.TxbEmailAdd);
            this.PnlEmailAdd.Location = new System.Drawing.Point(1033, 126);
            this.PnlEmailAdd.Name = "PnlEmailAdd";
            this.PnlEmailAdd.Size = new System.Drawing.Size(370, 58);
            this.PnlEmailAdd.TabIndex = 1;
            // 
            // PnlTelephoneAdd
            // 
            this.PnlTelephoneAdd.Controls.Add(this.TxbTelephoneAdd);
            this.PnlTelephoneAdd.Location = new System.Drawing.Point(596, 334);
            this.PnlTelephoneAdd.Name = "PnlTelephoneAdd";
            this.PnlTelephoneAdd.Size = new System.Drawing.Size(370, 63);
            this.PnlTelephoneAdd.TabIndex = 1;
            // 
            // TxbNomeAdd
            // 
            this.TxbNomeAdd.Location = new System.Drawing.Point(0, 36);
            this.TxbNomeAdd.Name = "TxbNomeAdd";
            this.TxbNomeAdd.Size = new System.Drawing.Size(370, 22);
            this.TxbNomeAdd.TabIndex = 0;
            // 
            // TxbEmailAdd
            // 
            this.TxbEmailAdd.Location = new System.Drawing.Point(3, 33);
            this.TxbEmailAdd.Name = "TxbEmailAdd";
            this.TxbEmailAdd.Size = new System.Drawing.Size(370, 22);
            this.TxbEmailAdd.TabIndex = 1;
            // 
            // TxbTelephoneAdd
            // 
            this.TxbTelephoneAdd.Location = new System.Drawing.Point(0, 38);
            this.TxbTelephoneAdd.Name = "TxbTelephoneAdd";
            this.TxbTelephoneAdd.Size = new System.Drawing.Size(370, 22);
            this.TxbTelephoneAdd.TabIndex = 2;
            // 
            // TxbPasswordAdd
            // 
            this.TxbPasswordAdd.Location = new System.Drawing.Point(3, 38);
            this.TxbPasswordAdd.Name = "TxbPasswordAdd";
            this.TxbPasswordAdd.Size = new System.Drawing.Size(370, 22);
            this.TxbPasswordAdd.TabIndex = 1;
            // 
            // LtvAdd
            // 
            this.LtvAdd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChNome,
            this.ChEmail,
            this.ChTelefone,
            this.ChSenha,
            this.ChCodCli});
            this.LtvAdd.HideSelection = false;
            this.LtvAdd.Location = new System.Drawing.Point(42, 467);
            this.LtvAdd.Name = "LtvAdd";
            this.LtvAdd.Size = new System.Drawing.Size(524, 183);
            this.LtvAdd.TabIndex = 2;
            this.LtvAdd.UseCompatibleStateImageBehavior = false;
            this.LtvAdd.View = System.Windows.Forms.View.Details;
            this.LtvAdd.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LtvAdd_MouseDoubleClick);
            // 
            // BtnInsertAdd
            // 
            this.BtnInsertAdd.Location = new System.Drawing.Point(65, 681);
            this.BtnInsertAdd.Name = "BtnInsertAdd";
            this.BtnInsertAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertAdd.TabIndex = 3;
            this.BtnInsertAdd.Text = "Insert";
            this.BtnInsertAdd.UseVisualStyleBackColor = true;
            this.BtnInsertAdd.Click += new System.EventHandler(this.BtnInsertAdd_Click);
            // 
            // BtnDeleteAdd
            // 
            this.BtnDeleteAdd.Location = new System.Drawing.Point(196, 681);
            this.BtnDeleteAdd.Name = "BtnDeleteAdd";
            this.BtnDeleteAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteAdd.TabIndex = 4;
            this.BtnDeleteAdd.Text = "Deletar";
            this.BtnDeleteAdd.UseVisualStyleBackColor = true;
            this.BtnDeleteAdd.Click += new System.EventHandler(this.BtnDeleteAdd_Click);
            // 
            // BtnUpadeteAdd
            // 
            this.BtnUpadeteAdd.Location = new System.Drawing.Point(341, 681);
            this.BtnUpadeteAdd.Name = "BtnUpadeteAdd";
            this.BtnUpadeteAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnUpadeteAdd.TabIndex = 5;
            this.BtnUpadeteAdd.Text = "Atualizar";
            this.BtnUpadeteAdd.UseVisualStyleBackColor = true;
            this.BtnUpadeteAdd.Click += new System.EventHandler(this.BtnUpadeteAdd_Click);
            // 
            // BtnClearAdd
            // 
            this.BtnClearAdd.Location = new System.Drawing.Point(491, 681);
            this.BtnClearAdd.Name = "BtnClearAdd";
            this.BtnClearAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnClearAdd.TabIndex = 6;
            this.BtnClearAdd.Text = "Limpar";
            this.BtnClearAdd.UseVisualStyleBackColor = true;
            // 
            // LblNameAdd
            // 
            this.LblNameAdd.AutoSize = true;
            this.LblNameAdd.Location = new System.Drawing.Point(599, 107);
            this.LblNameAdd.Name = "LblNameAdd";
            this.LblNameAdd.Size = new System.Drawing.Size(44, 16);
            this.LblNameAdd.TabIndex = 7;
            this.LblNameAdd.Text = "Nome";
            // 
            // LblEmailAdd
            // 
            this.LblEmailAdd.AutoSize = true;
            this.LblEmailAdd.Location = new System.Drawing.Point(1033, 107);
            this.LblEmailAdd.Name = "LblEmailAdd";
            this.LblEmailAdd.Size = new System.Drawing.Size(41, 16);
            this.LblEmailAdd.TabIndex = 8;
            this.LblEmailAdd.Text = "Email";
            // 
            // LblTelephoneAdd
            // 
            this.LblTelephoneAdd.AutoSize = true;
            this.LblTelephoneAdd.Location = new System.Drawing.Point(593, 315);
            this.LblTelephoneAdd.Name = "LblTelephoneAdd";
            this.LblTelephoneAdd.Size = new System.Drawing.Size(61, 16);
            this.LblTelephoneAdd.TabIndex = 9;
            this.LblTelephoneAdd.Text = "Telefone";
            // 
            // LblPasswordAdd
            // 
            this.LblPasswordAdd.AutoSize = true;
            this.LblPasswordAdd.Location = new System.Drawing.Point(1033, 315);
            this.LblPasswordAdd.Name = "LblPasswordAdd";
            this.LblPasswordAdd.Size = new System.Drawing.Size(46, 16);
            this.LblPasswordAdd.TabIndex = 10;
            this.LblPasswordAdd.Text = "Senha";
            // 
            // ChNome
            // 
            this.ChNome.Text = "Nome";
            // 
            // ChEmail
            // 
            this.ChEmail.Text = "Email";
            this.ChEmail.Width = 152;
            // 
            // ChTelefone
            // 
            this.ChTelefone.Text = "Telefone";
            this.ChTelefone.Width = 111;
            // 
            // ChSenha
            // 
            this.ChSenha.Text = "Senha";
            this.ChSenha.Width = 145;
            // 
            // LblCodCli
            // 
            this.LblCodCli.AutoSize = true;
            this.LblCodCli.Location = new System.Drawing.Point(96, 107);
            this.LblCodCli.Name = "LblCodCli";
            this.LblCodCli.Size = new System.Drawing.Size(51, 16);
            this.LblCodCli.TabIndex = 12;
            this.LblCodCli.Text = "Código";
            // 
            // PnlCodCli
            // 
            this.PnlCodCli.Controls.Add(this.TxbCodCli);
            this.PnlCodCli.Location = new System.Drawing.Point(93, 126);
            this.PnlCodCli.Name = "PnlCodCli";
            this.PnlCodCli.Size = new System.Drawing.Size(370, 58);
            this.PnlCodCli.TabIndex = 11;
            // 
            // TxbCodCli
            // 
            this.TxbCodCli.Location = new System.Drawing.Point(0, 36);
            this.TxbCodCli.Name = "TxbCodCli";
            this.TxbCodCli.Size = new System.Drawing.Size(370, 22);
            this.TxbCodCli.TabIndex = 0;
            // 
            // ChCodCli
            // 
            this.ChCodCli.Text = "Código";
            // 
            // screenadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 798);
            this.Controls.Add(this.LblCodCli);
            this.Controls.Add(this.PnlCodCli);
            this.Controls.Add(this.LblPasswordAdd);
            this.Controls.Add(this.LblTelephoneAdd);
            this.Controls.Add(this.LblEmailAdd);
            this.Controls.Add(this.LblNameAdd);
            this.Controls.Add(this.BtnClearAdd);
            this.Controls.Add(this.BtnUpadeteAdd);
            this.Controls.Add(this.BtnDeleteAdd);
            this.Controls.Add(this.BtnInsertAdd);
            this.Controls.Add(this.LtvAdd);
            this.Controls.Add(this.PnlPasswordAdd);
            this.Controls.Add(this.PnlEmailAdd);
            this.Controls.Add(this.PnlTelephoneAdd);
            this.Controls.Add(this.pnlNomeAdd);
            this.Name = "screenadd";
            this.Text = "screenadd";
            this.pnlNomeAdd.ResumeLayout(false);
            this.pnlNomeAdd.PerformLayout();
            this.PnlPasswordAdd.ResumeLayout(false);
            this.PnlPasswordAdd.PerformLayout();
            this.PnlEmailAdd.ResumeLayout(false);
            this.PnlEmailAdd.PerformLayout();
            this.PnlTelephoneAdd.ResumeLayout(false);
            this.PnlTelephoneAdd.PerformLayout();
            this.PnlCodCli.ResumeLayout(false);
            this.PnlCodCli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNomeAdd;
        private System.Windows.Forms.TextBox TxbNomeAdd;
        private System.Windows.Forms.Panel PnlPasswordAdd;
        private System.Windows.Forms.TextBox TxbPasswordAdd;
        private System.Windows.Forms.Panel PnlEmailAdd;
        private System.Windows.Forms.TextBox TxbEmailAdd;
        private System.Windows.Forms.Panel PnlTelephoneAdd;
        private System.Windows.Forms.TextBox TxbTelephoneAdd;
        private System.Windows.Forms.ListView LtvAdd;
        private System.Windows.Forms.Button BtnInsertAdd;
        private System.Windows.Forms.Button BtnDeleteAdd;
        private System.Windows.Forms.Button BtnUpadeteAdd;
        private System.Windows.Forms.Button BtnClearAdd;
        private System.Windows.Forms.Label LblNameAdd;
        private System.Windows.Forms.Label LblEmailAdd;
        private System.Windows.Forms.Label LblTelephoneAdd;
        private System.Windows.Forms.Label LblPasswordAdd;
        private System.Windows.Forms.ColumnHeader ChNome;
        private System.Windows.Forms.ColumnHeader ChEmail;
        private System.Windows.Forms.ColumnHeader ChTelefone;
        private System.Windows.Forms.ColumnHeader ChSenha;
        private System.Windows.Forms.Label LblCodCli;
        private System.Windows.Forms.Panel PnlCodCli;
        private System.Windows.Forms.TextBox TxbCodCli;
        private System.Windows.Forms.ColumnHeader ChCodCli;
    }
}