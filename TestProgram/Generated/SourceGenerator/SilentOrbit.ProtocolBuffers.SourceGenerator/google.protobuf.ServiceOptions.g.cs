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

public partial class ServiceOptions
{
    /// <summary>
    /// <para> Note:  Field numbers 1 through 32 are reserved for Google's internal RPC</para>
    /// <para>   framework.  We apologize for hoarding these numbers to ourselves, but</para>
    /// <para>   we were already using them long before we decided to release Protocol</para>
    /// <para>   Buffers.</para>
    /// <para> The parser stores options it doesn't recognize here. See above.</para>
    /// </summary>
    public List<UninterpretedOption> UninterpretedOption { get; set; }

}

