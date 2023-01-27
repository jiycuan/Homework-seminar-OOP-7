namespace PointCs;
class Point 
{
    int x;
    int y;
    int count;

    public Point(int num1, int num2, int num3)
    {
        x = num1;
        y = num2;
        count = num3;
    }
    public void WaveAlgoritm(string[,] maze, Point point1) 
    {
        var coordinate = new Queue<Point>();
        coordinate.Enqueue(point1);
        maze[point1.x, point1.y] = "S"; // Обозначаем начало лабиринта
        maze[maze.GetLength(0)-3, maze.GetLength(1)-3] = "E"; // Обозначаем конец
        
        while (coordinate.Count > 0) 
        {
            WavePlus(maze, coordinate);
        }
    }

    void WavePlus(string[,] maze, Queue<Point> coordinate) 
    {
        Point point = coordinate.Dequeue();
        if (maze[point.x+1, point.y] == " " && point.x+1 < maze.GetLength(0)-1) 
        {
            maze[point.x+1, point.y] = point.count.ToString();
            Point pointRight = new Point(point.x+1, point.y, point.count+1);
            coordinate.Enqueue(pointRight);
        }
        if (maze[point.x, point.y-1] == " " && point.y-1 > 0) 
        {
            maze[point.x, point.y-1] = point.count.ToString();
            Point pointDown = new Point(point.x, point.y-1, point.count+1);
            coordinate.Enqueue(pointDown);
        }
        if (maze[point.x-1, point.y] == " " && point.x-1 > 0) 
        {
            maze[point.x-1, point.y] = point.count.ToString();
            Point pointLeft = new Point(point.x-1, point.y, point.count+1);
            coordinate.Enqueue(pointLeft);
        }
        if (maze[point.x, point.y+1] == " " && point.y+1 < maze.GetLength(1)-1) 
        {
            maze[point.x, point.y+1] = point.count.ToString();
            Point pointUp = new Point(point.x, point.y+1, point.count+1);
            coordinate.Enqueue(pointUp);
        }        
    }
}


