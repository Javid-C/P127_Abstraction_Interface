using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    abstract class Human
    {
        public string Name;
        public string Surname;

        public abstract void Sleep();
        public abstract void Eat();
        public abstract void Run();
    }
}
