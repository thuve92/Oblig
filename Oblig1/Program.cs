using System;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace Oblig1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til min Oblig1");
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            Console.WriteLine(p.GetDescription());
            
        }
    }
}
