using ProjetoCripto.API.src.Models;
using ProjetoCripto.API.src.Models.Requests;
using ProjetoCripto.API.src.Models.Responses;

namespace ProjetoCripto.API.src.Interfaces
{
    public interface IUserService
    {
        Task<User> RegisterUser(RegisterUserRequest request);
        Task<LoginUserResponse> LoginUser(LoginUserRequest request);
    }
}
