using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversionMoneda
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtConvertir.Clear();
            txtColones1.Clear();
            txtDolares.Clear();
            txtColones2.Clear();
            txtEuros.Clear();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            convertir();
        }

        public void convertir()
        {
            double colones, dolares, euros = 0;
            double tipoCambioUSD = 625;
            double tipoCambioEUR = 711;

            colones = Convert.ToDouble(txtConvertir.Text);

            dolares = colones / tipoCambioUSD;
            euros = colones / tipoCambioEUR;

            txtColones1.Text = colones.ToString();
            txtColones2.Text = colones.ToString();
            txtDolares.Text = Math.Round(dolares, 2).ToString();
            txtEuros.Text = Math.Round(euros, 2).ToString();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
