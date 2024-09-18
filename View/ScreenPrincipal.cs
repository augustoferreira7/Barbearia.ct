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
    public partial class ScreenPrincipal : Form
    {
        public ScreenPrincipal()
        {
            InitializeComponent();
        }

        private void ScreenLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCabelo_Click(object sender, EventArgs e)
        {
            ScreenCorte Corteprincipal = new ScreenCorte();
            Corteprincipal.ShowDialog();
        }

        private void btnBarba_Click(object sender, EventArgs e)
        {
            screenBarba screenBarba = new screenBarba();
            screenBarba.ShowDialog();
        }

        private void btnTintas_Click(object sender, EventArgs e)
        {
            ScreenPintura screenPintura = new ScreenPintura();
            screenPintura.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenEspeciais screenEspeciais = new ScreenEspeciais();
            screenEspeciais.ShowDialog();  
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDecor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPerfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
