using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
    //正方形の一片の長さ
    int side = 5; 

    //正方形の面積
    int areaSquare = side * side;

    //円の面積
    double areaCircle = (side / 2) * (side / 2) * 3.14;

    //青色部の面積
    double areaBlue = areaSquare - areaCircle;

    Console.WriteLine(areaBlue);
    Console.ReadLine();

        }
    }
}