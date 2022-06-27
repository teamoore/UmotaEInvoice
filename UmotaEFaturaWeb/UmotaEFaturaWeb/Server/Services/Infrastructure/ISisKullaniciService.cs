using UmotaEFaturaWeb.Shared.ModelDto.Request;
using UmotaEFaturaWeb.Shared.ModelDto.Response;

namespace UmotaEFaturaWeb.Server.Services.Infrastructure
{
    public interface ISisKullaniciService
    {
        Task<SisKullaniciLoginResponseDto> Login(SisKullaniciLoginRequestDto request);
    }
}
