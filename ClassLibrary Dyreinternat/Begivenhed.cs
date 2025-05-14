using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Dyreinternat
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } // Fx "Kat efter musen"
        public string Description { get; set; }
        public DateTime Date { get; set; }

        // Tilmeldte kunder
        public List<Customer> Participants { get; set; } = new List<Customer>();
    }
}
