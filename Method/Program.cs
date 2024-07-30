using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Langkah(int langkah)
        {
            Console.WriteLine("Jalan {0} langkah",langkah);
        }
        
        static void HadapKanan()
        {
            Console.WriteLine("Hadap Kanan");
        }

        static void HadapKiri()
        {
            Console.WriteLine("Hadap Kiri");
        }

        static void Mundur(int langkah)
        {
            Console.WriteLine("Mundur {0} langkah",langkah);
        }
        static void Main(string[] args)
        {
            int jalan;
            Console.WriteLine("Berapa langkah karakter jalan? ");
            jalan = int.Parse(Console.ReadLine());
            Langkah(jalan);
            HadapKanan();
            HadapKiri();
            Mundur(20);
        }
    }
}
