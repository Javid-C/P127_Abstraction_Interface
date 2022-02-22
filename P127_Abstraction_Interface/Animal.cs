using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    abstract class Animal
    {
        public string Sort;
        public int Age;

        public abstract void MakeSound();
        public abstract void Eat();
    }
}
