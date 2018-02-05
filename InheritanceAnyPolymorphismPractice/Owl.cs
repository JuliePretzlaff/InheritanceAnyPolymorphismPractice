using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnyPolymorphismPractice
{
    class Owl : Animal
    {
        //constructor
        public Owl() : base("bird", true)
        {
            //default constructor
        }

        public Owl(string type)
            {
            this.ClassOfAnimal = type;
            }

        //methods:
        private void Hoot()
        {
            Console.WriteLine("\a");
        }

        //use this method WITH CLW in program:
        //public string FlyCheck(string type)
        //{
        //    if(type == "bird")
        //    {
        //        return "This animal can fly!";
        //    }
        //    else
        //    {
        //        return "This animal is unable to fly.";
        //    


        //use this method with no CWL in program:
            public void FlyCheck(string type)
            {
                if (type == "bird")
                {
                    Console.WriteLine("This animal can fly!");
                }
                else
                {
                    Console.WriteLine("This animal is unable to fly.");
                }

            }

    }
}
