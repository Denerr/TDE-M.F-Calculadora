using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDE_M.F_Calculadora
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double resultado, juros, capital, taxa;

            juros = Double.Parse(txtJuros.Text);
            capital = Double.Parse(txtCapital.Text);
            taxa = Double.Parse(txtTaxa.Text);

            taxa = taxa / 100;
            //aux = capital * taxa;

            resultado = juros / (capital * taxa);

            txtResultado.Text = resultado.ToString();
        }

        private void btnResultado_MouseEnter(object sender, EventArgs e)
        {
            btnResultado.ForeColor = Color.FromArgb(230, 57, 70);
            btnResultado.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
        }

        private void btnResultado_MouseLeave(object sender, EventArgs e)
        {
            btnResultado.ForeColor = Color.White;
            btnResultado.FlatAppearance.BorderColor = Color.White;
        }
    }
}
