using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace mang_tulusa
{
    internal class Mang
    {
        private Tegelane[] tegelased;

        public Mang(Tegelane[] tegelased)
        {
            this.tegelased = tegelased;
        }
        public Tegelane suurimaEsemete_arvuga()
        {
            int suurim = 0;
            Tegelane votja = tegelased[0];
            foreach (var v in tegelased)
            {
                int arv = v.PunktideArv();
                if (arv > suurim)
                {
                    suurim = arv;
                    votja=v;
                }
            }
            return votja;
        }
        public List<Tegelane> SuurimaEsemeteArvuga()
        {
            List<Tegelane> votjad = new List<Tegelane>();
            Tegelane sorted = tegelased[0];
            foreach (Tegelane t in tegelased)
            {
                int num = sorted.CompareTo(t);
                if (num<0)
                {
                    sorted = t;
                    votjad.Clear();
                }
                if (num == 0) votjad.Add(t);
            }
            votjad.Add(sorted);
            return votjad;
        }
        public Tegelane suurimaEsemeteArvuga()
        {
            int parim = 0;
            Tegelane voitja = tegelased[0];
            foreach (var t in tegelased)
            {
                int arv = t.PunktideArv();
                if (arv>parim)
                {
                    parim = arv;
                    voitja = t;
                }
            }
            return voitja;
        }

    }
}
