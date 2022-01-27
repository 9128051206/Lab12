using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    static class Сircle
    {
        static public double GetLength(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static public double GetSquare(double radius)
        {
            return Math.PI* radius *radius;
        }
        static public string GetPoint(double x0, double y0, double x, double y, double radius)
        {
            double d = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));
            if (d <= radius)
                return  "Точка принадлежит";
            else
                return "Точка не принадлежит";
        }
    }
}
