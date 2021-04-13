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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string title = "Fechar Janela";
            string message = "Tem Certeza que Deseja Fechar Essa Janela?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                //Faz algo diferente
            }

            
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
            btnClose.BackColor = Color.FromArgb(230, 57, 70);

            btnClose.FlatAppearance.BorderColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(230, 57, 70);
            btnClose.BackColor = Color.FromArgb(0, 8, 20);

            btnClose.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
        }

        private void btnJuros_MouseEnter(object sender, EventArgs e)
        {
            btnJuros.ForeColor = Color.FromArgb(230, 57, 70);
            btnJuros.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
        }

        private void btnJuros_MouseLeave(object sender, EventArgs e)
        {
            btnJuros.ForeColor = Color.White;
            btnJuros.FlatAppearance.BorderColor = Color.White;
        }

        private void btnCapital_MouseEnter(object sender, EventArgs e)
        {
            btnCapital.ForeColor = Color.FromArgb(230, 57, 70);
            btnCapital.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
        }

        private void btnCapital_MouseLeave(object sender, EventArgs e)
        {
            btnCapital.ForeColor = Color.White;
            btnCapital.FlatAppearance.BorderColor = Color.White;
        }

        private void btnTaxa_MouseEnter(object sender, EventArgs e)
        {
            btnTaxa.ForeColor = Color.FromArgb(230, 57, 70);
            btnTaxa.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
        }

        private void btnTaxa_MouseLeave(object sender, EventArgs e)
        {
            btnTaxa.ForeColor = Color.White;
            btnTaxa.FlatAppearance.BorderColor = Color.White;
        }

        private void btnTempo_MouseEnter(object sender, EventArgs e)
        {
            btnTempo.ForeColor = Color.FromArgb(230, 57, 70);
            btnTempo.FlatAppearance.BorderColor = Color.FromArgb(230, 57, 70);
        }

        private void btnTempo_MouseLeave(object sender, EventArgs e)
        {
            btnTempo.ForeColor = Color.White;
            btnTempo.FlatAppearance.BorderColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Para de clicar ai, bobão");
        }

        private void btnJuros_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnCapital_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnTaxa_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void btnTempo_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
