using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordUtility;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            passwordHelper helper = new passwordHelper();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            var issue = helper.getPasswordIssue(password);

            if (issue.Count == 0)
            {
                Console.WriteLine("Password is correct");
            }
            else
            {
                Console.WriteLine("Weak Password. Password must ");
                foreach (var issues in issue)
                {
                    Console.WriteLine(issues);
                }
            }

            Console.WriteLine("Masked Password: " + helper.MaskPassword(password));
            Console.ReadLine();
        }
    }
}
