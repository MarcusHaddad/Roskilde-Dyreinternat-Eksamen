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
        string _name;
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


        #endregion

        #region Properties
        private int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string Species
        {
            get { return _species; }
            set { _species = value; }

        }
        private string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }
        private string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        private int BirthYear
        {
            get { return _birthYear; }
            set { _birthYear = value; }
        }
        private string Medicalnote
        {
            get { return _medicalnote; }
            set { _medicalnote = value; }
        }

        #endregion

        #region Methods


        #endregion

    }
}


