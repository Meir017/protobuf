﻿﻿
// Generated by ProtocolBuffer
// - a pure c# code generation implementation of protocol buffers
// Report bugs to: https://silentorbit.com/protobuf/

// DO NOT EDIT
// This file will be overwritten when CodeGenerator is run.
// To make custom modifications, edit the .proto file and add //:external before the message line
// then write the code and the changes in a separate file.

using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

using SilentOrbit.ProtocolBuffers;
using static SilentOrbit.ProtocolBuffers.ProtocolParser;

// This is the backend code for reading and writing
namespace Google.Protobuf;

public partial class FileDescriptorSet
{
    /// <summary>Helper: create a new instance to deserializing into</summary>
    public static FileDescriptorSet Deserialize(Stream stream)
    {
        var instance = new FileDescriptorSet();
        Deserialize(stream, instance);
        return instance;
    }

    /// <summary>Helper: create a new instance to deserializing into</summary>
    public static FileDescriptorSet DeserializeLengthDelimited(Stream stream)
    {
        var instance = new FileDescriptorSet();
        DeserializeLengthDelimited(stream, instance);
        return instance;
    }

    /// <summary>Helper: create a new instance to deserializing into</summary>
    public static FileDescriptorSet DeserializeLength(Stream stream, int length)
    {
        var instance = new FileDescriptorSet();
        DeserializeLength(stream, length, instance);
        return instance;
    }

    /// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
    public static FileDescriptorSet Deserialize(byte[] buffer)
    {
        var instance = new FileDescriptorSet();
        using (var ms = new MemoryStream(buffer))
            Deserialize(ms, instance);
        return instance;
    }

    /// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
    public static global::Google.Protobuf.FileDescriptorSet Deserialize(byte[] buffer, global::Google.Protobuf.FileDescriptorSet instance)
    {
        using (var ms = new MemoryStream(buffer))
            Deserialize(ms, instance);
        return instance;
    }

    /// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
    public static global::Google.Protobuf.FileDescriptorSet Deserialize(Stream stream, global::Google.Protobuf.FileDescriptorSet instance)
    {
        if (instance.File == null)
            instance.File = new List<global::Google.Protobuf.FileDescriptorProto>();
        while (true)
        {
            int keyByte = stream.ReadByte();
            if (keyByte == -1)
                break;
            // Optimized reading of known fields with field ID < 16
            switch (keyByte)
            {
                // Field 1 LengthDelimited
                case 10:
                    // repeated
                    instance.File.Add(global::Google.Protobuf.FileDescriptorProto.DeserializeLengthDelimited(stream));
                    continue;
            }

            var key = ReadKey((byte)keyByte, stream);

            // Reading field ID > 16 and unknown field ID/wire type combinations
            switch (key.Field)
            {
                case 0:
                    throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
                default:
                    SkipKey(stream, key);
                    break;
            }
        }

        return instance;
    }

    /// <summary>Read the VarInt length prefix and the given number of bytes from the stream and deserialze it into the instance.</summary>
    public static global::Google.Protobuf.FileDescriptorSet DeserializeLengthDelimited(Stream stream, global::Google.Protobuf.FileDescriptorSet instance)
    {
        if (instance.File == null)
            instance.File = new List<global::Google.Protobuf.FileDescriptorProto>();
        long limit = ReadUInt32(stream);
        limit += stream.Position;
        while (true)
        {
            if (stream.Position >= limit)
            {
                if (stream.Position == limit)
                    break;
                else
                    throw new ProtocolBufferException("Read past max limit");
            }
            int keyByte = stream.ReadByte();
            if (keyByte == -1)
                throw new System.IO.EndOfStreamException();
            // Optimized reading of known fields with field ID < 16
            switch (keyByte)
            {
                // Field 1 LengthDelimited
                case 10:
                    // repeated
                    instance.File.Add(global::Google.Protobuf.FileDescriptorProto.DeserializeLengthDelimited(stream));
                    continue;
            }

            var key = ReadKey((byte)keyByte, stream);

            // Reading field ID > 16 and unknown field ID/wire type combinations
            switch (key.Field)
            {
                case 0:
                    throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
                default:
                    SkipKey(stream, key);
                    break;
            }
        }

        return instance;
    }

    /// <summary>Read the given number of bytes from the stream and deserialze it into the instance.</summary>
    public static global::Google.Protobuf.FileDescriptorSet DeserializeLength(Stream stream, int length, global::Google.Protobuf.FileDescriptorSet instance)
    {
        if (instance.File == null)
            instance.File = new List<global::Google.Protobuf.FileDescriptorProto>();
        long limit = stream.Position + length;
        while (true)
        {
            if (stream.Position >= limit)
            {
                if (stream.Position == limit)
                    break;
                else
                    throw new ProtocolBufferException("Read past max limit");
            }
            int keyByte = stream.ReadByte();
            if (keyByte == -1)
                throw new System.IO.EndOfStreamException();
            // Optimized reading of known fields with field ID < 16
            switch (keyByte)
            {
                // Field 1 LengthDelimited
                case 10:
                    // repeated
                    instance.File.Add(global::Google.Protobuf.FileDescriptorProto.DeserializeLengthDelimited(stream));
                    continue;
            }

            var key = ReadKey((byte)keyByte, stream);

            // Reading field ID > 16 and unknown field ID/wire type combinations
            switch (key.Field)
            {
                case 0:
                    throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
                default:
                    SkipKey(stream, key);
                    break;
            }
        }

        return instance;
    }

    /// <summary>Serialize the instance into the stream</summary>
    public static void Serialize(Stream stream, FileDescriptorSet instance)
    {
        using (var msField = new MemoryStream())
        {
            if (instance.File != null)
            {
                foreach (var i1 in instance.File)
                {
                    // Key for field: 1, LengthDelimited
                    stream.WriteByte(10);
                    ﻿msField.SetLength(0);
                    global::Google.Protobuf.FileDescriptorProto.Serialize(msField, i1);
                    // Length delimited byte array
                    uint length1 = (uint)msField.Length;
                    WriteUInt32(stream, length1);
                    msField.WriteTo(stream);

                }
            }
        }
    }

    /// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
    public static byte[] SerializeToBytes(FileDescriptorSet instance)
    {
        using (var ms = new MemoryStream())
        {
            Serialize(ms, instance);
            return ms.ToArray();
        }
    }
    /// <summary>Helper: Serialize with a varint length prefix</summary>
    public static void SerializeLengthDelimited(Stream stream, FileDescriptorSet instance)
    {
        var data = SerializeToBytes(instance);
        WriteUInt32(stream, (uint)data.Length);
        stream.Write(data, 0, data.Length);
    }
}

