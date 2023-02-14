using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMinerAlgorithm
{
    public class Range
    {
        public int Minimum { get; set; }

        public int Maximum { get; set; }

        public Range(int minimum, int maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }
    }

    public class WorldSettings
    {
        public int MaxSteps { get; set; }

        public double SplitChance { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Point StartPosition { get; set; }

        public Range RotationTimer { get; set; }
    }
}
