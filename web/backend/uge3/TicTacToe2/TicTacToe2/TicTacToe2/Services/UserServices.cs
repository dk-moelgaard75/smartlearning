using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace TicTacToe2.Services
{
    public class UserServices : IUserServices
    {
        public Task<bool>RegisterUser(Models.UserModel userModel)
        {
            return Task.FromResult(true);
        }
    }
}
