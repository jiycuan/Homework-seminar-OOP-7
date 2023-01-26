/*
void createMaze(string[,] maze) {
    for (int i = 0; i < maze.GetLength(0); i++) {
        for (int j = 0; j < maze.GetLength(1); j++) {
            maze[i, j] = "#";
        }
    }
}

void printMaze(string[,] maze) {
    for (int i = 0; i < maze.GetLength(0); i++) {
        for (int j = 0; j < maze.GetLength(1); j++) {
            Console.Write($"{maze[i, j]}" + "\t");
        }
    Console.WriteLine();
    }
}


void mole(string[,] maze) { 
    Random rand = new Random();    
    int coordinate1 = new Random().Next(1,11)*2;
    int coordinate2 = new Random().Next(1,11)*2;

    if (maze[coordinate1, coordinate2] == "#") {
        move(maze, coordinate1, coordinate2);
    }
}

void move(string[,] maze, int coordinate1, int coordinate2) {

    Random rand = new Random();
    int arbiter = new Random().Next(1,5);

    if (arbiter == 0 && coordinate1-2 > 0) {
        coordinate1 = coordinate1-2;
        maze[coordinate1, coordinate2] = " ";
        maze[coordinate1-1, coordinate2] = " ";
        maze[coordinate1-2, coordinate2] = " ";
        coordinate1 = coordinate1-2;
        move(maze, coordinate1, coordinate2);
    }
    if (arbiter == 1 && coordinate1+2 < 21) {
        maze[coordinate1, coordinate2] = " ";
        maze[coordinate1+1, coordinate2] = " ";
        maze[coordinate1+2, coordinate2] = " ";
        coordinate1 = coordinate1+2;
        move(maze, coordinate1, coordinate2);
    }
    if (arbiter == 2 && coordinate2-2 > 0) {
        maze[coordinate1, coordinate2] = " ";
        maze[coordinate1, coordinate2-1] = " ";
        maze[coordinate1, coordinate2-2] = " ";
        coordinate2 = coordinate2-2;
        move(maze, coordinate1, coordinate2);
    }
    if (arbiter == 3 && coordinate2+2 < 21) {
        maze[coordinate1, coordinate2] = " ";
        maze[coordinate1, coordinate2+1] = " ";
        maze[coordinate1, coordinate2+2] = " ";
        coordinate2 = coordinate2+2;
        move(maze, coordinate1, coordinate2);
    }
}

void waveAlgoritm(string[,] maze) {
        
        Point point1 = new Point();
        point1.x = 2;
        point1.y = 2;
        point1.count = 1;
        var coordinate = new Queue<Point>();
        coordinate.Enqueue(point1);
        maze[point1.x, point1.y] = "S"; // Обозначаем начало лабиринта
        maze[maze.GetLength(0)-2, maze.GetLength(1)-2] = "E"; // Обозначаем конец
        
        while (coordinate.Count > 0) {
            wavePlus(maze, coordinate);
        }
    }

void wavePlus(string[,] maze, Queue<Point> coordinate) {
    Point point = coordinate.Dequeue();
    if (maze[point.x+1, point.y] == " " && point.x+1 < maze.GetLength(0)-1) {
        maze[point.x+1, point.y] = point.count.ToString();
        Point pointRight = new Point();
        pointRight.x = point.x+1;
        pointRight.y = point.y;
        pointRight.count = point.count+1;
        coordinate.Enqueue(pointRight);
    }
    if (maze[point.x, point.y-1] == " " && point.y-1 > 0) {
        maze[point.x, point.y-1] = point.count.ToString();
        Point pointDown = new Point();
        pointDown.x = point.x;
        pointDown.y = point.y-1;
        pointDown.count = point.count+1;
        coordinate.Enqueue(pointDown);
    }
    if (maze[point.x-1, point.y] == " " && point.x-1 > 0) {
        maze[point.x-1, point.y] = point.count.ToString();
        Point pointLeft = new Point();
        pointLeft.x = point.x-1;
        pointLeft.y = point.y;
        pointLeft.count = point.count+1;
        coordinate.Enqueue(pointLeft);
    }
    if (maze[point.x, point.y+1] == " " && point.y+1 < maze.GetLength(1)-1) {
        maze[point.x, point.y+1] = point.count.ToString();
        Point pointUp = new Point();
        pointUp.x = point.x;
        pointUp.y = point.y+1;
        pointUp.count = point.count+1;
        coordinate.Enqueue(pointUp);
    }        
}
*/