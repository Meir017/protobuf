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

// Classes and structures being serialized
namespace Google.Protobuf;

/// <summary> Describes a method of a service.</summary>
public partial class MethodDescriptorProto
{
    public string Name { get; set; }

    /// <summary>
    /// <para> Input and output type names.  These are resolved in the same way as</para>
    /// <para> FieldDescriptorProto.type_name, but must refer to a message type.</para>
    /// </summary>
    public string InputType { get; set; }

    public string OutputType { get; set; }

    public MethodOptions Options { get; set; }

}

