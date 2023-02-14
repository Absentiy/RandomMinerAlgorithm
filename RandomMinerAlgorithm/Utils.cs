using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMinerAlgorithm
{
    public static class Utils
    {
        public static Vector2D GetRandomDirection(Random rn)
        {
            Vector2D res = Vector2D.Empty;

            int v = rn.Next(0, 4);
			switch (v)
			{
				case 0: //up
					res = Vector2D.Up;
					break;

				case 1: //down
					res = Vector2D.Down;
					break;

				case 2: //right
					res = Vector2D.Right;
					break;

				case 3: //left
					res = Vector2D.Left;
					break;

				default:
					break;
			}

			return res;
        }

		/// <summary>
		/// Maps a value from one range to another
		/// </summary>
		/// <param name="minSource">min value of the first range</param>
		/// <param name="maxSource">max value of the first range</param>
		/// <param name="minTarget">min value of the range to map to</param>
		/// <param name="maxTarget">max value of the range to map to</param>
		/// <param name="value">value to map</param>
		/// <returns><paramref name="value"/> transformed from the source range to target range</returns>
		public static decimal Map(decimal minSource, decimal maxSource, decimal minTarget, decimal maxTarget, decimal value)
		{
			return (value - minSource) / (maxSource - minSource) * (maxTarget - minTarget) + minTarget;
		}

	}
}
