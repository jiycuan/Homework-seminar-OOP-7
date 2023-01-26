namespace MazeCs;

public class Maze 
{
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
