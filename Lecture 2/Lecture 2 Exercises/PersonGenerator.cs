using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_2
{
    public class PersonGenerator
    {
        public Person GeneratePerson()
        {
            Person Person = new Person();
            Person.FirstName = "Adam";
            Person.LastName = "Smith";
            Person.Age = 36;

            return Person;

        }

        public Person GenerateFamaly()
        {
            Person gustav = new Person();
            gustav.FirstName = "Gustav";
            gustav.LastName = "Rich";
            gustav.Age = 66;

            Person Person = new Person();
            elisa.FirstName = "Elisa";
            elisa.LastName = "Johnson";
            elisa.Age = 65;

            Person Person = new Person();
            waren.FirstName = "Waren";
            waren.LastName = "Rich";
            waren.Age = 36;

            Person Person = new Person();
            anna.FirstName = "Anna";
            anna.LastName = "Smith";
            anna.Age = 38;

            Person Person = new Person();
            robin.FirstName = "Robin";
            robin.LastName = "Rich";
            robin.Age = 10;



            return Person;
        }


    }
}
