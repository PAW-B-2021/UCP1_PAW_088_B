using System;
using System.Collections.Generic;

namespace Toko_makan.Models
{
    public partial class Admin
    {
        public int IdAdmin { get; set; }
        public string NamaAdmin { get; set; }
        public string JenisKelamin { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public int? IdBarang { get; set; }

        public Barang IdBarangNavigation { get; set; }
    }
}
