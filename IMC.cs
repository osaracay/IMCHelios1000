using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class IMC
    {


        private double valorIMC;


      /*IDEA METODO 


      Luego de tener dichos conversores, se ajustara la formula de getIMC en la clase IMC, como tambien
      la llamada de los metodos desde el evento btnCalcular_Clicked() en VentanaIMC.cs
      */
        public double getIMC(double estatura, UnidadAltura unidadAltura, double peso, UnidadPeso unidadPeso)
        {
            switch (unidadAltura)
            {
                case UnidadAltura.m:
                    //caso si el peso es kg
                    //caso si el peso lb
                    switch (unidadPeso)
                    {
                        case UnidadPeso.lb:
                            valorIMC = Math.Round((double)(Conversor.convertirPeso(peso,UnidadPeso.kg) / (Math.Pow(estatura, 2))),2); // SE convierte peso de lb a kg para calcular kg/m al cuadrado
                            break;
                        case UnidadPeso.kg:Math.Round((double)(peso / (Math.Pow(estatura, 2))), 2);
                            valorIMC = Math.Round((double)(peso / (Math.Pow(estatura, 2))),2);
                            break;
                    }
                break;
                case UnidadAltura.pie:

                    double estaturaMetros = Conversor.convertirEstatura(estatura,UnidadAltura.m);
                    switch (unidadPeso)
                    {
                        case UnidadPeso.lb:
                            valorIMC = Math.Round((double)(Conversor.convertirPeso(peso, UnidadPeso.kg) / (Math.Pow(estaturaMetros, 2))),2); // AJUSTAR
                            break;
                        case UnidadPeso.kg:
                            Math.Round((double)(peso / (Math.Pow(estatura, 2))));
                            valorIMC = Math.Round((double)(peso / (Math.Pow(estaturaMetros, 2))),2); // AJUSTAR
                            break;
                    }
                break;

            }

            
            /*Formula con unidades de medida kg/m^2 */
            
            //valorIMC = Math.Round((double)(peso / den),2);
            return this.valorIMC;
        }
    }
}
