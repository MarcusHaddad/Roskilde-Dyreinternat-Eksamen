using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Dyreinternat
{
    public class Animal
    {

        #region Instance fields
        int _id;
       public string _name;
        string _species;
        string _chipNumber;
        string _breed;
        string _size;
        int _birthYear;
        string _medicalnote;
        #endregion

        #region Constructor
        public Animal(int id, string name, string species, string chipNumber, string breed, string size, int birthYear, string medicalnote)
        {
            _id = id;
            _name = name;
            _species = species;
            _chipNumber = chipNumber;
            _breed = breed;
            _size = size;
            _birthYear = birthYear;
            _medicalnote = medicalnote;
        }
    }

    #endregion

    #region
    #endregion

    #region
    #endregion


}


