﻿using Abide.HaloLibrary;
using System;
using System.Collections.Generic;

namespace Abide.H2Guerilla
{
    /// <summary>
    /// Me want banana.
    /// </summary>
    public static class Guerilla
    {
        /// <summary>
        /// The image load address used for translating virtual addresses into physical addresses.
        /// </summary>
        public const int BaseAddress = 0x400000;
        /// <summary>
        /// The virtual addrss of the tag layout table.
        /// </summary>
        public const int TagLayoutTableAddress = 0x00901B90;
        /// <summary>
        /// The number of tag layouts in the layout table.
        /// </summary>
        public const int NumberOfTagLayouts = 120;
        /// <summary>
        /// Returns a dictionary of tag types based on a given tag.
        /// </summary>
        public static Dictionary<TagFourCc, Type> TagGroupDictionary
        {
            //get { return Tags.Guerilla.TagGroupDictionary; }
            get { return null; }
        }
    }
}
