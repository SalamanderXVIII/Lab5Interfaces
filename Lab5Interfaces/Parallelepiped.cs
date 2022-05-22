using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Interfaces
{
    internal class Parallelepiped : IBody
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Parallelepiped(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double Area()
        {
            return 2 * (A * B + B * C + A * C);
        }

        public string Print()
        {
            return ($"S = {Area():F2}, V = {Volume():F2}");
        }

        public double Volume()
        {
            return (A * B * C);
        }
    }
}
