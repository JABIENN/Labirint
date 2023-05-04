using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    internal class Trap : ILabirintPart
    {
        public int damage = 60;

        public void DrawObject()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(' ');
        }

        public void PushOnTrap(ref Person person)
        {
            person.hp -= damage;
        }
    }
}
