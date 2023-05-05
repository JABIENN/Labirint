using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{

    class Person : ILabirintPart
    {

        private int _hp;
        public int hp
        {
            get
            {
                return _hp;
            }

            set
            {
                if (value >= Consts.maxHp) _hp = Consts.maxHp;
                if (value < 0) _hp = 0;
                else _hp = value;
            }
        }

        private int pwr
        {
            get 
            {
                return pwr;
            }
            set
            {
                if (pwr >= Consts.MaxPower) pwr = Consts.MaxPower;
                else pwr = value;
            }
                
        }

        private int armor;

        private List<Item> items;

        public char symbol;

        public ConsoleColor backgroundColor;
        public ConsoleColor foregroundColor;


        public Person()
        {
            items = new List<Item>();

            symbol = Consts.PersonSymbol;

            armor = 0;

            hp = Consts.maxHp;

            backgroundColor = Consts.PersonBackgroundColor;
            foregroundColor = Consts.PersonForegroundColor;

            symbol = Consts.PersonSymbol;
        }

        public void DrawObject()
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;

            Console.Write(symbol);
        }
    }
}
