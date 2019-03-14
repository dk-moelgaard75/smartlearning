using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe2.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public System.DateTime? EmailConfirmationDate { get; set; }
        public int Score { get; set; }

    }
}
