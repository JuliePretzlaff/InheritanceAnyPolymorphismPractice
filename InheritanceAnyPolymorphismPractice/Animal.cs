using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAnyPolymorphismPractice
{
    public class Animal
    {
        //fields:
        private string classOfAnimal;
        private int numberOfLegs;
        private bool isPoisonous;
        private bool isNocturnal;

        //properties:
        public string ClassOfAnimal
        {
            get { return this.classOfAnimal; }
            set { this.classOfAnimal = value; }
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            set { this.numberOfLegs = value; }
        }

        public bool IsPoisonous
        {
            get { return this.isPoisonous; }
            set { this.isPoisonous = value; }
        }

        public bool IsNocturnal
        {
            get { return this.isNocturnal; }
            set { this.isNocturnal = value; }
        }

        //constructor:
        public Animal()
        {
            //default constructor
        }

        public Animal(string type, bool nocturnal)
        {
            this.classOfAnimal = type;
            this.isNocturnal = nocturnal;
        }

        public Animal(string type, bool nocturnal, bool poisonous)
        {
            this.classOfAnimal = type;
            this.isNocturnal = nocturnal;
            this.isPoisonous = poisonous;
        }

        //method:

        public void WakeUp()
        {
            if(isNocturnal == false)
            {
                isNocturnal = true;
            }
        }
    }
}
