using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrogaman4459
{
    public class Karyawan
    {
        //property karyawan
        public string Nik { get; set; }

        public string Nama { get; set; }

        public float Gajibulanan { get; set; }

        //constructor

        public Karyawan(string nik, string name, float gaji)
        {
            this.Nik = nik;
            this.Nama = name;

            if (gaji < 0)
            {
                gaji = 0;
            }
            this.Gajibulanan = gaji;
        }

        public void NaikkanGaji(float presentase)
        {
            this.Gajibulanan = presentase / 100 * this.Gajibulanan + this.Gajibulanan;
        }
    }
}
