﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UmotaEInvoice.Server.Data.Models
{
    public partial class SisKullaniciHaklari
    {
        public string KullaniciKodu { get; set; }
        public int MenuId { get; set; }
        public string HakTipi { get; set; }
    }
}
