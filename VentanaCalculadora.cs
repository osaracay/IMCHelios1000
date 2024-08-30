using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class VentanaCalculadora : Form
    {
        public VentanaCalculadora()
        {
            InitializeComponent();
            comboUnidadPeso.SelectedItem = "kilogramos";
            comboUnidadAltura.SelectedItem = "centímetros";
            //comboUnidadAltura.Enabled = false;
            //comboUnidadPeso.Enabled = false;
        }

        /*Para validaciones de entrada de texto*/
        private void campoEstatura_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_MouseClick(object sender, MouseEventArgs e)
        {
            int valorEstatura = (int)campoEstatura.Value;
            double valorPeso = (double)campoPeso.Value;
            IMC cal = new IMC(valorEstatura, valorPeso);
            double valorIMC = cal.getIMC();

            string resultado = "el resultado es " + valorIMC.ToString();
            lblResultado.Text = resultado;
            MessageBox.Show("tu IMC es "+valorIMC.ToString());
        }
    }
}
