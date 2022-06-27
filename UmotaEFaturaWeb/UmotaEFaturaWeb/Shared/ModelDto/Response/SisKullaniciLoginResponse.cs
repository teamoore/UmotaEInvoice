using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmotaEFaturaWeb.Shared.ModelDto.Response
{
    public class SisKullaniciLoginResponseDto
    {
        public string ApiToken { get; set; }

        public SisKullaniciDto KullaniciDto { get; set; }

        public List<SisFirmaDonemYetkiDto> KullaniciFirmaDonemYetkiListesi { get; set; }
    }
}
