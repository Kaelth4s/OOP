namespace OOP.Lab1
{
    public class Vector2d
    {
        // fields
        private int _x;
        private int _y;

        // properties
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int this[int index]
        {
            get
            {
                if (index == 0) return _x;
                else if (index == 1) return _y;
                else throw new IndexOutOfRangeException();
            }

            set
            {
                if (index == 0) _x = value;
                else if (index == 1) _y = value;
                else throw new IndexOutOfRangeException();
            }
        }

        // constructors
        public Vector2d(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Vector2d(Point2d start, Point2d end)
        {
            _x = end.X - start.X;
            _y = end.Y - start.Y;
        }

        // methods
        public override string ToString()
        {
            return "Вектор с координатами x: " + _x.ToString() + ", y: " + _y.ToString();
        }

        public string ToStringRepresents()
        {
            return "Vector2d(" + _x.ToString() + ", " + _y.ToString() + ")";
        }

        public Vector2d Abs()
        {
            return new Vector2d(_x < 0 ? -_x : _x, _y < 0 ? -_y : _y);
        }

        public int Dot(Vector2d targetVector)
        {
            return _x * targetVector.X + _y * targetVector.Y;
        }

        public int CrossZ(Vector2d targetVector)
        {
            return _x * targetVector.Y - _y * targetVector.X;
        }

        public IEnumerator<int> GetEnumerator()
        {
            yield return _x;
            yield return _y;
        }


        // static methods
        public static int Dot(Vector2d a, Vector2d b)
        {
            return a.Dot(b);
        }

        public static int CrossZ(Vector2d a, Vector2d b)
        {
            return a.X * b.Y - a.Y * b.X;
        }

        public static int TripleProduct(Vector2d a, Vector2d b, Vector2d c)
        {
            return 0;
        }

        public static bool operator !=(Vector2d leftVector, Vector2d rightVector)
        {
            return leftVector.X != rightVector.X || leftVector.Y != rightVector.Y;
        }

        public static bool operator ==(Vector2d leftVector, Vector2d rightVector)
        {
            return leftVector.X == rightVector.X && leftVector.Y == rightVector.Y;
        }

        public static Vector2d operator +(Vector2d leftVector, Vector2d rightVector)
        {
            return new Vector2d(leftVector.X + rightVector.X, leftVector.Y + leftVector.Y);
        }

        public static Vector2d operator -(Vector2d leftVector, Vector2d rightVector)
        {
            return new Vector2d(leftVector.X - rightVector.X, leftVector.Y - leftVector.Y);
        }

        public static Vector2d operator *(Vector2d leftVector, int num)
        {
            return new Vector2d(leftVector.X * num, leftVector.Y * num);
        }

        public static Vector2d operator /(Vector2d leftVector, int num)
        {
            return new Vector2d(leftVector.X / num, leftVector.Y / num);
        }
    }
}
