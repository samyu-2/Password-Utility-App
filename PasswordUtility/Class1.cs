using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace PasswordUtility
{
  
    public class passwordHelper
    {
        public bool isStrongPassword(string password)
        {
            return getPasswordIssue(password).Count == 0;
        }

        public List<string> getPasswordIssue(string password)
        {
            var issue = new List<string>();

            if (string.IsNullOrEmpty(password))
            {
                issue.Add("Password cannot be empty ");
                return issue;
            }

            if(password.Length < 8)
            {
                issue.Add("be at least 8 character long ");
            }

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                issue.Add("contain at least one Captital letter ");
            }

            if (!Regex.IsMatch(password, @"\d"))
            {
                issue.Add("contain at least one digit ");
            }

            if (!Regex.IsMatch(password, @"[!@#$%&**_]"))
            {
                issue.Add("contain at least one special character ");
            }

            return issue;
        }

        public string MaskPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length <= 2)
                return password;

            string masked = new string('*', password.Length) + password.Substring(password.Length);
            return masked;
        }
    }
}
