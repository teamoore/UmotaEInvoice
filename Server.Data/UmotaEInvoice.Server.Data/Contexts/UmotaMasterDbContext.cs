using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmotaEInvoice.Server.Data.Models;

namespace UmotaEInvoice.Server.Data.Contexts
{
    public partial class UmotaMasterDbContext : DbContext
    {
        public UmotaMasterDbContext()
        {
        }

        public UmotaMasterDbContext(DbContextOptions<UmotaMasterDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SisFirma> SisFirmas { get; set; }
        public virtual DbSet<SisFirmaDonem> SisFirmaDonems { get; set; }
        public virtual DbSet<SisFirmaDonemYetki> SisFirmaDonemYetkis { get; set; }
        
        public virtual DbSet<SisKullanici> SisKullanicis { get; set; }
        public virtual DbSet<SisKullaniciHaklari> SisKullaniciHaklaris { get; set; }
        public virtual DbSet<SisKullaniciYetkiKodlari> SisKullaniciYetkiKodlaris { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=TIMURGUNDOGDU\\SQLEXPRESS;Database=UmotaUnoPazar;user=umota; password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SisFirma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sis_firma");

                entity.Property(e => e.FirmaAdi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firma_adi");

                entity.Property(e => e.FirmaNo)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("firma_no");

                entity.Property(e => e.LogoCariKart).HasColumnName("logo_cari_kart");

                entity.Property(e => e.LogoFirmaNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("logo_firma_no");

                entity.Property(e => e.LogoHizmetKart).HasColumnName("logo_hizmet_kart");

                entity.Property(e => e.LogoStokKart).HasColumnName("logo_stok_kart");

            });

            modelBuilder.Entity<SisFirmaDonem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sis_firma_donem");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aciklama");

                entity.Property(e => e.FirmaNo).HasColumnName("firma_no");

                entity.Property(e => e.LogoDonem).HasColumnName("logo_donem");

                entity.Property(e => e.LogoFirma).HasColumnName("logo_firma");

                entity.Property(e => e.Logref).HasColumnName("logref");

                entity.Property(e => e.Ondeger).HasColumnName("ondeger");

                entity.Property(e => e.Yil).HasColumnName("yil");
            });

            modelBuilder.Entity<SisFirmaDonemYetki>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sis_firma_donem_yetki");

                entity.Property(e => e.Donemref).HasColumnName("donemref");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("kodu");

                entity.Property(e => e.Logref)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("logref");

                entity.Property(e => e.Tur).HasColumnName("tur");
            });

            modelBuilder.Entity<SisKullanici>(entity =>
            {
                entity.HasKey(e => e.KullaniciKodu)
                    .HasName("pk_sis_kullanici");

                entity.ToTable("sis_kullanici");

                entity.Property(e => e.KullaniciAdi)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kullanici_adi");

                entity.Property(e => e.KullaniciAktif).HasColumnName("kullanici_aktif");

                entity.Property(e => e.KullaniciIptal).HasColumnName("kullanici_iptal");

                entity.Property(e => e.KullaniciKodu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("kullanici_kodu");

                entity.Property(e => e.KullaniciMenuProfil).HasColumnName("kullanici_menu_profil");

                entity.Property(e => e.KullaniciPcadi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("kullanici_pcadi");

                entity.Property(e => e.KullaniciSifre)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("kullanici_sifre");

                entity.Property(e => e.KullaniciYetkiKodu)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kullanici_yetki_kodu");

                entity.Property(e => e.LogoPassword)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("logo_password");

                entity.Property(e => e.LogoUsername)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("logo_username");

                entity.Property(e => e.MailAdres)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mail_adres");

                entity.Property(e => e.MailHost)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mail_host");

                entity.Property(e => e.MailImza)
                    .HasColumnType("text")
                    .HasColumnName("mail_imza");

                entity.Property(e => e.MailKullanici)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mail_kullanici");

                entity.Property(e => e.MailSifre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mail_sifre");

                entity.Property(e => e.SonGirisTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("son_giris_tarihi");
            });

            modelBuilder.Entity<SisKullaniciHaklari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sis_kullanici_haklari");

                entity.Property(e => e.HakTipi)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("hak_tipi")
                    .IsFixedLength(true);

                entity.Property(e => e.KullaniciKodu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("kullanici_kodu");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");
            });

            modelBuilder.Entity<SisKullaniciYetkiKodlari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sis_kullanici_yetki_kodlari");

                entity.Property(e => e.KullaniciKodu)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("kullanici_kodu");

                entity.Property(e => e.YetkiKodu)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("yetki_kodu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
