namespace PointCs;
class Point 
{
    public int x;
    public int y;
    public int count;

    
    public void WaveAlgoritm(string[,] maze, Point point1) 
    {
        var coordinate = new Queue<Point>();
        coordinate.Enqueue(point1);
        maze[point1.x, point1.y] = "S"; // Обозначаем начало лабиринта
        maze[maze.GetLength(0)-3, maze.GetLength(1)-3] = "E"; // Обозначаем конец
        
        while (coordinate.Count > 0) {
            WavePlus(maze, coordinate);
        }
    }

    void WavePlus(string[,] maze, Queue<Point> coordinate) 
    {
        Point point = coordinate.Dequeue();
        if (maze[point.x+1, point.y] == " " && point.x+1 < maze.GetLength(0)-1) 
        {
            maze[point.x+1, point.y] = point.count.ToString();
            Point pointRight = new Point();
            pointRight.x = point.x+1;
            pointRight.y = point.y;
            pointRight.count = point.count+1;
            coordinate.Enqueue(pointRight);
        }
        if (maze[point.x, point.y-1] == " " && point.y-1 > 0) 
        {
            maze[point.x, point.y-1] = point.count.ToString();
            Point pointDown = new Point();
            pointDown.x = point.x;
            pointDown.y = point.y-1;
            pointDown.count = point.count+1;
            coordinate.Enqueue(pointDown);
        }
        if (maze[point.x-1, point.y] == " " && point.x-1 > 0) 
        {
            maze[point.x-1, point.y] = point.count.ToString();
            Point pointLeft = new Point();
            pointLeft.x = point.x-1;
            pointLeft.y = point.y;
            pointLeft.count = point.count+1;
            coordinate.Enqueue(pointLeft);
        }
        if (maze[point.x, point.y+1] == " " && point.y+1 < maze.GetLength(1)-1) 
        {
            maze[point.x, point.y+1] = point.count.ToString();
            Point pointUp = new Point();
            pointUp.x = point.x;
            pointUp.y = point.y+1;
            pointUp.count = point.count+1;
            coordinate.Enqueue(pointUp);
        }        
    }
}


