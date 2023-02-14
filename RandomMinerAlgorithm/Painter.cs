using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace RandomMinerAlgorithm
{
    public class Painter
    {
        private readonly Brush PathCell = Brushes.White;
        private readonly Brush RoomCell = Brushes.Green;
        private readonly Brush DeadEndCell = Brushes.Red;
        private readonly Brush StartCell = Brushes.Blue;
        private readonly Brush RoomWallCell = Brushes.LightSeaGreen;
        private readonly Color BackColor = Color.Black;

        private int X_Offset = 0;
        private int Y_Offset = 0;

        private readonly PictureBox Screen;
        private Graphics g;

        public int Resolution { get; set; } = 1;

        public Painter(PictureBox pictureBox)
        {
            Screen = pictureBox;
            AutoResizeCanvas();
        }

        public void AutoResizeCanvas()
        {
            g = Screen.CreateGraphics();
            g.Clear(BackColor);
        }

        public void DefineOffset(int w, int h)
        {
            X_Offset = (Screen.Width / 2) - (w * Resolution / 2);
            Y_Offset = (Screen.Height / 2) - (h * Resolution / 2);
        }

        public void PaintCanvas(int[,] world)
        {
            Brush current;

            g.DrawRectangle(Pens.Blue, X_Offset-1, Y_Offset-1, world.GetLength(0) * Resolution, world.GetLength(1) * Resolution);
            for (int i = 0; i < world.GetLength(1); i++)
            {
                for (int j = 0; j < world.GetLength(0); j++)
                {
                    switch (world[j, i])
                    {
                        case LevelConstants.EmptyCell:
                            continue;

                        case LevelConstants.PathCell:
                            current = PathCell;
                            break;

                        case LevelConstants.RoomFloorCell:
                            current = RoomCell;
                            break;

                        case LevelConstants.DeadEndCell:
                            current = DeadEndCell;
                            break;

                        case LevelConstants.StartCell:
                            current = StartCell;
                            break;

                        case LevelConstants.RoomWallCell:
                            current = RoomWallCell;
                            break;

                        default:
                            throw new InvalidOperationException($"Undefined value at: {j};{i} = {world[j, i]}");
                    }
                    g.FillRectangle(current, j * Resolution + X_Offset, i * Resolution + Y_Offset, Resolution, Resolution);
                }
            }
            Screen.Update();
        }

    }
}
