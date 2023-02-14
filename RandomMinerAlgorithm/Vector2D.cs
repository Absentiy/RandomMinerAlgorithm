using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMinerAlgorithm
{
	public class Vector2D
	{
		public static readonly Vector2D Empty = new Vector2D(0, 0);

		public static Vector2D Up => new Vector2D(0, 1);
		public static Vector2D Down => new Vector2D(0, -1);
		public static Vector2D Right => new Vector2D(1, 0);
		public static Vector2D Left => new Vector2D(-1, 0);

		public Vector2D()
		{

		}

		public Vector2D(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int X { get; set; }

		public int Y { get; set; }

		public static Vector2D operator -(Vector2D vector)
		{
			return new Vector2D(-vector.X, -vector.Y);
		}

		public static bool operator ==(Vector2D vector1, Vector2D vector2)
		{
			return vector1.X == vector2.X && vector1.Y == vector2.Y;
		}

		public static bool operator !=(Vector2D vector1, Vector2D vector2)
		{
			return !(vector1 == vector2);
		}

		public static Point operator +(Point point, Vector2D vector2)
		{
			return new Point(point.X + vector2.X, point.Y + vector2.Y);
		}

        public override string ToString()
        {
			return $"{X};{Y}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
