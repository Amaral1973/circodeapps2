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
    public partial class FormMegaSena : Form
    {
        public FormMegaSena()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            lbNumeros.Items.Clear();
            lbNumeros.BeginUpdate();
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                lbNumeros.Items.Add(random.Next(60));
            }
            lbNumeros.EndUpdate();
        }
    }
}
