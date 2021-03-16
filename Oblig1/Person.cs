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
            
            if (FirstName != null)
            {

                output += $"{FirstName} ";

            }

            if (LastName != null)
            {
                output += $"{LastName} ";
            }
            if (Id != 0)
            {
            
                output += "(Id=" + Id + ")";
            }
            if (BirthYear != 0)
            {
                output += " Født: " + BirthYear;
            }
            if (DeathYear != 0)
            {
                output += " Død: " + DeathYear;
            }
            if (Father != null && Father.Id != 0)
            {
                output += " Far: " + Father.FirstName + " (Id=" + Father.Id + ")";
            }
            if (Mother != null && Mother.Id != 0)
            {
                output += " Mor: " + Mother.FirstName + " (Id=" + Mother.Id + ")";
            }

            return output;

            //$"{FirstName} {LastName} (Id={Id}) Født: {BirthYear} Død: {DeathYear} Far: {Father.FirstName} (Id={Father.Id})" +
            //    $" Mor: {Mother.FirstName} (Id={Mother.Id})";
        }
    }
}

    