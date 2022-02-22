using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Abstraction_Interface
{
    class Student:Human
    {
        public int Age;

        public Student(string name,string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public int Test()
        {
            return 5;
        }

        public override string ToString()
        {
            return $"Name: {Name} \n Surname: {Surname}";
        }


        public override void Sleep()
        {
            Console.WriteLine("4 hours");
        }

        public override void Eat()
        {
            Console.WriteLine("Makaron");
        }

        public override void Run()
        {
            Console.WriteLine("Always");
        }
    }
}
