using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrestikiNoliki
{
    class Logic
    {

        public ILabirintPart[,] map;

        private Input input;

        private short horInp, verInp;

        private int coordX, coordY;

        private bool isRunning;

        private int height, width;

        private Person person;

        public Logic(int height, int width)
        {
            this.height = height;
            this.width = width;

            map = new ILabirintPart[height, width];

            isRunning = true;
            input = new Input();

            person = new Person();
        }

        public void GameCycle()
        {
            GenerateMap();

            do
            {
                Draw.DrawMap(map, height, width);

                GetDirection(input.GetInput());

                TryMove();

                IsAlive();
            }while (isRunning);
        }

        public static void NewGame(out Logic logic)
        {
            logic = new Logic(Consts.LabirinthHeight, Consts.LabirinthWidth);

            logic.GameCycle();
        }

        void IsAlive()
        {
            if(person.hp < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("");
                Console.WriteLine("You Died");

            }
        }

        private void GetDirection(char inp)
        {
            horInp = 0;
            verInp = 0;

            inp = char.ToLower(inp);

            switch (inp)
            {
                case 's':
                    verInp = 1;
                    break;

                case 'd':
                    horInp = 1;
                    break;

                case 'w':
                    verInp = -1;
                    break;

                case 'a':
                    horInp = -1;
                    break;
            }
        }

        public void TryMove()
        {
            var cellType = (map[coordY + verInp, coordX + horInp]);

            switch (cellType)
            {
                case Exit exit:
                    isRunning = false;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.White;

                    Console.WriteLine("");
                    Console.WriteLine("You Finished");
                    break;
                case Trap trap:
                    trap.PushOnTrap(ref person); 
                    break;
                case Wall wall:
                    break;
                case EmptySpace space:
                    Move();
                    break;
                default: 
                    break;
            }
        }

        public void Move()
        {
            map[coordY + verInp, coordX + horInp] = person;
            map[coordY, coordX] = new EmptySpace();

            coordY += verInp;
            coordX += horInp;
        }

        public void GenerateMap()
        {
            Random random = new Random();

            GenerateWalls(random);
            GeneratePerson(random);
            GenerateExit(random);
        }

        void GenerateWalls(Random random)
        {
            for(int i = 0; i < height; i++) 
            {
                for(int j = 0; j < width; j++)
                {
                    int num = random.Next(0, 100);

                    if (num <= Consts.WallFrequency)
                        map[i, j] = new Wall();

                    else if (num <= Consts.TrapFrequency)
                        map[i, j] = new Trap();

                    else map[i, j] = new EmptySpace();
                }
            }
        }

        void GeneratePerson(Random random)
        {
            int y = random.Next(0, height);
            int x = random.Next(0, width);

            if (map[y, x].GetType() != typeof(Exit))
            {
                map[y, x] = person;
                coordX = x;
                coordY = y;
            }
            else GeneratePerson(random);
        }

        void GenerateExit(Random random)
        {
            int y = random.Next(0, height);
            int x = random.Next(0, width);

            if (map[y, x].GetType() != typeof(Person))
            {
                map[y, x] = new Exit();
            }
            else GenerateExit(random);
        }

 
    }
}
