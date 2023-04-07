using System.Security;

class Program
{
    public static void Main(string[] args)
    {

    }
}



class Draw
{
    public void DrawMap(char[,] map, int height, int width) 
    { 
        int mapdraw = 0;
        for(int i = 0;  i < height; i++)
        {
            for (int j = 0; j < width; j++) 
            {
                mapdraw = map[i, j];
            }
        }
    }
}


class Input
{
    private char prevInp = ' ';

    public char GetInput()
    {
        prevInp = Console.ReadLine().ToCharArray()[0];
        return prevInp;
    }
}


class Logic
{

    public char[,] map;

    private Input input;

    private short horInp, verInp;

    private int coordX, coordY;

    private bool isRunning;

    private int height, width;

    public Logic(int height, int width)
    {
        this.height = height;
        this.width = width;
    }

    public void GameCycle()
    {
        while (isRunning)
        {
            GetDirection(input.GetInput());

            TryMove();

            draw.DrawMap(map, width, height);
        }
    }

    private void GetDirection(char inp)
    {
        horInp = 0;
        verInp = 0;

        switch(inp)
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
        if (map[coordY + verInp, coordX + horInp] == 'f') isRunning = false;

        if (map[coordY + verInp, coordX + horInp] != '#') Move();
    }

    public void Move()
    {
        map[coordY + verInp, coordX + horInp] = '0';
        map[coordY, coordX] = ' ';

        coordY += verInp;
        coordX += horInp;
    }

    public void GenerateMap()
    {
        int freq = 100;
        Random random = new Random();
        freq *= random.Next();

        map[0, 0] = 'f';
        map[height - 1, width - 1] = '0';
    }
}
