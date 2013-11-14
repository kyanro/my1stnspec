using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickMyAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            APIKicker apiKicker = new APIKicker("http://pppvm.cloudapp.net/words/getmorning2?time=2013-10-21T10%3A00%3A00&emotion=1");
            Console.Write(apiKicker.GetString());
        }
    }
}
