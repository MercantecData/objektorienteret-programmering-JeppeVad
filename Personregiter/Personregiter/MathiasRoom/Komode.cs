using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Komode
    {
        private string farve;
        private int skuffer;
        private Tøj tøj;

        public Komode(string farve, int skuffer, Tøj tøj)
        {
            this.farve = farve;
            this.skuffer = skuffer;
            this.tøj = tøj;
        }
        public int hoodiesTilgængelig(int hoodies)
        {
            return hoodies;
        }
    }
}
