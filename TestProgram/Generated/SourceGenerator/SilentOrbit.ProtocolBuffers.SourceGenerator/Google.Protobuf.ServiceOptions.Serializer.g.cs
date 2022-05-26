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

public partial class ServiceOptions
{
    /// <summary>Helper: create a new instance to deserializing into</summary>
    public static ServiceOptions Deserialize(Stream stream)
    {
        var instance = new ServiceOptions();
        Deserialize(stream, instance);
        return instance;
    }

    /// <summary>Helper: create a new instance to deserializing into</summary>
    public static ServiceOptions DeserializeLengthDelimited(Stream stream)
    {
        var instance = new ServiceOptions();
        DeserializeLengthDelimited(stream, instance);
        return instance;
    }

    /// <summary>Helper: create a new instance to deserializing into</summary>
    public static ServiceOptions DeserializeLength(Stream stream, int length)
    {
        var instance = new ServiceOptions();
        DeserializeLength(stream, length, instance);
        return instance;
    }

    /// <summary>Helper: put the buffer into a MemoryStream and create a new instance to deserializing into</summary>
    public static ServiceOptions Deserialize(byte[] buffer)
    {
        var instance = new ServiceOptions();
        using (var ms = new MemoryStream(buffer))
            Deserialize(ms, instance);
        return instance;
    }

    /// <summary>Helper: put the buffer into a MemoryStream before deserializing</summary>
    public static global::Google.Protobuf.ServiceOptions Deserialize(byte[] buffer, global::Google.Protobuf.ServiceOptions instance)
    {
        using (var ms = new MemoryStream(buffer))
            Deserialize(ms, instance);
        return instance;
    }

    /// <summary>Takes the remaining content of the stream and deserialze it into the instance.</summary>
    public static global::Google.Protobuf.ServiceOptions Deserialize(Stream stream, global::Google.Protobuf.ServiceOptions instance)
    {
        if (instance.UninterpretedOption == null)
            instance.UninterpretedOption = new List<global::Google.Protobuf.UninterpretedOption>();
        while (true)
        {
            int keyByte = stream.ReadByte();
            if (keyByte == -1)
                break;
            var key = ReadKey((byte)keyByte, stream);

            // Reading field ID > 16 and unknown field ID/wire type combinations
            switch (key.Field)
            {
                case 0:
                    throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
                case 999:
                    if(key.WireType != Wire.LengthDelimited)
                        break;
                    // repeated
                    instance.UninterpretedOption.Add(global::Google.Protobuf.UninterpretedOption.DeserializeLengthDelimited(stream));
                    continue;
                default:
                    SkipKey(stream, key);
                    break;
            }
        }

        return instance;
    }

    /// <summary>Read the VarInt length prefix and the given number of bytes from the stream and deserialze it into the instance.</summary>
    public static global::Google.Protobuf.ServiceOptions DeserializeLengthDelimited(Stream stream, global::Google.Protobuf.ServiceOptions instance)
    {
        if (instance.UninterpretedOption == null)
            instance.UninterpretedOption = new List<global::Google.Protobuf.UninterpretedOption>();
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
            var key = ReadKey((byte)keyByte, stream);

            // Reading field ID > 16 and unknown field ID/wire type combinations
            switch (key.Field)
            {
                case 0:
                    throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
                case 999:
                    if(key.WireType != Wire.LengthDelimited)
                        break;
                    // repeated
                    instance.UninterpretedOption.Add(global::Google.Protobuf.UninterpretedOption.DeserializeLengthDelimited(stream));
                    continue;
                default:
                    SkipKey(stream, key);
                    break;
            }
        }

        return instance;
    }

    /// <summary>Read the given number of bytes from the stream and deserialze it into the instance.</summary>
    public static global::Google.Protobuf.ServiceOptions DeserializeLength(Stream stream, int length, global::Google.Protobuf.ServiceOptions instance)
    {
        if (instance.UninterpretedOption == null)
            instance.UninterpretedOption = new List<global::Google.Protobuf.UninterpretedOption>();
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
            var key = ReadKey((byte)keyByte, stream);

            // Reading field ID > 16 and unknown field ID/wire type combinations
            switch (key.Field)
            {
                case 0:
                    throw new ProtocolBufferException("Invalid field id: 0, something went wrong in the stream");
                case 999:
                    if(key.WireType != Wire.LengthDelimited)
                        break;
                    // repeated
                    instance.UninterpretedOption.Add(global::Google.Protobuf.UninterpretedOption.DeserializeLengthDelimited(stream));
                    continue;
                default:
                    SkipKey(stream, key);
                    break;
            }
        }

        return instance;
    }

    /// <summary>Serialize the instance into the stream</summary>
    public static void Serialize(Stream stream, ServiceOptions instance)
    {
        using (var msField = new MemoryStream())
        {
            if (instance.UninterpretedOption != null)
            {
                foreach (var i999 in instance.UninterpretedOption)
                {
                    // Key for field: 999, LengthDelimited
                    stream.WriteByte(186);
                    stream.WriteByte(62);
                    ﻿msField.SetLength(0);
                    global::Google.Protobuf.UninterpretedOption.Serialize(msField, i999);
                    // Length delimited byte array
                    uint length999 = (uint)msField.Length;
                    WriteUInt32(stream, length999);
                    msField.WriteTo(stream);

                }
            }
        }
    }

    /// <summary>Helper: Serialize into a MemoryStream and return its byte array</summary>
    public static byte[] SerializeToBytes(ServiceOptions instance)
    {
        using (var ms = new MemoryStream())
        {
            Serialize(ms, instance);
            return ms.ToArray();
        }
    }
    /// <summary>Helper: Serialize with a varint length prefix</summary>
    public static void SerializeLengthDelimited(Stream stream, ServiceOptions instance)
    {
        var data = SerializeToBytes(instance);
        WriteUInt32(stream, (uint)data.Length);
        stream.Write(data, 0, data.Length);
    }
}

