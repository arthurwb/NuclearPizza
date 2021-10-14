using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearPizza
{
    class HarshaDam : TellSteve
    {
        public void callSteve()
        {
            Console.WriteLine("things are not going well at the dam, can you come down and check it out for me?");
        }

        public void callSteve(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
