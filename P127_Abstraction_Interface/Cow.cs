using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    class Cow:Animal
    {

        public string Name;

        public override void MakeSound()
        {
            Console.WriteLine("moo");
        }

        public override string ToString()
        {
            return Name;
        }

        public override void Eat()
        {
            Console.WriteLine("Grass");
        }
    }
}
