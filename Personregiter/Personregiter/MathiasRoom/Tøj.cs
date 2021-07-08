using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Tøj
    {
        private int tshirt;
        private int hoodies;
        private int bukser;
        public int Hoodies   
        {
            get { return hoodies; }   
            set { hoodies = value; }  
        }

        public Tøj(int tshirt, int hoodies, int bukser)
        {
            this.tshirt = tshirt;
            this.hoodies = hoodies;
            this.bukser = bukser;
        }
    }
}
