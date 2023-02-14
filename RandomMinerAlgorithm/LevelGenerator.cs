using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RandomMinerAlgorithm
{
    public class LevelGenerator
	{
		public event Action OnStepDone;


		private int[,] Field;
		private List<RandomMiner> miners = new List<RandomMiner>();
		private readonly Random rand = new Random(DateTime.Now.Millisecond);
		private List<RoomBuilder> builders = new List<RoomBuilder>();

		private WorldSettings settings;

		public LevelGenerator(WorldSettings worldSettings)
        {
			settings = worldSettings;

			Field = new int[settings.Width, settings.Height];
		}

		private void ClearField()
        {
			for (int i = 0; i < settings.Width; i++)
			{
				for (int j = 0; j < settings.Height; j++)
				{
					Field[j, i] = LevelConstants.EmptyCell;
				}
			}
		}

		public int[,] GetWorld()
        {
			int[,] res = new int[settings.Width, settings.Height];
			for (int i = 0; i < settings.Width; i++)
			{
				for (int j = 0; j < settings.Height; j++)
				{
					res[j, i] = Field[j, i];
				}
			}

			return res;
		}

		public int RunGame(ref RichTextBox rtb)
		{
			ClearField();
			miners.Clear();
			rtb.Clear();

			RandomMiner st = new RandomMiner
			{
				Position = settings.StartPosition
			};

            miners.Add(st);

			int num = 0;
			int rotTimer = 0;
			int rotTimerTask = 0;
			while (num < settings.MaxSteps)
			{
				if (miners.Count <= 0)
				{
					Field[settings.StartPosition.X, settings.StartPosition.Y] = LevelConstants.StartCell;
					return 1;
				}

				for (int i = 0; i < miners.Count; i++)
				{
					RandomMiner miner = miners[i];

					if (rotTimer >= rotTimerTask)
					{
						miner.SetDirection();
						rotTimer = 0;
						rotTimerTask = rand.Next(settings.RotationTimer.Minimum, settings.RotationTimer.Maximum);
					}
					//rtb.AppendText($"{i}.New: {miner.Direction}\n");

					if ((num = miner.Move(ref Field)) != 0)
					{
						if(num == 1)
                        {
							builders.Add(new RoomBuilder() { RoomCenter = miner.Position });
						}

						if(num == -1)
                        {
							if(miner.Position.X >= 0 && miner.Position.X < settings.Width && miner.Position.Y >= 0 && miner.Position.Y < settings.Height)
                            {
								Field[miner.Position.X, miner.Position.Y] = LevelConstants.DeadEndCell;
							}
						}

						miners.Remove(miner);
					}
					//rtb.AppendText($"{i}.NewPos: {miner.Position}\n");

					if (rand.NextDouble() < settings.SplitChance)
                    {
						miners.AddRange(miner.CreateChildren(1));
						builders.Add(new RoomBuilder() { RoomCenter = miner.Position });
						//rtb.AppendText($"{i}.NewChildren()\n");
					}

				}
				OnStepDone?.Invoke();
				rotTimer++;
				num++;
			}
			Field[settings.StartPosition.X, settings.StartPosition.Y] = LevelConstants.StartCell;
			return 0;
		}

		public void BuildRooms()
        {
            foreach (RoomBuilder item in builders)
            {
				item.BuildRoom(ref Field, settings.Width, settings.Height);
            }
        }

	}
}
