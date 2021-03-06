﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace MarchingCubes
{
    public class CubesInfo
    {
        public double IsoLevel { get; set; }
        public int DimensionSize { get; set; }
        public Color Color { get; set; }
        public RandSeedTypes RandSeedType { get; set; }

        public Random GetRandom()
        {
            switch (this.RandSeedType)
            {
                case RandSeedTypes.Seconds:
                    return new Random(DateTime.Now.Second);
                default:
                    return new Random();
            }
            
        }

        public static CubesInfo Default
        {
            get
            {
                var info = new CubesInfo();
                info.IsoLevel = 0.2;
                info.DimensionSize = 10;
                info.Color = Color.Red;

                return info;
            }
        }
    }
}
