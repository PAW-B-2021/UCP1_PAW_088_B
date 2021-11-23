using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Toko_makan.Models
{
    public partial class kasirContext : DbContext
    {
        public kasirContext()
        {
        }

        public kasirContext(DbContextOptions<kasirContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Barang> Barang { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.IdAdmin);

                entity.Property(e => e.IdAdmin).HasColumnName("id_admin");

                entity.Property(e => e.IdBarang).HasColumnName("Id_Barang");

                entity.Property(e => e.JenisKelamin)
                    .HasColumnName("jenis_kelamin")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NamaAdmin)
                    .HasColumnName("nama_admin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalLahir)
                    .HasColumnName("tanggal_lahir")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdBarangNavigation)
                    .WithMany(p => p.Admin)
                    .HasForeignKey(d => d.IdBarang)
                    .HasConstraintName("FK_Admin_Barang");
            });

            modelBuilder.Entity<Barang>(entity =>
            {
                entity.HasKey(e => e.IdBarang);

                entity.Property(e => e.IdBarang).HasColumnName("Id_Barang");

                entity.Property(e => e.JumlahBarang)
                    .HasColumnName("Jumlah_Barang")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kadaluarsa).HasColumnType("datetime");

                entity.Property(e => e.NamaBarang)
                    .HasColumnName("Nama_Barang")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.IdBarang).HasColumnName("Id_Barang");

                entity.Property(e => e.JenisKelamin)
                    .HasColumnName("Jenis_Kelamin")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NamaUser)
                    .HasColumnName("nama_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalLahir)
                    .HasColumnName("tanggal_Lahir")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdBarangNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.IdBarang)
                    .HasConstraintName("FK_User_Barang");
            });
        }

        internal static Task<string> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
