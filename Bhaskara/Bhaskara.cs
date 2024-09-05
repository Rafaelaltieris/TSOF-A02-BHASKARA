using System;

namespace BhaskaraApp
{
    public class Bhaskara
    {
        public static double[] CalcularRaizes(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return new double[0]; // Retorna um array vazio se não houver raízes reais
            }

            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b + sqrtDelta) / (2 * a);
            double x2 = (-b - sqrtDelta) / (2 * a);

            return new double[] { x1, x2 };
        }
    }
}