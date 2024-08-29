using System;
using System.Collections.Generic;
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
        private double peso;

        public double Estatura { get => estatura; set => estatura = value; }
        public double Peso { get => peso; set => peso = value; }

        public IMC() {
        }

        public IMC(double estatura, double peso)
        {
            Estatura = estatura;
            Peso = peso;
            Estatura = estatura;
            Peso = peso;
        }

        public double getIMC()
        {
            return this.estatura * this.peso;
        }
    }
}
