using System;

namespace GEARS.Models
{
    public class LoginInfo
    {
        public String Username, Password;

        public LoginInfo()
        {
        }

        public LoginInfo(String username, String password)
        {
            Username = username;
            Password = password;
        }
    }
}