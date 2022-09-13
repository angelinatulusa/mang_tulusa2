using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mang_tulusa
{
    class Ese : Uksis
    {
        public string nimetus;
        public int punktide_arv;

        public Ese() { }

        public Ese(string nimetus, int punktide_arv)
        {
            this.nimetus = nimetus;
            this.punktide_arv = punktide_arv;
        }
        public int  punktideArv()
        {

            return punktide_arv;
        }

        public string  Info()
        {
            return nimetus;
        }

        
    }
    
}
