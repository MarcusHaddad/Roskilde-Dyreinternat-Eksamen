using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Dyreinternat
{
    public class VisitLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } // Dato for besøget
        public string VisitorName { get; set; } // Navn på kunde eller dyrlæge
        public string Note { get; set; } // F.eks. "Vaccination" eller "Adoptionsbesøg"

        // Relation til dyret
        public int AnimalId { get; set; }
        public Animal Animal { get; set; } //refererer til Animal Objektet
    }

}
