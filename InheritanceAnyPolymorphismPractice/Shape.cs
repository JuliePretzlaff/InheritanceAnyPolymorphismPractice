using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnyPolymorphismPractice
{
    class Shape
    {
        //fields:
        private int sides;


        //properties:
        public int Sides
        {
            get { return this.sides; }
            set { this.sides = value; }
        }

        //constructors:
        public Shape()
        {
            //default constructor
        }
       
        public Shape(int sides)
        {
            this.sides = Sides;
        }

        //methods

    }
}
