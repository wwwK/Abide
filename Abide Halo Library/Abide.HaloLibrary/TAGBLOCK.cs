﻿using System;
using System.Runtime.InteropServices;

namespace Abide.HaloLibrary
{
    /// <summary>
    /// Represents a 64-bit tag_block reference.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct TagBlock : IComparable<TagBlock>, IComparable<long>, IComparable<ulong>, IEquatable<TagBlock>, IEquatable<long>, IEquatable<ulong>
    {
        /// <summary>
        /// Represents a zero-value <see cref="TagBlock"/> structure.
        /// </summary>
        public static readonly TagBlock Zero = new TagBlock() { count = 0, offset = 0 };
        /// <summary>
        /// Gets and returns <see langword="true"/> if this tag block value is zero; otherwise, <see langword="false"/>.
        /// </summary>
        public bool IsZero
        {
            get { return count == 0 && offset == 0; }
        }
        /// <summary>
        /// Gets or sets the array length.
        /// </summary>
        public uint Count
        {
            get { return count; }
            set { count = value; }
        }
        /// <summary>
        /// Gets or sets the offset to the array.
        /// </summary>
        public uint Offset
        {
            get { return offset; }
            set { offset = value; }
        }
        /// <summary>
        /// Gets or sets a 64-bit unsigned integer containing this tag block's data.
        /// </summary>
        public ulong Qword
        {
            get
            {
                long count = this.count;
                long pointer = offset;
                return (ulong)((pointer << 32) | count);
            }
            set
            {
                count = (uint)(value & 0xFFFFFFFF);
                offset = (uint)((value >> 32) & 0xFFFFFFFF);
            }
        }

        [FieldOffset(0)]
        private uint count;
        [FieldOffset(4)]
        private uint offset;

        /// <summary>
        /// Initializes a new <see cref="TagBlock"/> structure with the specified count and pointer values.
        /// </summary>
        /// <param name="count">The amount of blocks in the array.</param>
        /// <param name="offset">The offset to the array.</param>
        public TagBlock(uint count, uint offset)
        {
            this.count = count;
            this.offset = offset;
        }
        /// <summary>
        /// Translates the tag block's memory-addressed pointer using a supplied value.
        /// </summary>
        /// <param name="memoryAddress">The base memory-address.</param>
        /// <returns>A translated pointer address.</returns>
        public long Translate(int memoryAddress)
        {
            return offset - memoryAddress;
        }
        /// <summary>
        /// Compares this instance to a specified 64-bit unsigned integer and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">An unsigned integer to compare.</param>
        /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
        public int CompareTo(ulong other)
        {
            return Qword.CompareTo(other);
        }
        /// <summary>
        /// Compares this instance to a specified 64-bit signed integer and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A signed integer to compare.</param>
        /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
        public int CompareTo(long other)
        {
            return Qword.CompareTo((ulong)other);
        }
        /// <summary>
        /// Compares this instance to a specified 64-bit tag block and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">A <see cref="TagBlock"/> to compare.</param>
        /// <returns>A signed number indicating the relative values of this instance and <paramref name="other"/>.</returns>
        public int CompareTo(TagBlock other)
        {
            return Qword.CompareTo(other.Qword);
        }
        /// <summary>
        /// Determines whether the specified unsigned 64-bit integer is equal to this instance.
        /// </summary>
        /// <param name="other">The integer to compare with the current instance.</param>
        /// <returns>true if the specified integer is equal to the current instance; otherwise false.</returns>
        public bool Equals(ulong other)
        {
            return Qword.Equals(other);
        }
        /// <summary>
        /// Determines whether the specified signed 64-bit integer is equal to this instance.
        /// </summary>
        /// <param name="other">The integer to compare with the current instance.</param>
        /// <returns>true if the specified integer is equal to the current instance; otherwise false.</returns>
        public bool Equals(long other)
        {
            return Qword.Equals((ulong)other);
        }
        /// <summary>
        /// Determines whether the specified <see cref="TagBlock"/> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="TagBlock"/> to compare with the current instance.</param>
        /// <returns>true if the specified <see cref="TagBlock"/> is equal to the current instance; otherwise false.</returns>
        public bool Equals(TagBlock other)
        {
            return Qword.Equals(other.Qword);
        }
        public override bool Equals(object obj)
        {
            if (obj is TagBlock tagBlock)
            {
                return Equals(tagBlock);
            }

            return false;
        }
        /// <summary>
        /// Converts the value of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>The string representation of the value of this instance, consisting of a valid count integer and pointer integer.</returns>
        public override string ToString()
        {
            return string.Format("Count: {0} Pointer: {1}", count, offset);
        }
        /// <summary>
        /// Converts a <see cref="TagBlock"/> to an unsigned 64-bit ingeger.
        /// </summary>
        /// <param name="tagBlock">The tag block to convert.</param>
        public static explicit operator ulong(TagBlock tagBlock)
        {
            return tagBlock.Qword;
        }
        /// <summary>
        /// Converts a <see cref="TagBlock"/> to a signed 64-bit integer.
        /// </summary>
        /// <param name="tagBlock">The tag block to convert.</param>
        public static explicit operator long(TagBlock tagBlock)
        {
            return (long)tagBlock.Qword;
        }
        /// <summary>
        /// Converts an unsigned 64-bit integer to a <see cref="TagBlock"/> value.
        /// </summary>
        /// <param name="value">The unsigned 64-bit integer to convert.</param>
        public static explicit operator TagBlock(ulong value)
        {
            uint count = (uint)(value & 0xFFFFFFFF);
            uint pointer = (uint)((value >> 32) & 0xFFFFFFFF);
            return new TagBlock() { count = count, offset = pointer };
        }
        /// <summary>
        /// Converts a signed 64-bit integer to a <see cref="TagBlock"/> value.
        /// </summary>
        /// <param name="value">The signed 64-bit integer to convert.</param>
        public static explicit operator TagBlock(long value)
        {
            uint count = (uint)(value & 0xFFFFFFFF);
            uint pointer = (uint)((value >> 32) & 0xFFFFFFFF);
            return new TagBlock() { count = count, offset = pointer };
        }
    }
}
