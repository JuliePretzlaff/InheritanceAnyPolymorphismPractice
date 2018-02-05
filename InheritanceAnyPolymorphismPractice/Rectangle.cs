using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnyPolymorphismPractice
{
    public class Rectangle : Shape
    {
        //fields:
        private double area;

        //property:
        public double Area
        {
            get {  return this.area; }
            set { this.area = value; }
        }

        //constructor:
        public Rectangle(double area)
        {
            this.area = area;
        }
    }
}
