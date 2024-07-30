using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Selamat datang di kelas 10 Game");
            string nama = "Abdillah";
            Console.WriteLine("Hallo " + nama + " apa kabar?");
            Console.WriteLine();
            string Nama;
            Console.WriteLine("Masukan nama : ");
            Nama = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hallo " + Nama + " Selamat datang di C#!");
            */

            string nama, asal, umur;
            Console.WriteLine("Masukan nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukan asal : ");
            asal = Console.ReadLine();
            
            
            
            Console.WriteLine("\nHallo {0} dari {1} selamat datang di C#",nama,asal);
        }
    }
}
