using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmatika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int angka1, angka2, hasil;
                Console.WriteLine("Silahkan masukkan angka pertama");
                angka1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Silahkan masukkan angka kedua");
                angka2 = int.Parse(Console.ReadLine());

                hasil = angka1 + angka2;

                Console.WriteLine(hasil);

            }
        }

    }
}

