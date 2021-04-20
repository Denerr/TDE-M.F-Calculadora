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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double resultado, juros, taxa, tempo;

            juros = Double.Parse(txtJuros.Text);
            taxa = Double.Parse(txtTaxa.Text);
            tempo = Double.Parse(txtTempo.Text);

            taxa = taxa / 100;

            resultado = juros / (taxa * tempo);

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
