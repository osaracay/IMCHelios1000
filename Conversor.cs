using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    public struct ConversionFactor
    {
        public string nombreCF;
        public double factor;

    }
    internal class Conversor
    {
        ///<summary>
        ///Clase de utilidad para convertir unidades a metros y kilogramos
        ///</summary>
        
        public const double M2FTCF = 3.28084; //meters to ft conversion factor
        public const double FT2MCF = 0.3048; // ft to meters conversion factor;
        public const double KG2LBCF = 2.20462; //kg to lb conversion factor
        public const double LB2KGCF = 0.453592; //lb to kg conversion factor

        /* Se me ocurre para variables: originalValue, conversionFactor, finalValue
         * Donde originalValue es el valor que quiero convertir
         * conversionFactor es el coeficiente por el que multiplico el original para obtener el final
         * Este depende del tipo de conversion a realizar m a ft, kg a lb, y viceversa. 
         */

        /*tendria que distinguirse cada conversionFactor como 
         * metroApieCF, pieAmetroCF, kgAlbCF, lbAkgCF, 
         */

        /*IDEA METODO 
         Metodo estatico que reciba como parametro el numero original, 
        la unidad de medida inicial, y la unidad de medida final, 
        luego que devuelva el numero double final conforme a los parametros que se ingresaron

        Luego de tener dichos conversores, se ajustara la formula de getIMC en la clase IMC, como tambien
        la llamada de los metodos desde el evento btnCalcular_Clicked() en VentanaIMC.cs
        */ 

    }
}
