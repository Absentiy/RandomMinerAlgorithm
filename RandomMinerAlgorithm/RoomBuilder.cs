using System;
using System.Drawing;

namespace RandomMinerAlgorithm
{
    public class RoomBuilder
    {
        public int maxRoomSize = 4;
        public int minRoomSize = 2;

        public Point RoomCenter { get; set; }

        public Room Room { get; set; }

        private Random rand = new Random();

        public RoomBuilder()
        {
            RoomCenter = new Point();
        }

        public void BuildRoom(ref int[,] world, int worldWidth, int worldHeight)
        {
            Room = new Room();

            Size roomSize = new Size(rand.Next(minRoomSize, maxRoomSize), rand.Next(minRoomSize, maxRoomSize));

            int n = GetNeighbours(worldWidth, worldHeight, world);
            switch (n)
            {
                case 3:
                case 4:
                    roomSize = new Size(2, 2);
                    break;

                case 0:
                case 1:
                case 2:
                    return;

                default:
                    break;
            }

            Room = new Room()
            {
                Size = roomSize,
                Center = RoomCenter
            };

            for (int i = -roomSize.Height; i <= roomSize.Height; i++)
            {
                for (int j = -roomSize.Width; j <= roomSize.Width; j++)
                {
                    int x = RoomCenter.X + j;
                    int y = RoomCenter.Y + i;

                    if (x < 0 || x >= worldWidth || y < 0 || y >= worldHeight)
                    {
                        continue;
                    }

                    if(i == -roomSize.Height || j == -roomSize.Width || i == roomSize.Height || j == roomSize.Width)
                    {
                        if(world[x, y] != LevelConstants.PathCell && world[x, y] != LevelConstants.RoomFloorCell)
                        {
                            world[x, y] = LevelConstants.RoomWallCell;
                        }
                        else if (world[x, y] == LevelConstants.PathCell)
                        {
                            world[x, y] = LevelConstants.RoomFloorCell;
                        }

                    }
                    else
                    {
                        world[x, y] = LevelConstants.RoomFloorCell;
                    }
                }
            }

        }


        public int GetNeighbours(int width, int height, int[,] world)
        {
            int neighbours = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {

                    if(i == 0 && j == 0)
                    {
                        continue;
                    }

                    int x = RoomCenter.X + j;
                    int y = RoomCenter.Y + i;

                    if (x < 0 || x >= width || y < 0 || y >= height)
                    {
                        continue;
                    }

                    if (world[x, y] == LevelConstants.PathCell)
                    {
                        neighbours++;
                    }
                }
            }
            return neighbours;
        }
    }
}