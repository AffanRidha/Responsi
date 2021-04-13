using System;

namespace ResponsiPemrograman3392
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan1 = new Karyawan(20113333, "Fulan", 5000000);
            Karyawan karyawan2 = new Karyawan(20114444, "Fulanah", 6000000);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|No.\t NIK \t  NIM \t Nama \t \t Gaji|");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(karyawan1.nim, karyawan1.nama, karyawan1.gajibulanan);
            Console.WriteLine(karyawan2.nim, karyawan2.nama, karyawan2.gajibulanan);

            Console.WriteLine("\n Selamat Kamu mendapatkan kenaikan gaji sebesar 10% \n");

            Console.WriteLine("|No.\t NIK \t  NIM \t Nama \t \t Gaji|");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(karyawan1.nim, karyawan1.nama, karyawan1.gajibulanan);
            Console.WriteLine(karyawan2.nim, karyawan2.nama, karyawan2.gajibulanan);

            Console.ReadKey();
        }
    }
}
