using System.Linq.Expressions;

namespace KrestikiNoliki
{
    static class Consts
    {
        public const int LabirinthHeight = 15;
        public const int LabirinthWidth = 10;

        public const char PersonSymbol = '0';

        public const int maxHp = 100;

        public const ConsoleColor PersonBackgroundColor = ConsoleColor.DarkYellow;
        public const ConsoleColor PersonForegroundColor = ConsoleColor.White;

        public const ConsoleColor WallBackgroundColor = ConsoleColor.Black;
        public const ConsoleColor WallForegroundColor = ConsoleColor.DarkCyan;

        public const ConsoleColor ExitBackgroundColor = ConsoleColor.White;
        public const ConsoleColor ExitForegroundColor = ConsoleColor.Cyan;

        public const char WallSymbol = '#';

        public const ConsoleColor EmptySpace = ConsoleColor.Gray;

        public const char ExitSymbol = 'f';

        public const int WallFrequency = 27;

        public const int TrapFrequency = 6;

        public const int NrgticsFrequency = 3;

        public const char NrgSymbol = '|';

        public const ConsoleColor NrgBackgroundColor = ConsoleColor.Magenta;

        public const ConsoleColor NrgForegroundColor = ConsoleColor.Yellow;

        public const int MaxPower = 100;

        public const char AidSymbol = '+';

        public const int AidFrequency = 1;

        public const ConsoleColor AidBackgroundColor = ConsoleColor.White;

        public const ConsoleColor AidForegroundColor = ConsoleColor.Red;
    }
}

