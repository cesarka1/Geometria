namespace GeometriaAPI.Models
{
    public class Trapezio : Geometria, IGeometriaFormula
    {
         public double CalcularArea(string[] m)
         {
            double basemenor;
            double basemaior;
            double altura;

            try
            {
                basemenor = double.Parse(m[0]);
                basemaior = double.Parse(m[1]);
                altura = double.Parse(m[2]);
            }
            catch (System.Exception)
            {
                
                return -1;
            }
            return ((basemaior+basemenor)*altura)/2;
         }

         public double CalcularPerimetro(string[] m)
         {
            double lado1;
            double lado2;
            double lado3;
            double lado4;

            try
            {
                lado1 = double.Parse(m[0]);
                lado2 = double.Parse(m[1]);
                lado3 = double.Parse(m[2]);
                lado4 = double.Parse(m[3]);
            }
            catch (System.Exception)
            {
                return -1;
            }
            return (lado1+lado2+lado3+lado4);
         }
    }
}