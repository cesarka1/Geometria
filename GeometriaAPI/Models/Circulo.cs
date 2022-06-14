using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using 

namespace GeometriaAPI.Models
{
    public class Circulo : Geometria, IGeometriaFormula
    {
        double raio;
        double pi = 3.1415;

        public dobule CirculoCalcularArea(string[] m)
        {
            try
            {
                raio = double.Parse(m[0]);
            }
            catch (System.Exception)
            {
                
               return -1;
            }
            return raio*raio*pi;

        }

        public dobule CirculoCalcular(string[] m)
        {
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