using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometriaAPI.Models
{
    public class Triangulo : Geometria, IGeometriaFormula{
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
            return (basev*alturav)/2;
        }
        public double CalcularPerimetro(string[] m)
        {
            double ladov;
            
            try
            {
                ladov = double.Parse(m[0]);
                
            }
            catch (System.Exception)
            {
                return -1;
                
            }
            return ladov*3;
        }


    }
        
    
}