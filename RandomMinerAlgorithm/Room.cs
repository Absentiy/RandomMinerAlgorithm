using System.Drawing;

namespace RandomMinerAlgorithm
{
    public class Room
    {
        public Size Size { get; set; }

        public Point Center { get; set; }

        public Room() { }

        public Room(Size size, Point center)
        {
            Size = size;
            Center = center;
        }

        public void DecorateRoom()
        {
            return; //Not implemented yet
        }
    }
}