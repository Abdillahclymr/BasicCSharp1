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
                int angka1, angka2, hasil1, hasil2, hasil3, hasil4;
                Console.WriteLine("Silahkan masukkan angka pertama");
                angka1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Silahkan masukkan angka kedua");
                angka2 = int.Parse(Console.ReadLine());

                hasil1 = angka1 + angka2;
                hasil2 = angka1 - angka2;
                hasil3 = angka1 * angka2;
                hasil4 = angka1 / angka2;
                Console.WriteLine("Penjumlahan : " + hasil1);
                Console.WriteLine("Pengurangan : " + hasil2);
                Console.WriteLine("Perkalian : " + hasil3);
                Console.WriteLine("Pembagian : " + hasil4);
            }
        }

    }
}

