using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    enum Nadwozie
    {
        Coupe=0,
        Sedan=1,
        Combi=2,
    }
    internal class Auta
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public Nadwozie Nadwozie { get; set; } = 0;

        public Auta(string marka, string model, Nadwozie nadwozie)
        {
            this.Nadwozie = nadwozie;
            this.Marka = marka;
            CheckTier();
            Model = model;
        }
        public void CheckTier()
        {
            string jabol = Marka.ToLower();
            string[] coupe = { "coupe"};
            string[] sedan = { "sedan"};
            string[] combi = { "combi"};
             
            
                if (Marka.Equals(coupe[0]))
                {
                Nadwozie = Nadwozie.Coupe;
                   
                }
                if (Marka.Equals(sedan[0]))
                {
                Nadwozie = Nadwozie.Sedan;
                    
                }
                if (Marka.Equals(combi[0]))
                {
                Nadwozie = Nadwozie.Combi;
                    
                }
            
        }
    }
}
