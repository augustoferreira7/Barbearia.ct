namespace Barbearia
{
    partial class ScreenAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenAgendamento));
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnCabelo = new System.Windows.Forms.Button();
            this.btnBarba = new System.Windows.Forms.Button();
            this.CbbCabelo = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cbbPagamneto = new System.Windows.Forms.ComboBox();
            this.CbbBarba = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtcCalendario = new System.Windows.Forms.MonthCalendar();
            this.Ccbhorario = new System.Windows.Forms.ComboBox();
            this.lblECorte = new System.Windows.Forms.Label();
            this.lblpagamento = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblescolha = new System.Windows.Forms.Label();
            this.BtnSalvarAgendamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Black;
            this.btnPerfil.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.Location = new System.Drawing.Point(18, 122);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(69, 81);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnCabelo
            // 
            this.btnCabelo.BackColor = System.Drawing.Color.Black;
            this.btnCabelo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCabelo.ForeColor = System.Drawing.Color.White;
            this.btnCabelo.Location = new System.Drawing.Point(18, 293);
            this.btnCabelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCabelo.Name = "btnCabelo";
            this.btnCabelo.Size = new System.Drawing.Size(67, 41);
            this.btnCabelo.TabIndex = 4;
            this.btnCabelo.Text = "Cortes";
            this.btnCabelo.UseVisualStyleBackColor = false;
            this.btnCabelo.Click += new System.EventHandler(this.btnCabelo_Click);
            // 
            // btnBarba
            // 
            this.btnBarba.BackColor = System.Drawing.Color.Black;
            this.btnBarba.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarba.ForeColor = System.Drawing.Color.White;
            this.btnBarba.Location = new System.Drawing.Point(18, 348);
            this.btnBarba.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBarba.Name = "btnBarba";
            this.btnBarba.Size = new System.Drawing.Size(67, 41);
            this.btnBarba.TabIndex = 6;
            this.btnBarba.Text = "Barbas";
            this.btnBarba.UseVisualStyleBackColor = false;
            this.btnBarba.Click += new System.EventHandler(this.btnBarba_Click);
            // 
            // CbbCabelo
            // 
            this.CbbCabelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbbCabelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbCabelo.FormattingEnabled = true;
            this.CbbCabelo.Items.AddRange(new object[] {
            "----",
            "Mid Fade",
            "Low Fade",
            "High Fade",
            "Burst Fade",
            "Americano",
            "Mullet"});
            this.CbbCabelo.Location = new System.Drawing.Point(218, 275);
            this.CbbCabelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbCabelo.Name = "CbbCabelo";
            this.CbbCabelo.Size = new System.Drawing.Size(135, 28);
            this.CbbCabelo.TabIndex = 7;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Transparent;
            this.lblDesc.Location = new System.Drawing.Point(329, 145);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(541, 31);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Escolha a data em que deseja marcar um horário";
            // 
            // cbbPagamneto
            // 
            this.cbbPagamneto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbPagamneto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPagamneto.FormattingEnabled = true;
            this.cbbPagamneto.Items.AddRange(new object[] {
            "----",
            "Dinheiro",
            "Pix",
            "Débito",
            "Crédito"});
            this.cbbPagamneto.Location = new System.Drawing.Point(450, 423);
            this.cbbPagamneto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbPagamneto.Name = "cbbPagamneto";
            this.cbbPagamneto.Size = new System.Drawing.Size(135, 28);
            this.cbbPagamneto.TabIndex = 12;
            // 
            // CbbBarba
            // 
            this.CbbBarba.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CbbBarba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbBarba.FormattingEnabled = true;
            this.CbbBarba.Items.AddRange(new object[] {
            "----",
            "Barba Completa",
            "Limpeza",
            "Sobrancela"});
            this.CbbBarba.Location = new System.Drawing.Point(218, 423);
            this.CbbBarba.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbBarba.Name = "CbbBarba";
            this.CbbBarba.Size = new System.Drawing.Size(135, 28);
            this.CbbBarba.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Perfil";
            // 
            // mtcCalendario
            // 
            this.mtcCalendario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtcCalendario.Location = new System.Drawing.Point(750, 249);
            this.mtcCalendario.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mtcCalendario.Name = "mtcCalendario";
            this.mtcCalendario.TabIndex = 16;
            // 
            // Ccbhorario
            // 
            this.Ccbhorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ccbhorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ccbhorario.FormattingEnabled = true;
            this.Ccbhorario.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.Ccbhorario.Location = new System.Drawing.Point(451, 275);
            this.Ccbhorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ccbhorario.Name = "Ccbhorario";
            this.Ccbhorario.Size = new System.Drawing.Size(135, 28);
            this.Ccbhorario.TabIndex = 17;
            // 
            // lblECorte
            // 
            this.lblECorte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblECorte.AutoSize = true;
            this.lblECorte.BackColor = System.Drawing.Color.Transparent;
            this.lblECorte.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECorte.ForeColor = System.Drawing.Color.White;
            this.lblECorte.Location = new System.Drawing.Point(213, 223);
            this.lblECorte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblECorte.Name = "lblECorte";
            this.lblECorte.Size = new System.Drawing.Size(178, 25);
            this.lblECorte.TabIndex = 18;
            this.lblECorte.Text = "Escolha seu Corte:";
            // 
            // lblpagamento
            // 
            this.lblpagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpagamento.AutoSize = true;
            this.lblpagamento.BackColor = System.Drawing.Color.Transparent;
            this.lblpagamento.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagamento.ForeColor = System.Drawing.Color.White;
            this.lblpagamento.Location = new System.Drawing.Point(446, 373);
            this.lblpagamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpagamento.Name = "lblpagamento";
            this.lblpagamento.Size = new System.Drawing.Size(213, 25);
            this.lblpagamento.TabIndex = 19;
            this.lblpagamento.Text = "Método de pagamento:";
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(445, 223);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(199, 25);
            this.lblHorario.TabIndex = 20;
            this.lblHorario.Text = "Escolha um Horário :";
            // 
            // lblescolha
            // 
            this.lblescolha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblescolha.AutoSize = true;
            this.lblescolha.BackColor = System.Drawing.Color.Transparent;
            this.lblescolha.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescolha.ForeColor = System.Drawing.Color.White;
            this.lblescolha.Location = new System.Drawing.Point(213, 373);
            this.lblescolha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblescolha.Name = "lblescolha";
            this.lblescolha.Size = new System.Drawing.Size(205, 25);
            this.lblescolha.TabIndex = 21;
            this.lblescolha.Text = "Quer fazer algo mais?";
            // 
            // BtnSalvarAgendamento
            // 
            this.BtnSalvarAgendamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSalvarAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarAgendamento.Location = new System.Drawing.Point(895, 462);
            this.BtnSalvarAgendamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSalvarAgendamento.Name = "BtnSalvarAgendamento";
            this.BtnSalvarAgendamento.Size = new System.Drawing.Size(82, 30);
            this.BtnSalvarAgendamento.TabIndex = 22;
            this.BtnSalvarAgendamento.Text = "Concluir";
            this.BtnSalvarAgendamento.UseVisualStyleBackColor = true;
            this.BtnSalvarAgendamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScreenAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 552);
            this.Controls.Add(this.BtnSalvarAgendamento);
            this.Controls.Add(this.lblescolha);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblpagamento);
            this.Controls.Add(this.lblECorte);
            this.Controls.Add(this.Ccbhorario);
            this.Controls.Add(this.mtcCalendario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbbBarba);
            this.Controls.Add(this.cbbPagamneto);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.CbbCabelo);
            this.Controls.Add(this.btnBarba);
            this.Controls.Add(this.btnCabelo);
            this.Controls.Add(this.btnPerfil);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ScreenAgendamento";
            this.Text = "ScreenAgendamento";
            this.Load += new System.EventHandler(this.ScreenAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnCabelo;
        private System.Windows.Forms.Button btnBarba;
        private System.Windows.Forms.ComboBox CbbCabelo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.ComboBox cbbPagamneto;
        private System.Windows.Forms.ComboBox CbbBarba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mtcCalendario;
        private System.Windows.Forms.ComboBox Ccbhorario;
        private System.Windows.Forms.Label lblECorte;
        private System.Windows.Forms.Label lblpagamento;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblescolha;
        private System.Windows.Forms.Button BtnSalvarAgendamento;
    }
}