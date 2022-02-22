using System;

namespace P127_Abstraction_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book book = new Book();

            //book.Id = 5;
            //Console.WriteLine(book.AddBook());

            //Animal animal = new Animal();

            //animal.MakeSound();

            //Eagle eagle = new Eagle();
            //eagle.MakeSound();

            //Cow cow = new Cow();
            //cow.MakeSound();

            //cow.Name = "okay";

            //Console.WriteLine(cow.ToString()) ;

            Student student = new Student("Isa", "Sadiqli", 20);

            Console.WriteLine("Student");

            student.Sleep();
            student.Run();
            student.Eat();

            Console.WriteLine("Patient\n");

            Patient patient = new Patient();

            patient.Sleep();
            patient.Run();
            patient.Eat();

            Console.WriteLine("\nAnimal \n");
            Console.WriteLine("\n Cow \n");

            Cow cow = new Cow();
            cow.Eat();
            cow.MakeSound();

            Console.WriteLine("\n Eagle \n");
            Eagle eagle = new Eagle();

            eagle.Eat();
            eagle.MakeSound();


            Soap soap = new Soap();

            soap.Category = "Sci-Fi1";
            Console.WriteLine(soap.Category);

            Movie movie = new Movie();

            movie.Category = "Drama";

            Console.WriteLine(movie.Category);
        }
    }
}
