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
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Species
        {
            get { return _species; }
            set { _species = value; }

        }
        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public int BirthYear
        {
            get { return _birthYear; }
            set { _birthYear = value; }
        }
        public string Medicalnote
        {
            get { return _medicalnote; }
            set { _medicalnote = value; }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"name : {Name} - id : {Id} - species {Species} - breed {Breed} - size {Size} - birthyear {BirthYear} - medicalnote {Medicalnote}";

            #endregion

        }
        public void VisInfo()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Species);
            Console.WriteLine(Breed);
            Console.WriteLine(Size);
            Console.WriteLine(BirthYear);
            Console.WriteLine(Medicalnote);

        }
    }
}


