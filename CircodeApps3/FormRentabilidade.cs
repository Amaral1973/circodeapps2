using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApps3
{
    public partial class FormRentabilidade : Form
    {
        public FormRentabilidade()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double valor = Convert.ToDouble(txtValor.Text);
            Double rentabilidade = ((0.2/ 100) * valor) * 12;
            Double total = valor + rentabilidade;
            lblValor3.Text = "R$" + valor.ToString("F");
            lblRendimento2.Text = "R$ " + rentabilidade.ToString("F");
            lblTotal2.Text = "R$ " + total.ToString("F");
        }
    }
}