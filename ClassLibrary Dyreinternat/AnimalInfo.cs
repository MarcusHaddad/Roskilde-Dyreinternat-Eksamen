using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Dyreinternat
{
    public class Dog : Animal
    {
        public Dog() { Species = "Hund", ; }
    }

    public class Cat : Animal
    {
        public Cat() { Species = "Kat"; }
    }

    public class Rabbit : Animal
    {
        public Rabbit() { Species = "Kanin"; }
    }

    public class Bird : Animal
    {
        public Bird() { Species = "Fugl"; }
    }

    public class GuineaPig : Animal
    {
        public GuineaPig() { Species = "Marsvin"; }
    }

}
