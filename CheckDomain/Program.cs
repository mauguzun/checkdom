using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckDomain
{
    class Program
    {
        static  CheckDomain d;
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("email:password");
                string [] email = Console.ReadLine().Split(':');
                d = new CheckDomain(email[0].Trim(), email[1].Trim());
                Console.WriteLine("start ,y/n");
                string result =  Console.ReadLine();
                if (result.Trim().ToLower() == "y")
                    break;
            }


  
           
            var domains = new ReadDomain().GetDomain();

            foreach (string domain in domains)
            {
                d.CheckThisDomain($"{domain}/get/direct",domain.Replace("http://",""));
            }
        }
    }
}
