using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            double length =  Сircle.GetLength(radius);    
            double square = Сircle.GetSquare(radius);
            string point = Сircle.GetPoint(x0, y0, x, y,radius);
            Console.WriteLine($"{length} \n{square} \n{point}");
            Console.ReadKey();
        }

    }
}
