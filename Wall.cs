using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    internal class Wall : ILabirintPart
    {
        public void DrawObject()
        {
            Console.BackgroundColor = Consts.WallBackgroundColor;
            Console.ForegroundColor = Consts.WallForegroundColor;

            Console.Write(Consts.WallSymbol);
        }
    }
}
