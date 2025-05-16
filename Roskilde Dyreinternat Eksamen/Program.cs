using ClassLibrary_Dyreinternat;
using System;
namespace Roskilde_Dyreinternat_Eksamen
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Animal(12, "Milo", "Dog", "12201200", "Golden retriever", "Big", "2015", "good medicals"),
                new Animal(17, "Karl", "Rabbit", "156700", "Giant rabbit", "Big", "2021", "good medicals"),
                new Animal(21, "Frank", "Cat", "150055", "black cat", "small", "2024", "good medicals")
            };
            foreach (var animal in animals)
            {
                animal.VisInfo();
            }
                Console.ReadLine();
                Console.WriteLine("Hello, World!");
            
        }
    }
}
