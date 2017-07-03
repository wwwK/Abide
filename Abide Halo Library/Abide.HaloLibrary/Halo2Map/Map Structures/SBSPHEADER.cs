﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Abide.HaloLibrary.Halo2Map
{
    /// <summary>
    /// Represents a Halo 2 structure bsp tag data header.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), Serializable]
    public struct SbspHeader
    {
        /// <summary>
        /// Represents the length of a <see cref="SbspHeader"/> structure in bytes.
        /// This value is constant.
        /// </summary>
        public const int Length = 28;

        public Tag Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        public int DataLength
        {
            get { return dataLength; }
            set { dataLength = value; }
        }
        public int LightmapOffset
        {
            get { return lightmapOffset; }
            set { lightmapOffset = value; }
        }
        
        private int dataLength;
        private int uhh;
        private int lightmapOffset;
        private Tag tag;
        private TagId id;
        private int uhh2;
        private int uhh3;
    }
}
