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
                new Animal(12, "Milo", "Dog1", "12201200", "Golden retriever", "Big", "2015", "good medicals"),
                new Animal(17, "Karl", "Rabbit1", "156700", "Giant rabbit", "Big", "2021", "good medicals"),
                new Animal(21, "Frank", "Cat1", "150055", "black cat", "small", "2024", "good medicals"),
                new Animal(124, "Norm", "Bird", "150981", "Parrot", "small", "2020", "good medicals"),
                new Animal(1242, "Gordon", "Guineapig", "202012", "Sheltie", "small", "2025", "good medicals"),
                new Animal(1242, "Molly", "Cat2", "202695", "Persian", "medium", "2019", "good medicals"), 
                new Animal(1580, "Carlo", "Dog2", "80584030", "Siberian Husky", "Big", "2023", "good medicals"),               
                new Animal(1242, "Bertha", "Rabbit2", "281960", "polish rabbit", "small", "2022", "good medicals"),


            };
            foreach (var animal in animals)
            {
                animal.VisInfo();
            }
            List<Kunder> kunde = new List<Kunder>();
            {
               
             };

            
            foreach (var kunder in kunde) 
            { 
                 kunde.Add(kunder);
            }

            List<Medarbejdere> medarbejder = new List<Medarbejdere>();
            {
                new Medarbejdere();
                new Medarbejdere();
                new Medarbejdere();
                new Medarbejdere();
               
                Console.WriteLine(medarbejder.Count);
                Console.WriteLine($"4 Medarbejdere");


            }
            foreach (var medarbejdere in medarbejder)
            {
                

            }
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello, World!");
            
        }
    }
}

