using System;
using System.Collections.Generic;

namespace Toko_makan.Models
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string NamaUser { get; set; }
        public string JenisKelamin { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public int? IdBarang { get; set; }

        public Barang IdBarangNavigation { get; set; }
    }
}
