using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Menu calculator yang tersedia:");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.WriteLine("Pilih menu untuk menjalankan program! [1...4]");
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (menu == 1)
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); //proses casting
                Console.WriteLine("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine(); //tambahkan baris kosong
                Console.WriteLine("Hasil penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (menu == 2)
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); //proses casting
                Console.WriteLine("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine(); //tambahkan baris kosong
                Console.WriteLine("Hasil pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
            }
            else if (menu == 3)
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); //proses casting
                Console.WriteLine("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine(); //tambahkan baris kosong
                Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (menu == 4)
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); //proses casting
                Console.WriteLine("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine(); //tambahkan baris kosong
                Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Menu yang Anda masukkan salah. Tidak ada program yang dapat dijalankan.");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
