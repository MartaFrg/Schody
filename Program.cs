using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetSchodu;
            string znak1, znak2;
            znak1 = " "; znak2 = "#";
            Console.WriteLine("Zadej počet schodů:");
            while (!int.TryParse(Console.ReadLine(), out pocetSchodu)) Console.WriteLine("Špatné zadání, je třeba zadat počet schodů v celých číslech:");
            //kConsole.WriteLine(mnozeniPismen(znak2, pocetSchodu));
            if (pocetSchodu >= 0)
            {
                znak1 = " "; znak2 = "#";
            }
            else 
            { 
                znak1 = "#"; znak2 = " "; pocetSchodu = Math.Abs(pocetSchodu); 
            }
            for (int i = 0; i <= pocetSchodu; i++)
            {
                Console.WriteLine(mnozeniPismen(znak1, pocetSchodu - i) + mnozeniPismen(znak2, i));
            }
        }
        static string mnozeniPismen(string s, int k)
        {
            if (k == 0) return "";
            for (int i = 1; i < k; i++)
            {
                s = String.Concat(s, s[0]);
            }
            return s;
        }
    }
}
