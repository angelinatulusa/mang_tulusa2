using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mang_tulusa
{
    internal class Tegelane : IComparable<Tegelane>
    {
        private string nimi;
        List<Ese> tegelane;
        int esemed;

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
            tegelane = new List<Ese>();
        }

        public void lisaEse(Ese asi)
        {
            tegelane.Add(asi);

        }
        public int PunktideArv()
        {
            int sum=0;
            
            foreach (Ese asi in tegelane) { sum += asi.punktideArv(); }
            esemed += 1; //подсчет кол-ва предметов у персонажа
            return sum;
        }
        /*public void info() //работает, выводит информацию, но по заданию нужно возвращать информацию, поэтому не подходит
        {
            Console.WriteLine($"See on {nimi} tal on {esemed}esemed ja {PunktideArv()}punkti");
        }*/
        public string info() //ничего не выводит на экран
        {
            return $"See on {nimi} tal on {esemed}esemed ja {PunktideArv()}punkti";
        }
        public void valjastaEsemed()
        {
            foreach (var asi in tegelane)
            {
                Console.WriteLine(asi.nimetus + "\n");
            }

        }



        public int CompareTo(Tegelane? other)
        {
            throw new NotImplementedException();
        }
    }
}
