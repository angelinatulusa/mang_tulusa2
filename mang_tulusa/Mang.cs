using System;
using System.Collections.Generic;
using System.Linq;
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
        public Tegelane suurimaEsemeteArvuga()
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

    }
}
