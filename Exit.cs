using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    internal class Exit : ILabirintPart
    {
        public void DrawObject()
        {
            Console.BackgroundColor = Consts.ExitBackgroundColor;
            Console.ForegroundColor = Consts.ExitForegroundColor;

            Console.Write(Consts.ExitSymbol);
        }
    }
}
