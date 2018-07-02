﻿using System.IO;

namespace Abide.Tag
{
    /// <summary>
    /// Represents an object that can be read from a stream using a <see cref="BinaryReader"/> object.
    /// </summary>
    public interface IReadable
    {
        /// <summary>
        /// Reads the value of the object from the underlying stream using the specified binary reader.
        /// </summary>
        /// <param name="reader">The binary reader used to access the underlying stream.</param>
        void Read(BinaryReader reader);
    }
    /// <summary>
    /// Represents an object that can be written to a stream using a <see cref="BinaryWriter"/> object.
    /// </summary>
    public interface IWritable
    {
        /// <summary>
        /// Writes the value of the object to the underlying stream using the specified binary writer.
        /// </summary>
        /// <param name="writer">The binary writer used to access the underlying stream.</param>
        void Write(BinaryWriter writer);
    }
    /// <summary>
    /// Represents an object that can be both written to a stream using a <see cref="BinaryWriter"/> object,
    /// and read from a stream using a <see cref="BinaryReader"/> object.
    /// </summary>
    public interface IReadWrite : IReadable, IWritable { }
}
