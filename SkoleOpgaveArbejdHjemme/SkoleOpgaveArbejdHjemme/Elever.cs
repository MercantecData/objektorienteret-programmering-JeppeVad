using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleOpgaveArbejdHjemme
{
    public class Elever
    {
        public string navn;
        public string efternavn;
        public int alder;
        


        public Elever(string navn, string efternavn, int alder)
        {
            this.navn = navn;
            this.efternavn = efternavn;
            this.alder = alder;
        }
    }
}
