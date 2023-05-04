using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    static class Draw
    {
        public static void DrawMap(ILabirintPart[,] map, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    map[i, j].DrawObject();
                }
                Console.WriteLine("");
            }
        }
    }
}
