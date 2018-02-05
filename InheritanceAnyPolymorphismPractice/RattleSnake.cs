using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnyPolymorphismPractice
{
    class RattleSnake : Animal
    {   //field:
        int snakeLength;

        //property:
        public int SnakeLength
        {
            get { return this.snakeLength; }
            set { this.snakeLength = value; }
        }


       //constructor:
        public RattleSnake(int length) : base("reptile", false)
        {
            this.snakeLength = length;
            this.NumberOfLegs = 0;
        }


        //methods:
        public void Rattle()
        {
            Console.WriteLine("\a");
        }
    }
}
