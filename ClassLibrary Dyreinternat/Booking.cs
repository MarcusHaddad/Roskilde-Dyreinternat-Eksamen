using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Dyreinternat
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingTime { get; set; }

        // Relation til kunde
        public int KunderId { get; set; }
        public Kunder Kunder { get; set; }

        // Relation til dyr (valgfrit)
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
    

