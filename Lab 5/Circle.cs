using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class Circle
    {
        //Creat a field for radius of the circle
        private double _radius;

        //Creat a constructor
        public Circle(double radie) 
        {
            _radius = radie;

        }
        // metode GetArea
        public double GetArea()
        {
            double pi = Math.PI;
            return pi * _radius * _radius;


        }
        //Extra utmaning

        //Creat a metod to calculate perimeter
        public double GetOmkrets() 
        {
            double pi = Math.PI;
            return 2 * pi * _radius;

        }
        //Creat a metod to calculate volume
        public double GetVolym() 
        { 
            double pi = Math.PI;
            return (4.0/3.0 )* pi* _radius* _radius* _radius;
           

        }
    }
}
