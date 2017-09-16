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
        static void Main(string[] args)
        {
            CheckDomain d = new CheckDomain("pi.a.no.s.verg.ie@gmail.com", "375trance");
            Thread.Sleep(2000);
           
            var domains = new ReadDomain().GetDomain();

            foreach (string domain in domains)
            {
                d.CheckThisDomain($"{domain}/get/direct",domain.Replace("http://",""));
            }
        }
    }
}
