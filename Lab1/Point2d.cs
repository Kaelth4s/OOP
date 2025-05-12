namespace OOP.Lab1
{
    public class Point2d
    {
        // const
        private const int _WIDTH = 20;
        private const int _HEIGHT = 20;

        // fields
        private int _x;
        private int _y;

        // properties
        public int X
        {
            get { return _x; }
            set
            {
                if (value >= 0 && value <= _WIDTH) _x = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

        public int Y
        {
            get { return _y; }
            set
            {
                if (value >= 0 && value <= _HEIGHT) _y = value;
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
            return "Точка с координатами x: " + _x.ToString() + ", y: " + _y.ToString();
        }

        public string ToStringRepresents()
        {
            return "Point2d(" + _x.ToString() + ", " + _y.ToString() + ")";
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
