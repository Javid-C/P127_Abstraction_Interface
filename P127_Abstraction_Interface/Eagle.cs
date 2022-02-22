using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    class Eagle:Animal
    {
        public string Wing;
        public string Feather;


        public override void MakeSound()
        {
            Console.WriteLine("Wek");
        }
        public override void Eat()
        {
            Console.WriteLine("Meat");
        }
    }
}
