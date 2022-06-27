﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaEFaturaWeb.Shared.ModelDto
{
    public partial class SisKullaniciDto
    {
        public string KullaniciKodu { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public bool KullaniciAktif { get; set; }
        public bool KullaniciIptal { get; set; }
        public string KullaniciYetkiKodu { get; set; }
        public string KullaniciPcadi { get; set; }
        public int? KullaniciMenuProfil { get; set; }
        public DateTime? SonGirisTarihi { get; set; }
        public string MailHost { get; set; }
        public string MailAdres { get; set; }
        public string MailKullanici { get; set; }
        public string MailSifre { get; set; }
        public string MailImza { get; set; }
        public string LogoUsername { get; set; }
        public string LogoPassword { get; set; }
        public string WebSifre { get; set; }
    }
}
