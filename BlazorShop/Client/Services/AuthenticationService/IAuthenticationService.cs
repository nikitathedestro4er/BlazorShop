using System.Threading.Tasks;
using BlazorShop.Shared.DTO;

namespace BlazorShop.Client.Services.AuthenticationService
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDto> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<AuthResponseDto> Login(UserForAuthenticationDto userForAuthentication);
        Task Logout();
    }
}