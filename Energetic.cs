using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    internal class Energetic : ILabirintPart
    {
        public void DrawObject()
        {
            Console.BackgroundColor = Consts.NrgBackgroundColor;
            Console.ForegroundColor = Consts.NrgForegroundColor;

            Console.Write(Consts.NrgSymbol);
        }
    }
}
