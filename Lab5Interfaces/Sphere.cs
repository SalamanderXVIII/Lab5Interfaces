using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Interfaces
{
    internal class Sphere : IBody
    {
        public double R { get; set; }
        public Sphere(double r)
        {
            R = r;
        }

        public double Area()
        {
            return (4 * Math.PI * R * R);
        }

        public string Print()
        {
            return ($"S = {Area():F2}, V = {Volume():F2}");
        }

        public double Volume()
        {
            return ((4 / 3) * Math.PI * Math.Pow(R, 3));
        }
    }
}
