namespace MazeCs;

public class Maze 
{
    // В рамках данной задачи работаем с лабиринтом 21 на 21, поэтому позволил себе некрасиво прописать матрицу 21 на 21 напрямую в классе.
    // Значение можно менять, но лабиринт работает только с нечетными матрицами. 
    public string[,] matrix = new string [21, 21];

    public void CreateMaze(string[,] maze) 
    {
        for (int i = 0; i < maze.GetLength(0); i++) 
        {
            for (int j = 0; j < maze.GetLength(1); j++) 
            {
                maze[i, j] = "#####";
            }
        }
    }   
    public void PrintMaze(string[,] maze) 
    {
        for (int i = 0; i < maze.GetLength(0); i++) 
        {
            for (int j = 0; j < maze.GetLength(1); j++) 
            {
                Console.Write($"{maze[i, j]}" + "\t");
            }
        Console.WriteLine();
        }
    }
}
