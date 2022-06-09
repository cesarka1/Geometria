using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometriaAPI.Models
{
    public interface IGeometriaFormula
    {
        double CalcularArea(string[] m);
        double CalcularPerimetro(string[] m);
    }
}