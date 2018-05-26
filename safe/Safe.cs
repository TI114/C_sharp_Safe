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

        public IState GetStatus()
        {
            return status;
        }

        public void SetStatus(IState status)
        {
            this.status = status;
        }

        public Safe()
        {
            status = Close.GetInstance();
        }

        public Safe (String password)
        {
            if (ValidatePassword(password))
            {
                Password = password;
            }

            status = Close.GetInstance();
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
