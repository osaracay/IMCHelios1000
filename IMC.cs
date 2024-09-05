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
            /*Formula con unidades de medida kg/m^2 */
            double den = Math.Pow(estatura,2);
            valorIMC = Math.Round((double)(peso / den),2);
            return this.valorIMC;
        }
    }
}
