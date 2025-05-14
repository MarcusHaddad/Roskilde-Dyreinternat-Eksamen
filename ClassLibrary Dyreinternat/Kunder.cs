using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Dyreinternat
{
    public class Kunder
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }



        // Bookinger lavet af kunden 

        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
