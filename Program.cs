using PointCs;
using MazeCs;
using MoleCs;
Main();

void Main() 
{
    Maze mazeNew = new Maze();
    mazeNew.CreateMaze(mazeNew.matrix);
    int count = 100000;
    while (count > 0) {
        Mole digger = new Mole();
        digger.MoleDigg(digger, mazeNew.matrix);
        count--;
    }
    Point point1 = new Point();
    point1.x = 3;
    point1.y = 3;
    point1.count = 1;
    point1.WaveAlgoritm(mazeNew.matrix, point1);
    mazeNew.PrintMaze(mazeNew.matrix);
}
