using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade01.View
{
    public partial class AtvSoma : Form
    {
        public AtvSoma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Soma_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt16(txb_numeroum.Text);
            int valor2 = Convert.ToInt16(txb_numerodois.Text);
            int soma = valor1 + valor2;

            lbl_resultado.Text = soma.ToString();
        }
    }
}
