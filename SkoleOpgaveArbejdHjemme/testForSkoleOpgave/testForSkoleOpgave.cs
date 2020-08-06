using System;
using SkoleOpgaveArbejdHjemme;
using System.Collections.Generic;

namespace testForSkoleOpgave
{
    class testForSkoleOpgave
    {
        static void Main(string[] args)
        {
            
            // Lav lærer her under
            Lærer lærer1 = new Lærer("Anette", "Uhre", 43, true);
            Lærer lærer2 = new Lærer("Mads", "Hoding", 79, true);
            // Lav elever her under
            Elever elev1 = new Elever("Carl", "Markussen", 12);
            Elever elev2 = new Elever("Potrick", "Jack", 12);
            Elever elev3 = new Elever("Karsten", "Johnson", 12);
            Elever elev4 = new Elever("Mila", "Jensen", 12);
            Elever elev5 = new Elever("Alma", "Hopper", 12);

            // Lav lokaler herunder
            Lokaler lokale1 = new Lokaler(1);
            Lokaler lokale2 = new Lokaler(2);
            
            // Lav hold herunder
            Hold hold1 = new Hold(lokale1);
            Hold hold2 = new Hold(lokale2);
            Hold totalElever = new Hold();
            Hold totalLærer = new Hold();
            // Sæt lærer og elever i list, ved denne sætter de dem på deres hold og sætter dem ind i en total liste
            sætLærerIliste(lærer1, "hold1");
            sætLærerIliste(lærer2, "hold2");
            sætElevIliste(elev1, "hold1");
            sætElevIliste(elev2, "hold2");
            sætElevIliste(elev3, "hold1");
            sætElevIliste(elev4, "hold2");
            sætElevIliste(elev5, "hold1");

            Console.WriteLine(hold1.eleverHold[0].navn);
            Console.WriteLine("under");
            Console.WriteLine(totalLærer.lærerTotal[0].navn);
            totalElever.eleverTotal.Remove(elev2);
            visElevListe();
            harLærerFåetløn();

            void harLærerFåetløn()
            {
                int i = 0;
                foreach(Lærer lær in totalLærer.lærerTotal)
                {
                    if(lær.modtagetLøn == true)
                    {
                        Console.WriteLine(lær.navn + " har modtaget løn");
                    }
                    else
                    {
                        Console.WriteLine(lær.navn + " har ikke modtaget løn");
                    }
                    
                    i++;
                }
            }
            void fjernLærer(Lærer lærer, string hold)
            {
                totalLærer.lærerTotal.Remove(lærer);
                switch(hold)
                {
                    case "hold1":
                        hold1.lærerHold.Remove(lærer);
                        break;
                    case "hold2":
                        hold2.lærerHold.Remove(lærer);
                        break;
                }
            }
            void fjernElev(Elever elev, string hold)
            {
                totalElever.eleverTotal.Remove(elev);
                switch (hold)
                {
                    case "hold1":
                        hold1.eleverHold.Remove(elev);
                        break;
                    case "hold2":
                        hold2.eleverHold.Remove(elev);
                        break;

                }
            }
            void redigerLærer(Lærer lærer, string navn, string efternavn, int alder, bool modtagetLøn)
            {
                int navnLængde = navn.Length;
                int efternavnLængde = efternavn.Length;
                if(navnLængde != 0)
                {
                    lærer.navn = navn;
                }
                if(efternavnLængde != 0)
                {
                    lærer.efternavn = efternavn;
                }
                if(alder != 0)
                {
                    lærer.alder = alder;
                }
                lærer.modtagetLøn = modtagetLøn;
            }
            void redigerElev(Elever elev, string navn, string efternavn, int alder)
            {
                int navnLængde = navn.Length;
                int efternavnLængde = efternavn.Length;
                if(navnLængde != 0)
                {
                    elev.navn = navn;
                }
                if(efternavnLængde != 0)
                {
                    elev.efternavn = efternavn;
                }
                if(alder != 0)
                {
                    elev.alder = alder;
                }
            }
            void visElevListe()
            {
                int i = 0;
                foreach(Elever navn in totalElever.eleverTotal)
                {
                    Console.WriteLine(totalElever.eleverTotal[i].navn);
                    i++;
                }
            }
            void visLærerListe()
            {
                int i = 0;
                foreach(Lærer navn in totalLærer.lærerTotal)
                {
                    Console.WriteLine(totalLærer.lærerTotal[i].navn);
                    i++;
                }
            }
            void visLærerListehold(string hold)
            {
                int i = 0;
                
                switch(hold)
                {
                    case "hold1":
                        foreach (Lærer navn in hold1.lærerHold)
                        {
                            Console.WriteLine(hold1.lærerHold[i].navn);
                            i++;
                        }
                        break;
                    case "hold2":
                        foreach (Lærer navn in hold2.lærerHold)
                        {
                            Console.WriteLine(hold2.lærerHold[i].navn);
                            i++;
                        }
                        break;
                    default:
                        break;
                }
            }
            void visElevListehold(string hold)
            {
                int i = 0;

                switch (hold)
                {
                    case "hold1":
                        foreach (Elever navn in hold1.eleverHold)
                        {
                            Console.WriteLine(hold1.eleverHold[i].navn);
                            i++;
                        }
                        break;
                    case "hold2":
                        foreach (Elever navn in hold2.eleverHold)
                        {
                            Console.WriteLine(hold2.eleverHold[i].navn);
                            i++;
                        }
                        break;
                    default:
                        break;
                }
            }
            void sætLærerIliste(Lærer lærer, string hold)
            {
                totalLærer.lærerTotal.Add(lærer);
                switch (hold)
                {
                    case "hold1":
                        hold1.lærerHold.Add(lærer);
                        break;
                    case "hold2":
                        hold2.lærerHold.Add(lærer);
                        break;
                    default:
                        break;
                }
            }
            void sætElevIliste(Elever elev, string hold)
            {
                totalElever.eleverTotal.Add(elev);
                switch (hold)
                {
                    case "hold1":
                        hold1.eleverHold.Add(elev);
                        break;
                    case "hold2":
                        hold2.eleverHold.Add(elev);
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}


