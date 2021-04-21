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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            //Declaração de Variaveis
            double resultado, capital, taxa, tempo;

            capital = Double.Parse(txtCapital.Text);
            taxa = Double.Parse(txtTaxa.Text);
            tempo = Double.Parse(txtTempo.Text);

            //Area de calculo
            taxa = taxa / 100;

            resultado = capital * taxa * tempo;

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
