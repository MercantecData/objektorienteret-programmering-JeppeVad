using System;
using System.Collections.Generic;
using Personregiter;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            // Få den data some skal bruges til person1's job
            Job person1Job = new Job("Janitor", 21000, "Hudson High School");
            // Få den data som skal bruges til person1
            Person person1 = new Person("Jack", "Johnson", 21, person1Job);

            Job person2Job = new Job("Butler", 43000, "Wayne manor");
            Person person2 = new Person("Alfred", "Pennyworth", 51, person2Job);

            /* Man kan bruge disse linjer til at ændre den data som er blevet givet fra start
            person1.name = "Jack";
            person1.age = 21;
            person1.jobDescription.jobTitle = "Butler";
            person1.jobDescription.salary = 34000;
            */


            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            // Skriver ikke data ud fra personerne i listen ud men viser hvormange personer der er i listen. 
            foreach(Person aPerson in people)
            {
                Console.WriteLine(aPerson);
            }
        }


    }
}
