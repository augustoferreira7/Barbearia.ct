using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barbearia
{
    public partial class ScreenBooking : Form
    {
        public ScreenBooking()
        {
            InitializeComponent();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            ScreenLogin tela_Registro = new ScreenLogin();

            this.Visible = false;

            tela_Registro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Corte: " + CbbCabelo.Text +
                "\nAdicional: " + CbbBarba.Text+
                "\nHorário: " + Ccbhorario.Text+
                "\nPagamento: " + cbbPagamneto.Text);
        }

        private void btnCabelo_Click(object sender, EventArgs e)
        {


            ScreenCortes tela_cortes1 = new ScreenCortes();

            this.Visible = false;

            tela_cortes1.ShowDialog();
        }

        private void btnBarba_Click(object sender, EventArgs e)
        {
            ScreenBarba tela_barba1 = new ScreenBarba();

            this.Visible = false;

            tela_barba1.ShowDialog();
        }

        private void ScreenAgendamento_Load(object sender, EventArgs e)
        {

        }
    }
}
