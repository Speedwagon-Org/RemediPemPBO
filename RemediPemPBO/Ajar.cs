using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediPemPBO
{
    class Ajar : Buku
    {
        private string Bidang { get; set; }
        private int Edisi { get; set; }
        public Ajar(string judul, string kode , string bidang, int edisi) : base (judul, kode)
        {
            Bidang = bidang;
            Edisi = edisi;
        }

        public string infoBuku()
        {
            return string.Format(
                "Kode Buku = {0} \n" +
                "Judul     = {1} \n" +
                "Bidng     = {2} \n" +
                "Edisi     = {3}",
                Kode,
                Judul,
                Bidang,
                Edisi
                );
        }
    }
}
