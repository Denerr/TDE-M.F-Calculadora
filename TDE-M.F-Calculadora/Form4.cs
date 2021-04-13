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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public double resultado, juros, capital, tempo;

        private void btnResultado_Click(object sender, EventArgs e)
        {

            juros = Double.Parse(txtJuros.Text);
            capital = Double.Parse(txtCapital.Text);
            tempo = Double.Parse(txtTempo.Text);

            resultado = capital * tempo / juros; 

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPercent_MouseEnter(object sender, EventArgs e)
        {
            btnPercent.ForeColor = Color.FromArgb(230, 57, 70);
            btnPercent.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
        }

        private void btnPercent_MouseLeave(object sender, EventArgs e)
        {
            btnPercent.ForeColor = Color.White;
            btnPercent.FlatAppearance.BorderColor = Color.White;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            resultado = resultado / 100;
            txtResultado.Text = resultado.ToString() + "%";
        }
    }
}
