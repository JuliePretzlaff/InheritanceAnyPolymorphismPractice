using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnyPolymorphismPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //snake tests:
            Console.WriteLine("\nSnake Tests: ");
            RattleSnake snakeOne= new RattleSnake(22);
            snakeOne.Rattle();
            Console.WriteLine(snakeOne.ClassOfAnimal);
            Console.WriteLine(snakeOne.SnakeLength + "feet");

            //Owl tests:
            Console.WriteLine("\nOwl Tests: " );
            Owl peteTheOwl = new Owl();
            Console.WriteLine(peteTheOwl.ClassOfAnimal);
            Console.WriteLine("Is Pete nocturnal? " + peteTheOwl.IsNocturnal);
            //why won't this work both ways?
            peteTheOwl.FlyCheck(peteTheOwl.ClassOfAnimal);

            //wake up method makes isNocturnal true:
            snakeOne.WakeUp();
            Console.WriteLine(snakeOne.IsNocturnal);

            //new owl
            Console.WriteLine("new owl:");
            Owl owlOne = new Owl("fish");
            owlOne.FlyCheck(owlOne.ClassOfAnimal);
        }
    }
}
