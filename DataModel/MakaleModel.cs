namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MakaleModel : DbContext
    {
        public MakaleModel()
            : base("name=MakaleModel")
        {
        }

        public virtual DbSet<Bolum> Bolum { get; set; }
        public virtual DbSet<Dergi> Dergi { get; set; }
        public virtual DbSet<Endeks> Endeks { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Makale> Makale { get; set; }
        public virtual DbSet<MakaleKategori> MakaleKategori { get; set; }
        public virtual DbSet<MakaleTur> MakaleTur { get; set; }
        public virtual DbSet<MakaleYazar> MakaleYazar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Unvan> Unvan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bolum>()
                .HasMany(e => e.Kullanici)
                .WithRequired(e => e.Bolum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dergi>()
                .HasMany(e => e.Makale)
                .WithRequired(e => e.Dergi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Endeks>()
                .HasMany(e => e.Makale)
                .WithRequired(e => e.Endeks)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.MakaleKategori)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.TcKimlikNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.KullaniciAdi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.Parola)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.MakaleYazar)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Tarayici)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Metot)
                .IsFixedLength();

            modelBuilder.Entity<Log>()
                .Property(e => e.Parametre)
                .IsFixedLength();

            modelBuilder.Entity<Makale>()
                .HasMany(e => e.MakaleKategori)
                .WithRequired(e => e.Makale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Makale>()
                .HasMany(e => e.MakaleYazar)
                .WithRequired(e => e.Makale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MakaleTur>()
                .HasMany(e => e.Makale)
                .WithRequired(e => e.MakaleTur)
                .HasForeignKey(e => e.MakaleTuruNo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unvan>()
                .HasMany(e => e.Kullanici)
                .WithRequired(e => e.Unvan)
                .WillCascadeOnDelete(false);
        }
    }
}
