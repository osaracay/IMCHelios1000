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



        private void crearCF()
        {   
            ConversionFactor metroApieCF = new ConversionFactor();
        }

    }
}
