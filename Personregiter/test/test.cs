using System;
using System.Collections.Generic;
using Classes;
using Personregister;
namespace test
{
    class test
    {
        static void Main(string[] args)
        {
            var funktioner = new RegisterFunktion();


            //----------------------------------------- OPGAVE PÅ TAVLE -------------------------------------------------------//
            // Få den data some skal bruges til person1's job
            Job person1Job = new Job("Janitor", 21000, "Hudson High School");
            // Få den data som skal bruges til person1
            Person person1 = new Person("Jack", "Johnson", 21, person1Job);

            Job person2Job = new Job("Butler", 43000, "Wayne manor");
            Person person2 = new Person("Alfred", "Pennyworth", 51, person2Job);
            // Her Laver jeg en ny person hvor der ikke bliver sat en løn, for at teste overload i Job.cs>
            Job person5Job = new Job("CEO", "Wayne Interprise");
            Person person5 = new Person("Bruce", "Wayne", 34, person5Job);
            // Henter liste fra Personregister.cs
            var listOfPeople = funktioner.people;
            // Tilføjer personer til liste
            listOfPeople.Add(person1);
            listOfPeople.Add(person2);
            listOfPeople.Add(person5);
            // Printer firstname fra den første person i listen
            Console.WriteLine(listOfPeople[0].firstName);
            Console.WriteLine(listOfPeople[2].jobDescriotion.salary);
            /* Man kan bruge disse linjer til at ændre den data som er blevet givet fra start
            person1.name = "Jack";
            person1.age = 21;
            person1.jobDescription.jobTitle = "Butler";
            person1.jobDescription.salary = 34000;
            */

            //------------------------------------------- OPGAVE: DICITIONARY -------------------------------------------------//
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
            numbers["sixnine"] = 69;

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

            PersonForDic person3 = new PersonForDic("Marcus", 12);
            PersonForDic person4 = new PersonForDic("Carl", 13);
            
            // Sætter ind i en dictionary inden i RegisterFunktion, så er det mere smart at sætte nye personer ind i en dictionary
            funktioner.setNameAgeDic("Carson", 20);


            var numbersForPeople = new Dictionary<PersonForDic, int>();

            numbersForPeople.Add(person3, 12121212);
            numbersForPeople.Add(person4, 21212121);


            Console.WriteLine(numbersForPeople[person3]);
            Console.WriteLine(numbersForPeople[person4]);

            //---------------------------------------------- OPGAVE: OVERLOAD MATH ------------------------------------//
            Console.WriteLine(" ");

            Classes.Math mathCalculate = new Classes.Math();

            mathCalculate.Plus(1, 1);
            mathCalculate.Plus("2,1", "1");
            mathCalculate.Gange("2,1", "3");
            Console.WriteLine(mathCalculate.Potens(2.3f, 2.1f));
            float sum = mathCalculate.Potens(4.2f, 3.3f);
            Console.WriteLine(sum);
            Console.WriteLine(mathCalculate.Potens(3.2f, 2));

            //---------------------------------------------- OPGAVE: MATHIAS KOMODE ----------------------------------//

            Tøj tøk = new Tøj(5,2,3);
            Komode komode = new Komode("rød", 4, tøk);

            Console.WriteLine(komode.hoodiesTilgængelig(tøk.Hoodies));
            


        }


    }
}
