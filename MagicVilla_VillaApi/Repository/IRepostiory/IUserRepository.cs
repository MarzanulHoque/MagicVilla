using MagicVilla_VillaApi.Models.Dto;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaApi.Models;

namespace MagicVilla_VillaApi.Repository.IRepostiory
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}
