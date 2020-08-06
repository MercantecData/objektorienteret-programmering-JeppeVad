using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleOpgaveArbejdHjemme
{
    public class Hold
    {
        public Lokaler lokale;
        public List<Elever> eleverHold = new List<Elever>();
        public List<Elever> eleverTotal = new List<Elever>();
        public List<Lærer> lærerHold = new List<Lærer>();
        public List<Lærer> lærerTotal = new List<Lærer>();


        public Hold(Lokaler lokale)
        {

            this.lokale = lokale;
           
        }
        public Hold()
        {
            this.lærerTotal = new List<Lærer>();
            this.eleverTotal = new List<Elever>();
        }

    }
}
