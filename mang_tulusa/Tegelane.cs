using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mang_tulusa
{
    internal class Tegelane : /*IUksis,*/ IComparable<Tegelane>
    {
        private string nimi;
        List<Ese> esed;
        int esemed;

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
            //esed = new List<Ese>();
        }

        public int lisaEse(int arv) { return arv; }
        public int PunktideArv()
        {
            int sum=0;
            
            foreach (Ese asi in esed) { sum += asi.punktideArv(); }
            esemed += 1; //подсчет кол-ва предметов у персонажа
            return sum;
        }
        public string info() 
        {
            string tegelase_info;
            tegelase_info= $"See on {nimi} tal on {esemed}esemed ja {PunktideArv()}punkti";
            return tegelase_info;
        }
        public void valjastaEsemed()
        {
            foreach (var asi in esed)
            {
                Console.WriteLine(asi.Info());
            }

        }



        public int CompareTo(Tegelane? muu)
        {
            if (muu==null)
            {
                return 1;
            }
            return this.esed.Count - muu.EsesKogus();

        }
        private int EsesKogus() { return this.esed.Count; }
    }
}
