using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometriaAPI.Models
{
    public class Retangulo : Geometria, IGeometriaFormula
    {
        public double CalcularArea(string[] m)
        {
            double basev;
            double alturav;
            try
            {
                basev = double.Parse(m[0]);
                alturav = double.Parse(m[1]);
            }
            catch (System.Exception)
            {
                return -1;
            }
            return basev*alturav;
        }
        public double CalcularPerimetro(string[] m)
        {
            double basev;
            double alturav;
            try
            {
                basev = double.Parse(m[0]);
                alturav = double.Parse(m[1]);
            }
            catch (System.Exception)
            {
                return -1;
            }
            return (basev*2) + (alturav*2);
        }   
    }
}