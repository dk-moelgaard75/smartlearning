using System.Threading.Tasks;
using TicTacToe2.Models;

namespace TicTacToe2.Services
{
    public interface IUserServices
    {
        Task<bool> RegisterUser(UserModel userModel);
    }
}