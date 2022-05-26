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

/// <summary> Describes a field within a message.</summary>
public partial class FieldDescriptorProto
{
    public enum Type
    {
        /// <summary>
        /// <para> 0 is reserved for errors.</para>
        /// <para> Order is weird for historical reasons.</para>
        /// </summary>
        TYPE_DOUBLE = 1,
        TYPE_FLOAT = 2,
        /// <summary>
        /// <para> Not ZigZag encoded.  Negative numbers take 10 bytes.  Use TYPE_SINT64 if</para>
        /// <para> negative values are likely.</para>
        /// </summary>
        TYPE_INT64 = 3,
        TYPE_UINT64 = 4,
        /// <summary>
        /// <para> Not ZigZag encoded.  Negative numbers take 10 bytes.  Use TYPE_SINT32 if</para>
        /// <para> negative values are likely.</para>
        /// </summary>
        TYPE_INT32 = 5,
        TYPE_FIXED64 = 6,
        TYPE_FIXED32 = 7,
        TYPE_BOOL = 8,
        TYPE_STRING = 9,
        TYPE_GROUP = 10,
        /// <summary> Tag-delimited aggregate.</summary>
        TYPE_MESSAGE = 11,
        /// <summary>
        /// <para> Length-delimited aggregate.</para>
        /// <para> New in version 2.</para>
        /// </summary>
        TYPE_BYTES = 12,
        TYPE_UINT32 = 13,
        TYPE_ENUM = 14,
        TYPE_SFIXED32 = 15,
        TYPE_SFIXED64 = 16,
        TYPE_SINT32 = 17,
        /// <summary> Uses ZigZag encoding.</summary>
        TYPE_SINT64 = 18,
    }

    public enum Label
    {
        /// <summary> 0 is reserved for errors</summary>
        LABEL_OPTIONAL = 1,
        LABEL_REQUIRED = 2,
        LABEL_REPEATED = 3,
    }

    public string Name { get; set; }

    public int Number { get; set; }

    public global::Google.Protobuf.FieldDescriptorProto.Label label { get; set; }

    /// <summary>
    /// <para> If type_name is set, this need not be set.  If both this and type_name</para>
    /// <para> are set, this must be either TYPE_ENUM or TYPE_MESSAGE.</para>
    /// </summary>
    public global::Google.Protobuf.FieldDescriptorProto.Type type { get; set; }

    /// <summary>
    /// <para> For message and enum types, this is the name of the type.  If the name</para>
    /// <para> starts with a '.', it is fully-qualified.  Otherwise, C++-like scoping</para>
    /// <para> rules are used to find the type (i.e. first the nested types within this</para>
    /// <para> message are searched, then within the parent, on up to the root</para>
    /// <para> namespace).</para>
    /// </summary>
    public string TypeName { get; set; }

    /// <summary>
    /// <para> For extensions, this is the name of the type being extended.  It is</para>
    /// <para> resolved in the same manner as type_name.</para>
    /// </summary>
    public string Extendee { get; set; }

    /// <summary>
    /// <para> For numeric types, contains the original text representation of the value.</para>
    /// <para> For booleans, "true" or "false".</para>
    /// <para> For strings, contains the default text contents (not escaped in any way).</para>
    /// <para> For bytes, contains the C escaped value.  All bytes >= 128 are escaped.</para>
    /// <para> TODO(kenton):  Base-64 encode?</para>
    /// </summary>
    public string DefaultValue { get; set; }

    public FieldOptions Options { get; set; }

}

