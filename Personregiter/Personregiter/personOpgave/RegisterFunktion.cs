using Personregister;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class RegisterFunktion
    {
        public List<Person> people = new List<Person>();

        public Dictionary<string, int> nameAge = new Dictionary<string, int>();

        public void setNameAgeDic(string name, int age)
        {
            nameAge[name] = age;
        }
        
    }
}
