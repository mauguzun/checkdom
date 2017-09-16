using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CheckDomain
{
    class ReadDomain
    {
        public List<string> GetDomain()
        {
            
            try
            {
                return File.ReadAllLines("domain.txt").ToList();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return new List<string>();
            }
           
        }
    }
}
