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
        //derived class can't inherit constructors from base class.  however, constructors of base
        //class can be accessed using "base" keyword.
        public Rectangle(double area) : base(4) //sides be set to four, since that's the parameter for the base class (can choose which constructor you're referencing)
        {
            this.area = area;
        }
    }
}
