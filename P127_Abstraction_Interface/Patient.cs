using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    class Patient : Human
    {
        public override void Eat()
        {
            Console.WriteLine("Pancake");
        }

        public override void Run()
        {
            Console.WriteLine("Dont run");
        }

        public override void Sleep()
        {
            Console.WriteLine("23 hours");
        }
    }
}
