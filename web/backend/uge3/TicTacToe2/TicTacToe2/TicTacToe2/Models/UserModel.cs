using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TicTacToe2.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        [Required()]
        public String FirstName { get; set; }
        [Required()]
        public String LastName { get; set; }
        [Required(), DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Required(), DataType(DataType.Password)]
        public String Password { get; set; }
        
        public bool IsEmailConfirmed { get; set; }
        public System.DateTime? EmailConfirmationDate { get; set; }
        public int? Score { get; set; }

    }
}
