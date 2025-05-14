using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Dyreinternat
{
    public class Dyr
    {

        #region Instance fields
        int _id;
        string _name;
        string _species;
        #endregion

        #region
        #endregion

        #region
        #endregion

        #region
        #endregion
        public int Id { get; set; }

        public string Name { get; set; }

        public string Species { get; set; } // Fx "Hund", "Kanin" 

        public string Breed { get; set; }

        public string ChipNumber { get; set; }

        public string SpecialCharacteristics { get; set; }

        public string Size { get; set; }

        public int BirthYear { get; set; }

        public bool NeedsMedicalAttention { get; set; }

        public string MedicalNote { get; set; }



        // Besøgslog for dyret 

        public List<Log> VisitLogs { get; set; } = new List<Log>();

    }
}

