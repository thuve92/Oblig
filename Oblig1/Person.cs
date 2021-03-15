using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig1
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int DeathYear;
        public Person Father;
        public Person Mother;

        public string GetDescription()
        {
            string output = String.Empty;
            //output += FirstName + " " + LastName + " " + "(Id=" + Id + ") Født: " + BirthYear + " Død: " + DeathYear +
            //          " Far: " +
            //          Father.FirstName + " (Id=" + Father.Id + ")" + " Mor: " + Mother.FirstName + " (Id=" + Mother.Id +
            //          ")";

            output += $"{FirstName} {LastName} (Id={Id}) Født: {BirthYear} Død: {DeathYear} Far: {Father.FirstName} (Id={Father.Id})" +
                      $" Mor: {Mother.FirstName} (Id={Mother.Id})";

            return output;
        }
    }
}

    