using System.Threading.Tasks;
using FinalProject.Entities;

public interface IAuthService
{
    Task<User> Login(string username, string password);
    Task<User> Register(User user, string password);
    Task<User> ChangePass(string username, string oldPassword, string newPassword);
    Task<bool> UserExists(string username);
}
