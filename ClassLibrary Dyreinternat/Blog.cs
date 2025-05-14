using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Dyreinternat
{
    internal class Blog
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }



        public string ImageUrl { get; set; } // Valgfrit billede 

        public int AuthorId { get; set; }

        public Medarbejdere Author { get; set; } // Hvem har skrevet det 
    }
}
