using System;
using System.Collections.Generic;

namespace Toko_makan.Models
{
    public partial class Barang
    {
        public Barang()
        {
            Admin = new HashSet<Admin>();
            User = new HashSet<User>();
        }

        public int IdBarang { get; set; }
        public string NamaBarang { get; set; }
        public DateTime? Kadaluarsa { get; set; }
        public string JumlahBarang { get; set; }

        public ICollection<Admin> Admin { get; set; }
        public ICollection<User> User { get; set; }
    }
}
