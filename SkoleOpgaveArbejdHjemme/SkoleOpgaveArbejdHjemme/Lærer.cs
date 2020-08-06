using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleOpgaveArbejdHjemme
{
    public class Lærer
    {
        public string navn;
        public string efternavn;
        public int alder;
        public bool modtagetLøn;

        public Lærer(string navn, string efternavn, int alder, bool modtagetLøn)
        {
            this.navn = navn;
            this.efternavn = efternavn;
            this.alder = alder;
            this.modtagetLøn = modtagetLøn;
            
        }
    }
}
