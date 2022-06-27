using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaEFaturaWeb.Shared.ModelDto
{
    public class SisFirmaDonemYetkiDto
    {
        public int Logref { get; set; }
        public int? Donemref { get; set; }
        public byte? Tur { get; set; }
        public string Kodu { get; set; }
    }
}
