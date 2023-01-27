namespace MoleCs;

class Mole 
{
    int coordinate1;
    int coordinate2;
    
    public void MoleDigg(Mole digger, string[,] maze) 
    { 
        Random rand = new Random();
        // Рандомные координаты при генерации всегда должны быть чётными. Поэтому отправляем в генератор случайных чисел половинку от лабиринта с округлением в большую сторону. 
        int halfMazeX = 1 + maze.GetLength(0)/2;
        int halfMazeY = 1 + maze.GetLength(1)/2;
        digger.coordinate1 = GenerateDigit(rand, halfMazeX)*2; 
        digger.coordinate2 = GenerateDigit(rand, halfMazeY)*2;

        if (maze[digger.coordinate1, digger.coordinate2] == "#####") 
        {
            Move(maze, digger.coordinate1, digger.coordinate2);
        }
    }

    void Move(string[,] maze, int coordinate1, int coordinate2) 
    {
        Random rand = new Random();
        int arbiter = GenerateDigit(rand, 5);

        if (arbiter == 0 && coordinate1-2 > 0) 
        {
            coordinate1 = coordinate1-2;
            maze[coordinate1, coordinate2] = " ";
            maze[coordinate1-1, coordinate2] = " ";
            maze[coordinate1-2, coordinate2] = " ";
            coordinate1 = coordinate1-2;
            Move(maze, coordinate1, coordinate2);
        }
        if (arbiter == 1 && coordinate1+2 < 21) 
        {
            maze[coordinate1, coordinate2] = " ";
            maze[coordinate1+1, coordinate2] = " ";
            maze[coordinate1+2, coordinate2] = " ";
            coordinate1 = coordinate1+2;
            Move(maze, coordinate1, coordinate2);
        }
        if (arbiter == 2 && coordinate2-2 > 0) 
        {
            maze[coordinate1, coordinate2] = " ";
            maze[coordinate1, coordinate2-1] = " ";
            maze[coordinate1, coordinate2-2] = " ";
            coordinate2 = coordinate2-2;
            Move(maze, coordinate1, coordinate2);
        }
        if (arbiter == 3 && coordinate2+2 < 21) 
        {
            maze[coordinate1, coordinate2] = " ";
            maze[coordinate1, coordinate2+1] = " ";
            maze[coordinate1, coordinate2+2] = " ";
            coordinate2 = coordinate2+2;
            Move(maze, coordinate1, coordinate2);
        }
    }
    // Метод для генерации рандомного числа
    static int GenerateDigit(Random rng, int nums)
    {
        return rng.Next(nums);
    }
}