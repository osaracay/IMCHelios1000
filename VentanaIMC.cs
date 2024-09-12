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
    public partial class VentanaIMC : Form
    {
        private double n;
        public VentanaIMC()
        {
            InitializeComponent();
            comboUnidadPeso.SelectedItem = "kilogramos";
            comboUnidadAltura.SelectedItem = "metros";
            comboUnidadPeso.Enabled = false;
            comboUnidadAltura.Enabled = false;
        }

        private void comboUnidadAltura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void campoEstatura_TextChanged(object sender, EventArgs e)
        {
            validarCampos(campoEstatura, 2.20, 0, lblValidEstatura);
        }

        private void campoPeso_TextChanged(object sender, EventArgs e)
        {
            validarCampos(campoPeso, 500, 0, lblValidPeso);
        }
        private bool validarCampos(TextBox t, double max, double min, Label validLbl)
        {
            /*Este metodo devuelve boolean. De momento funcionaria igual si le cambiara el return a void
             La idea de usar return bool para validarCampos supongo habra sido para ponerlo en un while
            o alguna condicion como lo hice con validar formulario lleno*/
            try
            {
                if (t.Text.Length > 0)
                {
                    n = double.Parse(t.Text);
                    if (n > max || n < min)
                    {
                        validLbl.Text = "Inválido";
                        validLbl.ForeColor = Color.Red;
                        t.Text = "";
                        return false;
                    }
                    else
                    {
                        validLbl.Text = "Válido";
                        validLbl.ForeColor = Color.Green;
                        return true;
                    }
                }
                else
                {
                    validLbl.Text = "Inválido";
                    validLbl.ForeColor = Color.Red;
                    return false;
                }


            }
            catch (Exception ex)
            {
                validLbl.Text = "Inválido";
                validLbl.ForeColor = Color.Red;
                t.Text = "";
                return false;
            }
        }

        private bool ValidarFormularioLleno()
        {
            bool estaturaLleno = campoEstatura.Text.Length > 0;
            bool pesoLleno = campoPeso.Text.Length > 0;
            bool unidadPesoSelect = comboUnidadPeso.Text.Length > 0;
            bool unidadAlturaSelect = comboUnidadAltura.Text.Length > 0;
            if (estaturaLleno && pesoLleno && unidadPesoSelect && unidadAlturaSelect)
            {
                return true;
            }
            lblResultado.Text = "Por favor, llene el Formulario";
            return false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarFormularioLleno())
            {
                double estatura = double.Parse(campoEstatura.Text);
                double peso = double.Parse(campoPeso.Text);


                IMC cal = new IMC();
                double valorIMC = cal.getIMC(estatura, peso);

                string resultado = "Tu IMC es " + Math.Round(valorIMC, 2).ToString() + "\n";
                if (valorIMC > 30.0)
                {
                    resultado += "OBESIDAD";
                }
                else if (valorIMC > 25.0)
                {
                    resultado += "Peso superior al normal";
                }
                else if (valorIMC > 18.5)
                {
                    resultado += "NORMAL";
                }
                else
                {
                    resultado += "Peso inferior al normal";
                }


                lblResultado.Text = resultado;
                MessageBox.Show("Tu IMC es " + Math.Round(valorIMC, 2).ToString());
                //Obtener valor de las unidades de medida a utilizar
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            campoEstatura.Text = string.Empty;
            lblValidEstatura.Text = "-";
            campoPeso.Text = string.Empty;
            lblValidPeso.Text = "-";
            lblResultado.Text = string.Empty;
            campoEstatura.Focus();
        }
    }
}
