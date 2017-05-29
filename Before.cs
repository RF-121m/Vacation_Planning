using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oval
{
    class Circle
    {
        public double r;
        public double v;

        public double area(double s)//тут можно заменить ПИ. замена магического числа символьной константой
        {
            r = Math.Sqrt(s/3.14);
            return r;               // рафакторинг 2. замена переменной вызовом метода
        }
        public double volume(double r)
        {
            v = (4 / 3) * 3.14 * r * r * r; //тут опять же заменить ПИ. и воспользоваться вызовом метода радиуса 
            return v;
        }
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.area(5.5);
            Console.WriteLine("Area of circle is:"+c.r);
            c.volume(1.32);
            Console.WriteLine("Area of shere is:" + c.v);

        }
    }
}
