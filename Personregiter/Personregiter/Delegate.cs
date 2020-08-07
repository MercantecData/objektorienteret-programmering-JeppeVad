using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Delegates
    {
        public delegate void test1();
        public delegate float testFloat();
        public delegate void taImodTrePara(string navn, string efternavn, string by);
        public static void toTest1()
        {
            Console.WriteLine("void uden parameter virker");
        }
        public static float toTestFloat()
        {
            Console.WriteLine("float uden parameter virker");
            return 1;
        }
        public static void toTaImodTrePara(string navn, string efternavn, string by)
        {
            Console.WriteLine(navn + " " + efternavn + " " + by);
        }
    }
}
