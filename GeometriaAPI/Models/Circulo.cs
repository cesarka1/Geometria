using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometriaAPI.Models
{
    public class Circulo : Geometria, IGeometriaFormula
    {
        
        public double CalcularArea(string[] m)
        {
            double raio;
            double pi = 3.14;

            try
            {
                raio = double.Parse(m[0]);
            }
            catch (System.Exception)
            {
                
               return -1;
            }
            return pi;

        }

        public double CalcularPerimetro(string[] m)
        {
            double raio;
            double pi = 3.1415;

            try
            {
                 raio = double.Parse(m[0]);
            }
            catch (System.Exception)
            {
                 return -1;
            }
            return raio*2*pi;
        }
    }
}