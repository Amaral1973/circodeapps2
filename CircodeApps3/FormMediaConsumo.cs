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
    public partial class FormMediaConsumo : Form
    {
        public FormMediaConsumo()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int distancia = Convert.ToInt32(txtDistancia.Text);
            int litros = Convert.ToInt32(txtLitros.Text);
            string tipo = Convert.ToString(cbxCombustivel.SelectedItem);
            int media = distancia / litros;
            if (tipo == "Gasolina")
            {
                lblConsumo.Text = Convert.ToString(media);
                Double total = litros * 5.99;
                lblTotal.Text = Convert.ToString(total);
            }
            else
            {
                lblConsumo.Text = Convert.ToString(media);
                Double total = litros * 4.70;
                lblTotal.Text = Convert.ToString(total);
            }
        }
    }
}
