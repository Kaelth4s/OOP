namespace OOP.Lab1
{
    public class Point2d
    {
        // statics readonly
        public static readonly int WIDTH = 20;
        public static readonly int HEIGHT = 20;

        // fields
        private int _x;
        private int _y;

        // properties
        public int X
        {
            get { return _x; }
            set
            {
                if (value >= 0 && value <= WIDTH) _x = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                if (value >= 0 && value <= HEIGHT) _y = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        // constructors
        public Point2d(int x, int y)
        {
            X = x;
            Y = y;
        }

        // methods
        public override string ToString()
        {
            return $"Point2d({_x}, {_y})";
        }

        // static methods
        public static bool operator !=(Point2d leftPoint, Point2d rightPoint)
        {
            return leftPoint.X != rightPoint.X || leftPoint.Y != rightPoint.Y;
        }

        public static bool operator ==(Point2d leftPoint, Point2d rightPoint)
        {
            return leftPoint.X == rightPoint.X && leftPoint.Y == rightPoint.Y;
        }
    }
}
