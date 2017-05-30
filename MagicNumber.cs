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
        const double PI_constant=3.14;///////РЕФАКТОРИНГ 1

        public void area(double s)//тут можно заменить ПИ. замена магического числа символьной константой
        {
            r = Math.Sqrt(s/PI_constant);
            //return r;               // рафакторинг 2. замена переменной вызовом метода
        }
        double Radius
        {
            get
            {return r;}

            set 
            { r = value; }
        }
        public double volume(double r)
        {
            v = (4 / 3) * PI_constant * Radius*Radius*Radius; //тут опять же заменить ПИ. и воспользоваться вызовом метода радиуса 
            return v;
        }
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.area(-5);
            Console.WriteLine("Area of circle is:"+c.r);
            c.volume(1.32);
            Console.WriteLine("Area of sphere is:" + c.v);
            Console.ReadLine();

        }
    }
}
