namespace ClassLibrary_Dyreinternat
{
    public class Medarbejdere
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Role { get; set; } // Fx "Medarbejder" eller "Bestyrelse" 

        public string Email { get; set; }

        public void ReturnInfo()
        {
            Console.WriteLine(Id);
            Console.WriteLine(FullName);
            Console.WriteLine(Role);
            Console.WriteLine(Email);
        }
    }
}
