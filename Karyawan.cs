using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman3392
{
    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajibulanan { get; set; }
        public int naikgaji { get; set; }

        public Karyawan(string nama, int gaji, int nik)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajibulanan = 0;
            }
            else
            {
                this.gajibulanan = gaji;
            }

            double tnp = 0;
            tnp = 0.1 * gajibulanan;
            naikgaji = Convert.ToInt32(tnp) * gajibulanan;
        }
    }
}
