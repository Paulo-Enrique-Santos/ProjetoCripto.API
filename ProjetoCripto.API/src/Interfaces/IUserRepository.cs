using ProjetoCripto.API.src.Models;
using ProjetoCripto.API.src.Models.Requests;
using ProjetoCripto.API.src.Models.Responses;

namespace ProjetoCripto.API.src.Interfaces
{
    public interface IUserRepository
    {
        Task<User> RegisterUser(User request);
        Task<User> LoginUser(LoginUserRequest request);
    }
}
