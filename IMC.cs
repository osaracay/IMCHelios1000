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

        public double Estatura { get => estatura; set => estatura = value; }
        public double Peso { get => peso; set => peso = value; }

        public IMC(double estatura, double peso)
        {
            Estatura = estatura;
            Peso = peso;
            Estatura = estatura;
            Peso = peso;
            valorIMC = estatura*peso;
            
        }

        public double getIMC()
        {
            return this.valorIMC;
        }
    }
}
