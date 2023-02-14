using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMinerAlgorithm
{
    public class RandomMiner
    {
        public Point Position;

        public Vector2D Direction;

        private readonly Random rn = new Random();

        public RandomMiner()
        {
            Position = new Point(0, 0);
            Direction = Vector2D.Empty;
        }

        public int Move(ref int[,] field)
        {
            field[Position.X, Position.Y] = LevelConstants.PathCell;
            Position += Direction;

            if (Position.X <= 0 || Position.X >= field.GetLength(0)-1 || Position.Y <= 0 || Position.Y >= field.GetLength(1)-1)
            {
                return -1;
            }

            if (field[Position.X, Position.Y] == LevelConstants.PathCell && Direction != Vector2D.Empty)
            {
                return 1;
            }

            return 0;
        }

        public void SetDirection()
        {
            Vector2D res;
        Reprocess:;
            res = Utils.GetRandomDirection(rn);

            if (res == -Direction)
            {
                goto Reprocess;
            }

            Direction = res;
        }

        public List<RandomMiner> CreateChildren(int maxChildren)
        {
            if (maxChildren == 0 || maxChildren > 2)
            {
                return null;
            }

            List<RandomMiner> children = new List<RandomMiner>();
            List<Vector2D> vs = new List<Vector2D>();
            for (int i = 0; i < maxChildren; i++)
            {
                RandomMiner child = new RandomMiner()
                {
                    Position = this.Position
                };

                Vector2D dir;
            re:;
                dir = Utils.GetRandomDirection(rn);
                if (dir == -this.Direction || dir == this.Direction || vs.Contains(dir))
                {
                    goto re;
                }
                child.Direction = dir;
                vs.Add(dir);
                children.Add(child);
            }
            return children;
        }
    }
}
