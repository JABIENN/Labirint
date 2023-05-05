using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    internal class FrstAid : ILabirintPart  
    {
        public void DrawObject()
        {
            Console.BackgroundColor = Consts.AidBackgroundColor;
            Console.ForegroundColor = Consts.AidForegroundColor;

            Console.Write(Consts.AidSymbol);
        }
    }
}
