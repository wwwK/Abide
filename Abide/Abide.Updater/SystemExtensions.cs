﻿using System.Runtime.InteropServices;
using System.Text;

namespace System.IO
{
    /// <summary>
    /// Provides extension and helper functions for the System.IO namespace.
    /// </summary>
    public static class IOExtensions
    {
        /// <summary>
        /// If we can't find the whitespace after 4KB, we're just gonna call it quits.
        /// </summary>
        private const int NullTerminatedCutoff = 4096;

        /// <summary>
        /// Sets the position within the current stream to an offset whose difference is that of the supplied offset, and a translator value.
        /// </summary>
        /// <param name="stream">The stream to seek within.</param>
        /// <param name="offset">The translator-addressed to seek to.</param>
        /// <param name="translator">The value to translate the address.</param>
        /// <param name="origin">The reference point used to obtain the new position.</param>
        /// <returns>The new position of the current stream.</returns>
        /// <exception cref="IOException"></exception> 
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static long Seek(this Stream stream, int offset, int translator, SeekOrigin origin)
        {
            return stream.Seek(offset - translator, origin);
        }
        /// <summary>
        /// Sets the position within the current stream to an offset whose difference is that of the supplied offset, and a translator value.
        /// </summary>
        /// <param name="stream">The stream to seek within.</param>
        /// <param name="offset">The translator-addressed to seek to.</param>
        /// <param name="translator">The value to translate the address.</param>
        /// <param name="origin">The reference point used to obtain the new position.</param>
        /// <returns>The new position of the current stream.</returns>
        /// <exception cref="IOException"></exception> 
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static long Seek(this Stream stream, uint offset, uint translator, SeekOrigin origin)
        {
            return stream.Seek(offset - translator, origin);
        }
        /// <summary>
        /// Sets the position within the current stream to an offset whose difference is that of the supplied offset, and a translator value.
        /// </summary>
        /// <param name="stream">The stream to seek within.</param>
        /// <param name="offset">The translator-addressed offset to seek to.</param>
        /// <param name="translator">The value to translate the address.</param>
        /// <param name="origin">The reference point used to obtain the new position.</param>
        /// <returns>The new position of the current stream.</returns>
        /// <exception cref="IOException"></exception> 
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        /// <exception cref="OverflowException"></exception>
        public static long Seek(this Stream stream, int offset, uint translator, SeekOrigin origin)
        {
            return stream.Seek(offset - (int)translator, origin);
        }
        /// <summary>
        /// Reads a generic string-table with a null-separated string list, and index table using a specified encoding.
        /// </summary>
        /// <param name="reader">The <see cref="BinaryReader"/> instance to read from the underlying stream.</param>
        /// <param name="stringsOffset">The zero-based offset to the beginning of the strings list.</param>
        /// <param name="indexOffset">The zero-based offset to the beginning of the strings' index.</param>
        /// <param name="count">The number of strings to be read.</param>
        /// <param name="encoding">The encoding used to decode the text.</param>
        /// <returns>A string array containing the </returns>
        /// <exception cref="IOException">Occurs when there function encounters an IO error.</exception>
        /// <exception cref="ArgumentNullException">Occurs when either the supplied <see cref="BinaryReader"/> instance or <see cref="Encoding"/> instance is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when either of the supplied offsets are outside of the file's range, or if the count is less than zero.</exception>
        public static string[] ReadStringTable(this BinaryReader reader, long stringsOffset, long indexOffset, int count, Encoding encoding)
        {
            //Prepare
            int[] offsets = new int[count];
            string[] strings = new string[count];

            //Check
            if (count == 0)
                return strings;
            if (count < 0)
                throw new ArgumentOutOfRangeException("count");
            if (stringsOffset < 0)
                throw new ArgumentOutOfRangeException("stringsOffset");
            if (indexOffset < 0)
                throw new ArgumentOutOfRangeException("offsetsOffset");

            //Goto indices
            reader.BaseStream.Seek(indexOffset, SeekOrigin.Begin);
            for (int i = 0; i < count; i++)
                offsets[i] = reader.ReadInt32();

            //Goto strings
            for (int i = 0; i < count; i++)
            {
                reader.BaseStream.Seek(stringsOffset + offsets[i], SeekOrigin.Begin);
                strings[i] = reader.ReadUTF8NullTerminated();
            }

            //Return
            return strings;
        }
        /// <summary>
        /// Reads a generic UTF-8 encoded string-table with a null-separated string list, and index table.
        /// </summary>
        /// <param name="reader">The <see cref="BinaryReader"/> instance to read from the underlying stream.</param>
        /// <param name="stringsOffset">The zero-based offset to the beginning of the strings list.</param>
        /// <param name="indexOffset">The zero-based offset to the beginning of the strings' index.</param>
        /// <param name="count">The number of strings to be read.</param>
        /// <returns>A string array containing the </returns>
        /// <exception cref="IOException">Occurs when there function encounters an IO error.</exception>
        /// <exception cref="ArgumentNullException">Occurs when the <see cref="BinaryReader"/> instance is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when either of the supplied offsets are outside of the file's range, or if the count is less than zero.</exception>
        public static string[] ReadUTF8StringTable(this BinaryReader reader, long stringsOffset, long indexOffset, int count)
        {
            return ReadStringTable(reader, stringsOffset, indexOffset, count, Encoding.UTF8);
        }
        /// <summary>
        /// Reads a generic ASCII encoded string-table with a null-separated string list, and index table.
        /// </summary>
        /// <param name="reader">The <see cref="BinaryReader"/> instance to read from the underlying stream.</param>
        /// <param name="stringsOffset">The zero-based offset to the beginning of the strings list.</param>
        /// <param name="indexOffset">The zero-based offset to the beginning of the strings' index.</param>
        /// <param name="count">The number of strings to be read.</param>
        /// <returns>A string array containing the </returns>
        /// <exception cref="ArgumentNullException">Occurs when the <see cref="BinaryReader"/> instance is null.</exception>
        /// <exception cref="IOException">Occurs when there function encounters an IO error.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Occurs when either of the supplied offsets are outside of the file's range, or if the count is less than zero.</exception>
        public static string[] ReadASCIIStringTable(this BinaryReader reader, long stringsOffset, long indexOffset, int count)
        {
            return ReadStringTable(reader, stringsOffset, indexOffset, count, Encoding.ASCII);
        }
        /// <summary>
        /// Reads the specified structure from the underlying stream and advances the current position of the stream by the length of the structure.
        /// </summary>
        /// <typeparam name="T">The marshalable structure type.</typeparam>
        /// <param name="reader">The <see cref="BinaryReader"/> instance to read from the underlying stream.</param>
        /// <returns>A structure containing the read data.</returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T ReadStructure<T>(this BinaryReader reader)
        {
            //Prepare
            T obj = default(T);
            GCHandle handle = new GCHandle();
            byte[] data = null;

            //Get data...
            data = reader.ReadBytes(Marshal.SizeOf(typeof(T)));

            //Check
            if (data != null)
            {
                handle = GCHandle.Alloc(data, GCHandleType.Pinned);
                obj = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
                handle.Free();
            }

            //Return
            return obj;
        }
        /// <summary>
        /// Writes the specified structure to the underlying stream and advances the current position of the stream by the length of the structure.
        /// </summary>
        /// <typeparam name="T">The marshalable structure type.</typeparam>
        /// <param name="writer">The <see cref="BinaryWriter"/> instance used to write to the underlying stream.</param>
        /// <param name="structure">The structure to write.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="ObjectDisposedException"></exception>
        public static void Write<T>(this BinaryWriter writer, T structure)
        {
            //Prepare
            int length = Marshal.SizeOf(structure);

            //Check
            if (length > 0)
            {
                //Allocate
                IntPtr addr = Marshal.AllocHGlobal(length);
                Marshal.StructureToPtr(structure, addr, true);

                //Copy
                byte[] data = new byte[length];
                Marshal.Copy(addr, data, 0, length);

                //Release
                Marshal.FreeHGlobal(addr);

                //Write
                writer.Write(data);
            }
        }
        /// <summary>
        /// Writes a null-terminated string to the underlying stream using the supplied encoding.
        /// </summary>
        /// <param name="Out">The System.IO.BinaryWriter instance.</param>
        /// <param name="text">The string to be written</param>
        /// <param name="encoding">The encoding to use to encode the text.</param>
        public static void WriteStringNullTerminated(this BinaryWriter Out, string text, Encoding encoding)
        {
            //Write
            Out.Write(encoding.GetBytes(text));
            Out.Write((byte)0);
        }
        /// <summary>
        /// Reads a null-terminated string from the underlying stream using the supplied encoding.
        /// </summary>
        /// <param name="In">The System.IO.BinaryReader instance.</param>
        /// <param name="length">The length of the data to be read.</param>
        /// /// <param name="encoding">The encoding to use to decode the text.</param>
        /// <returns>The ASCII-Encoded string.</returns>
        public static string ReadStringNullTerminated(this BinaryReader In, Encoding encoding)
        {
            //Prepare
            string value = string.Empty;
            int length = 0;
            byte c = 0;

            //Read
            c = In.ReadByte();
            using (MemoryStream ms = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(ms))
            {
                //Loop
                while (c != 0 && length < NullTerminatedCutoff)
                { writer.Write(c); c = In.ReadByte(); length++; }

                //Encode
                value = encoding.GetString(ms.GetBuffer(), 0, length);
            }

            //Return
            return value;
        }
        /// <summary>
        /// Writes a null-terminated UTF-8 encoded string to the underlying stream.
        /// </summary>
        /// <param name="Out">The System.IO.BinaryWriter instance.</param>
        /// <param name="text">The string to be written</param>
        public static void WriteUTF8NullTerminated(this BinaryWriter Out, string text)
        {
            Out.WriteStringNullTerminated(text, Encoding.UTF8);
        }
        /// <summary>
        /// Reads a null-terminated UTF-8-Encoded string from the underlying stream.
        /// </summary>
        /// <param name="In">The System.IO.BinaryReader instance.</param>
        /// <param name="length">The length of the data to be read.</param>
        /// <returns>The UTF-8-Encoded string.</returns>
        public static string ReadUTF8NullTerminated(this BinaryReader In)
        {
            return In.ReadStringNullTerminated(Encoding.UTF8);
        }
        /// <summary>
        /// Writes a null-terminated ASCII encoded string to the underlying stream.
        /// </summary>
        /// <param name="Out">The System.IO.BinaryWriter instance.</param>
        /// <param name="text">The string to be written</param>
        public static void WriteASCIINullTerminated(this BinaryWriter Out, string text)
        {
            Out.WriteStringNullTerminated(text, Encoding.ASCII);
        }
        /// <summary>
        /// Reads a null-terminated ASCII-Encoded string from the underlying stream.
        /// </summary>
        /// <param name="In">The System.IO.BinaryReader instance.</param>
        /// <param name="length">The length of the data to be read.</param>
        /// <returns>The ASCII-Encoded string.</returns>
        public static string ReadASCIINullTerminated(this BinaryReader In)
        {
            return In.ReadStringNullTerminated(Encoding.ASCII);
        }
        /// <summary>
        /// Writes a null-terminated Unicode encoded string to the underlying stream.
        /// </summary>
        /// <param name="Out">The System.IO.BinaryWriter instance.</param>
        /// <param name="text">The string to be written</param>
        public static void WriteUnicodeNullTerminated(this BinaryWriter Out, string text)
        {
            Out.WriteStringNullTerminated(text, Encoding.Unicode);
        }
        /// <summary>
        /// Reads a null-terminated Unicode-Encoded string from the underlying stream.
        /// </summary>
        /// <param name="In">The System.IO.BinaryReader instance.</param>
        /// <param name="length">The length of the data to be read.</param>
        /// <returns>The Unicode-Encoded string.</returns>
        public static string ReadUnicodeNullTerminated(this BinaryReader In)
        {
            return In.ReadStringNullTerminated(Encoding.Unicode);
        }
        /// <summary>
        /// Writes a non-lengthed prefix UTF-8-Encoded string to the underlying stream.
        /// </summary>
        /// <param name="Out">The System.IO.BinaryWriter instance.</param>
        /// <param name="text">The string to be written</param>
        public static void WriteStringData(this BinaryWriter Out, string text, Encoding encoding)
        {
            Out.Write(encoding.GetBytes(text));
        }
        /// <summary>
        /// Reads an UTF-8-Encoded string from the underlying stream.
        /// </summary>
        /// <param name="In">The System.IO.BinaryReader instance.</param>
        /// <param name="length">The length of the data to be read.</param>
        /// <returns>The UTF-8-Encoded string.</returns>
        public static string ReadStringData(this BinaryReader In, int length, Encoding encoding)
        {
            byte[] data = In.ReadBytes(length);
            return new string(encoding.GetChars(data));
        }
        /// <summary>
        /// Writes a non-lengthed prefix UTF-8-Encoded string to the underlying stream.
        /// </summary>
        /// <param name="Out">The System.IO.BinaryWriter instance.</param>
        /// <param name="text">The string to be written</param>
        public static void WriteUTF8(this BinaryWriter Out, string text)
        {
            Out.WriteStringData(text, Encoding.UTF8);
        }
        /// <summary>
        /// Reads an UTF-8-Encoded string from the underlying stream.
        /// </summary>
        /// <param name="In">The System.IO.BinaryReader instance.</param>
        /// <param name="length">The length of the data to be read.</param>
        /// <returns>The UTF-8-Encoded string.</returns>
        public static string ReadUTF8(this BinaryReader In, int length)
        {
            return In.ReadStringData(length, Encoding.UTF8);
        }
        /// <summary>
        /// Writes a non-lengthed prefix ASCII-Encoded string to the underlying stream.
        /// </summary>
        /// <param name="Out">The System.IO.BinaryWriter instance.</param>
        /// <param name="text">The string to be written</param>
        public static void WriteASCII(this BinaryWriter Out, string text)
        {
            Out.WriteStringData(text, Encoding.ASCII);
        }
        /// <summary>
        /// Reads an ASCII-Encoded string from the underlying stream.
        /// </summary>
        /// <param name="In">The System.IO.BinaryReader instance.</param>
        /// <param name="length">The length of the data to be read.</param>
        /// <returns>The ASCII-Encoded string.</returns>
        public static string ReadASCII(this BinaryReader In, int length)
        {
            return In.ReadStringData(length, Encoding.ASCII);
        }
        /// <summary>
        /// Writes a non-lengthed prefix Unicode-Encoded string to the underlying stream.
        /// </summary>
        /// <param name="Out">The System.IO.BinaryWriter instance.</param>
        /// <param name="text">The string to be written</param>
        public static void WriteUnicode(this BinaryWriter Out, string text)
        {
            Out.WriteStringData(text, Encoding.Unicode);
        }
        /// <summary>
        /// Reads an Unicode-Encoded string from the underlying stream.
        /// </summary>
        /// <param name="In">The System.IO.BinaryReader instance.</param>
        /// <param name="length">The length of the data to be read.</param>
        /// <returns>The Unicode-Encoded string.</returns>
        public static string ReadUnicode(this BinaryReader In, int length)
        {
            return In.ReadStringData(length, Encoding.Unicode);
        }
    }
}
