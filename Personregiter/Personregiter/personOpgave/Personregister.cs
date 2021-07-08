using System;
using System.Collections.Generic;

namespace Personregister
{
    // Person til første opgave, hvor vi skulle lave en class med en person som også har er job som er en class
    // OPGAVE - få lavet så at listen er her inde.
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Job jobDescriotion;

        public Person(string firstName, string lastName, int age, Job jobDescriotion)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.jobDescriotion = jobDescriotion;
        }


    }

    
    
        
    


}
