using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMinerAlgorithm
{
	public partial class Form1 : Form
	{
		LevelGenerator gen;
		Painter p;

		public Form1()
		{
			InitializeComponent();
			p = new Painter(MainCanvas)
			{
				Resolution = 3
			};
		}

		private void Start_BTN_Click(object sender, EventArgs e)
		{

			int width = (int)Width_NUD.Value;
			int height = (int)Height_NUD.Value;
			gen = new LevelGenerator(new WorldSettings()
			{
				MaxSteps = (int)MaxStep_NUD.Value,
				SplitChance = (double)Utils.Map(SplitCh_NUD.Minimum, SplitCh_NUD.Maximum, (decimal)0.001, (decimal)0.03, SplitCh_NUD.Value),
				Height = height,
				Width = width,
				StartPosition = new Point(width / 2, height / 2),
				RotationTimer = new Range((int)RTMin_NUD.Value, (int)RTMin_NUD.Value)
			});
            int num = gen.RunGame(ref logRTB);

			if (num == 0) status_label.Text = "Finished! Out of steps.";
			if (num == 1) status_label.Text = "Finished! All miners died.";

			if (checkBox1.Checked)
			{
				gen.BuildRooms();
			}

			p.AutoResizeCanvas();
			p.DefineOffset(width, height);
			p.PaintCanvas(gen.GetWorld());
		}

		private void Stop_BTN_Click(object sender, EventArgs e)
		{

		}

        private void BuildRooms_BTN_Click(object sender, EventArgs e)
        {			
        }


		enum RoomCellType
        {
			floor, wall
        }

        private void MakeFile_BTN_Click(object sender, EventArgs e)
        {
			if(SaveFile.ShowDialog() == DialogResult.OK && SaveFile.FileName != string.Empty)
            {
				int[,] wol = GetTransformed(RoomCellType.floor);
				int h = wol.GetLength(1);
				int w = wol.GetLength(0);

				int[,] wol1 = GetTransformed(RoomCellType.wall);
				int h1 = wol1.GetLength(1);
				int w1 = wol1.GetLength(0);

				using (StreamWriter sw = File.CreateText(SaveFile.FileName))
                {
					sw.WriteLine("layer");
					for (int i = 0; i < h; i++)
					{
						string line = null;
						for (int j = 0; j < w; j++)
						{
							line += $"{wol[j, i]},";
						}
						sw.WriteLine(line);
					}
					sw.WriteLine("endlayer");

					sw.WriteLine("layer");
					for (int i = 0; i < h1; i++)
					{
						string line = null;
						for (int j = 0; j < w1; j++)
						{
							line += $"{wol1[j, i]},";
						}
						sw.WriteLine(line);
					}
					sw.WriteLine("endlayer");

					sw.WriteLine("layer");
					for (int i = 0; i < h1; i++)
					{
						string line = null;
						for (int j = 0; j < w1; j++)
						{
							line += $"{wol1[j, i]},";
						}
						sw.WriteLine(line);
					}
					sw.WriteLine("endlayer");

					sw.WriteLine("layer");
					for (int i = 0; i < h; i++)
					{
						string line = null;
						for (int j = 0; j < w; j++)
						{
							line += $"{wol[j, i]},";
						}
						sw.WriteLine(line);
					}
					sw.WriteLine("endlayer");

				}
				MessageBox.Show("Done");
			}
        }

		private int[,] GetTransformed(RoomCellType tpe)
        {
			int[,] result = gen.GetWorld();

			for (int i = 0; i < result.GetLength(1); i++)
			{
				for (int j = 0; j < result.GetLength(0); j++)
				{
					int x = result[j, i];

					switch (x)
					{
						case LevelConstants.EmptyCell:
							x = 3;
							break;

						case LevelConstants.PathCell:
							x = 3;
							if (tpe == RoomCellType.wall)
							{
								x = 0;
							}
							break;

						case LevelConstants.RoomFloorCell:
							x = 2;
							if (tpe == RoomCellType.wall)
							{
								x = 0;
							}
							break;

						case LevelConstants.DeadEndCell:
							x = 3;
							if (tpe == RoomCellType.wall)
							{
								x = 0;
							}
							break;

						case LevelConstants.StartCell:
							x = 3;
							if (tpe == RoomCellType.wall)
							{
								x = 0;
							}
							break;

						case LevelConstants.RoomWallCell:
							x = 4;
							break;

						default:
							x = 3;
							break;
					}
					result[j, i] = x;
				}
			}


			return result;
        }
    }
}
