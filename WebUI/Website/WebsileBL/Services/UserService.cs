using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dto;
using WebsileBL.Abstract;

namespace WebsileBL.Services
{
    public class UserService : IUser
    {
        public string CreateUser(string _username, string _password, string _address, string _phoneNo, string _email, int _role)
        {
            throw new NotImplementedException();
        }

        public UserLoginResponseDto Login(string _username, string _password)
        {
            throw new NotImplementedException();
        }
    }
}
