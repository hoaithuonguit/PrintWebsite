using Data.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WebsileBL.Abstract
{
    public interface IUser
    {
        String CreateUser(String _username,
                          String _password,
                          String _address,
                          String _phoneNo,
                          String _email,
                          int _role);
        UserLoginResponseDto Login(String _username,
                                    String _password);

    }
}
