using ProjetoCripto.API.src.Interfaces;
using ProjetoCripto.API.src.Models;
using ProjetoCripto.API.src.Models.Requests;
using ProjetoCripto.API.src.Models.Responses;
using ProjetoCripto.API.src.Repository;

namespace ProjetoCripto.API.src.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService (IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> RegisterUser(RegisterUserRequest request)
        {
            User user = new()
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
            };

            var result = await _userRepository.RegisterUser(user);
               
            return result;
        }
        public async Task<LoginUserResponse> LoginUser(LoginUserRequest request)
        {
            if (request.Email == null || request.Password == null)
            {
                return null;
            }

            LoginUserResponse login = new LoginUserResponse();
            var result = await _userRepository.LoginUser(request);

            if (result is not null)
            {
                login.Id = result.Id;
                login.Name = result.Name;
            }
            else
            {
                login.Error = "Usuário não encontrado";
            }

            return login;
        }
    }
}
