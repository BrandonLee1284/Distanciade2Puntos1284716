using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distanciade2Puntos1284716
{
    public class Distancias
    {
        public static double CalcularDistancia(Punto p1, Punto p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
