using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Dyreinternat
{
    public class Dog : Animal
    {
        public Dog() : base(12, "Milo", "Dog", "12201200", "Golden Retriever", "Big", "2015", "Good medicals") {}
    }

    public class Cat : Animal
    {
        public Cat() : base(21, "Frank", "Cat", "150055", "black cat", "small", "2024", "Good medicals") {}
    }

    public class Rabbit : Animal
    {
        public Rabbit() : base(17, "Karl", "Rabbit", "156700", "Giant rabbit", "Big", "2021", "Good medicals") {}
    }

    public class Bird : Animal
    {
        public Bird() : base(124, "Norm", "Bird", "150981", "Parrot", "Small", "2020", "Good medicals") {}
    }

    public class GuineaPig : Animal
    {
        public GuineaPig() : base(1242, "Gordon", "Guineapig", "202012", "Sheltie", "small", "2025", "Good medicals") {}
    }

}
