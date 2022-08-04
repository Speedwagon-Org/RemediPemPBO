using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediPemPBO
{
    class Komik : Buku
    {
        private string Produk { get; set; }
        public Komik(string judul, string kode, string produk) : base (judul, kode)
        {
            Produk = produk;
        }

        public string infoBuku()
        {
            return string.Format(
                 "Kode Buku = {0} \n" +
                 "Judul     = {1} \n" +
                 "Produk    = {2} ",
                 Kode,
                 Judul,
                 Produk
                 );
        }
    }
}
