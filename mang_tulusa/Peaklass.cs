using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang_tulusa
{
    internal class Peaklass
    {
        public static Random rnd = new Random();
        public static List<Ese> LoeEsemed()
        {
            List<Ese> esed = new List<Ese>();
            using (StreamReader sr = new StreamReader(@"../../../esemed.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] rida = sr.ReadLine().Split(";");
                    Ese ese = new Ese(rida[0].ToString(),Int32.Parse(rida[1]));
                    esed.Add(ese);
                }
            }
            return esed;
        }
        static string Mangijate_loetelu()
        {
            string[] nimed = {"sad", "asd", "das", "dsa", "ads"};
            return nimed[rnd.Next(nimed.Length)];
        }
        static Tegelane[] Mangijad(int tegelasekogus)
        {
            if (tegelasekogus < 2) throw new Exception();
            Tegelane[] mangijad = new Tegelane[tegelasekogus];
            for (int i = 0; i < tegelasekogus; i++)
            {
                Tegelane mangija = new Tegelane(Mangijate_loetelu());
                mangijad[i] = mangija;
            }
            List<Ese> esed = LoeEsemed();
            if (esed.Count <= 0) throw new ArgumentOutOfRangeException();
            /*foreach (Tegelane m in mangijad)
            {
                Shuffle(esed);
                int esedekogus = rnd.Next(2, 10);
                for (int i = 0; i < esedekogus; i++)
                {
                    m.lisaEse(esed[i]);
                }
            }*/
        }

        private static void Shuffle(List<Ese> esed)
        {
            throw new NotImplementedException();
        }
    }
}
