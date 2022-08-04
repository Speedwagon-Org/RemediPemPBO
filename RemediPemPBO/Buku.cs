using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemediPemPBO
{
    public class Buku
    {
        public string Judul { get; set; }
        public string Kode { get; set; }
        public Buku (string judul, string kode)
        {
            Judul = judul;
            Kode = kode;
        }
    }
}
