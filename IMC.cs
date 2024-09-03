using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    public enum UnidadPeso{ kilogramos, libras }
    public enum UnidadEstatura { metros, centimetros, pulgadas, pies }
    internal class IMC
    {
        private double estatura;
        private string unidadEstatura;
        private double peso;
        private string unidadPeso = UnidadPeso.kilogramos.ToString();
        private double valorIMC;

        public double getIMC(double estatura, double peso)
        {

            double den = Math.Pow(estatura,2);
            valorIMC = (double)(peso / den);
            return this.valorIMC;
        }
    }
}
