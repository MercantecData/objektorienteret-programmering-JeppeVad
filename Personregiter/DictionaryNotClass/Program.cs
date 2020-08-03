using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Personregiter;

namespace DictionaryNotClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary med string og int
            Dictionary<string, int> numbers = new Dictionary<string, int>();
            numbers.Add("one", 1);
            numbers.Add("en", 1);
            numbers.Add("two", 2);
            numbers.Add("three", 3);
            numbers.Add("four", 4);
            numbers.Add("five", 5);
            numbers.Add("six", 6);
            numbers.Add("seven", 7);
            numbers.Add("eight", 8);
            numbers.Add("nine", 9);
            numbers.Add("ten", 10);
            
            Console.WriteLine(numbers["one"]);
            Console.WriteLine(numbers["two"]);
            Console.WriteLine(numbers["three"]);
            Console.WriteLine(numbers["four"]);

            // Dictionary med float og bool
            Dictionary<float, bool> floatbool = new Dictionary<float, bool>();
            floatbool.Add(12, true);
            floatbool.Add(15467, false);
            floatbool.Add(312, true);
            floatbool.Add(123123123123, false);
            floatbool.Add(241323, false);
            floatbool.Add(21231232, true);
            floatbool.Add(322, true);
            floatbool.Add(4, true);

            PersonForKey person3 = new PersonForKey("Marcus", 12);
            PersonForKey person4 = new PersonForKey("Carl", 13);

            Dictionary<PersonForKey, int> numbersForKids = new Dictionary<PersonForKey, int>();

            numbersForKids.Add(person3, 12121212);
            numbersForKids.Add(person4, 21212121);

            Console.WriteLine(numbersForKids[person3]);
            Console.WriteLine(numbersForKids[person4]);
        }
    }
}
