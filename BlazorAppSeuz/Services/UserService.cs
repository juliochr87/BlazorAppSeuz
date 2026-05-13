
using BlazorAppSeuz.IServices;
using BlazorAppSeuz.Data;
using BlazorAppSeuz.Models;
using Microsoft.EntityFrameworkCore;
namespace BlazorAppSeuz.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Tusuarios> GetByUsernameAsync(string username)
        {
            throw new Exception($"Error creando usuario:");
        }
        
        public async Task<Tusuarios?> LoginAsync(string username, string password)
        {
            var hexPassword = ToHex(password);

            return await _context.Tusuarios
                .AsNoTracking()
                .FirstOrDefaultAsync(x =>
                    x.UsuavIdusuario == username &&
                    x.UsuavPassword == hexPassword);
        }

        public async Task<List<Tusuarios>> GetAllAsync()
        {
            return await _context.Tusuarios
                .AsNoTracking()
                .ToListAsync();
        }
        
        public async Task<bool> UpdateAsync(Tusuarios user)
        {
            var existingUser = await _context.Tusuarios
                .FirstOrDefaultAsync(x => x.UsuavIdusuario == user.UsuavIdusuario);

            if (existingUser == null)
                return false;

            existingUser.UsuavNombre = user.UsuavNombre;
            existingUser.UsuavEmail = user.UsuavEmail;
            existingUser.UsuavMovil = user.UsuavMovil;

            // SOLO si viene valor nuevo
            if (!string.IsNullOrWhiteSpace(user.UsuavPassword) &&
                user.UsuavPassword != existingUser.UsuavPassword)
            {
                existingUser.UsuavPassword = ToHex(user.UsuavPassword);
            }

            await _context.SaveChangesAsync();
            return true;
        }
 
        public async Task UpdatePasswordAsync(string id, string password)
        {
            throw new Exception($"Error creando usuario: ");
        }
        
        private static string ToHex(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToHexString(bytes);
        }
    }
}
