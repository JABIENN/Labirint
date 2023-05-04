using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    internal class EmptySpace : ILabirintPart
    {

        public void DrawObject()
        {
            Console.BackgroundColor = Consts.EmptySpace;
            Console.Write(' ');
        }
    }

}
