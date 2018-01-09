using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usersEmails = new Dictionary<string, string>();
            string[] domains = {".uk", ".us"};
            string usersName = Console.ReadLine();

            while (!usersName.Equals("stop"))
            {
                string userEmail = Console.ReadLine();
                usersEmails.Add(usersName, userEmail);
                usersName = Console.ReadLine();
            }

            RemoveEmailsByDom(usersEmails, domains);

            foreach (var printForm in usersEmails)
            {
                Console.WriteLine($"{printForm.Key} -> {printForm.Value}");
            }
        }

        private static void RemoveEmailsByDom(Dictionary<string, string> usersEmails, string[] domains)
        {
            foreach (var domain in domains)
            {
                var filteredEmail = usersEmails.Where(x => x.Value.EndsWith(domain)).ToList();
                foreach (var userEntry in filteredEmail )
                {
                    usersEmails.Remove(userEntry.Key);
                }
            }    
        }
    }
}
