using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    class Input
    {
        private char prevInp = ' ';

        public char GetInput()
        {
            prevInp = Console.ReadLine().ToCharArray()[0];
            return prevInp;
        }
    }
}
