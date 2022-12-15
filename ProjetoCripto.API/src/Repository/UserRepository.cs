using Microsoft.EntityFrameworkCore;
using ProjetoCripto.API.src.Data;
using ProjetoCripto.API.src.Interfaces;
using ProjetoCripto.API.src.Models;
using ProjetoCripto.API.src.Models.Requests;
using ProjetoCripto.API.src.Models.Responses;

namespace ProjetoCripto.API.src.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<User> RegisterUser(User user)
        {
            _context.Usuarios.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> LoginUser(LoginUserRequest request)
        {
            var response = await _context.Usuarios.ToListAsync();

            return response.Where(x => x.Email == request.Email && x.Password == request.Password).FirstOrDefault();
        }
    }
}
