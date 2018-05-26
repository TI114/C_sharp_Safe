using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace safe
{
    public class Safe : Subject
    {
        private string password = "geheim-1";

        private IState status;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Safe()
        {
            status.SafeClose(this);
        }

        public Safe (String password)
        {
            if (ValidatePassword(password))
            {
                Password = password;
            }

            status.SafeClose(this);
        }

        private Boolean ValidatePassword(String password)
        {
            if (password.Length >= 8 && password.Any(char.IsDigit) && password.Any(char.IsLetter) && Regex.IsMatch(password, @"\W"))
            {
                return true;
            }
            return false;
        }
    }
}
