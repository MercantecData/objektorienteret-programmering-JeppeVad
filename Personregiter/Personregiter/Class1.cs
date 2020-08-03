using System;

namespace Personregiter
{
    // Person til første opgave, hvor vi skulle lave en class med en person som også har er job som er en class
    // OPGAVE - få lavet så at listen er her inde.
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Job jobDescription;

        public Person(string firstName, string lastName, int age, Job jobDescription)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.jobDescription = jobDescription;
        }
    }
    // Denne class er til opgaven over
    public class Job
    {
        public string firm;
        public string jobTitle;
        public int salary;


        public Job(string jobTitle, int salary, string firm)
        {
            this.firm = firm;
            this.jobTitle = jobTitle;
            this.salary = salary;
        }
    }
    // Denne class er for bonus opgaven hvor man skal bruge en class af en person som key til dictionary
    public class PersonForKey
    {
        public string name;
        public int age;

        public PersonForKey(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }


}
