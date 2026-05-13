
using BlazorAppSeuz.Models;

namespace BlazorAppSeuz.IServices
{
    public interface IUserService
    {
        Task<Tusuarios> GetByUsernameAsync(string username);
        Task<Tusuarios?> LoginAsync(string username, string password);
        Task<List<Tusuarios>> GetAllAsync();
        Task<bool> UpdateAsync(Tusuarios user);
        Task UpdatePasswordAsync(string id, string password);
    }
}
