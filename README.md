# Protocol Buffers C# Code Generator

https://silentorbit.com/protobuf/

C# source generator for serialization into [Googles Protocol Buffers](http://code.google.com/apis/protocolbuffers/docs/overview.html) wire format.

Parses a .proto file and generates C# source files
with classes for every message as well as code for
reading and writing them to the Protocol Buffers binary format.

## Usage

Add the following to your `.csproj` file:

    <ItemGroup>
      <PackageReference Include="SilentOrbit.ProtocolBuffers.ProtocolBufferParser" Version="0.0.1" />
      <PackageReference Include="SilentOrbit.ProtocolBuffers.SourceGenerator" Version="0.0.1" />
      <AdditionalFiles Include="**\*.proto" />
    </ItemGroup>


## Basic Features

 * Source Generator - transform .proto specifications directly into complete c# code, classes and serializers.
 * Generated code is relatively easy to debug(only hope you wont have too)
 * Generated code does not use reflection, works after code obfuscation.

## Advanced Features

These features are local to this project.
They affect how you will work with the generated code.
It does not affect the final wire format.
Any other Protocol Buffers implementation should be able to communicate using the same .proto specification.

For the latest features, see Test/csharpgen.proto

These local features are implemented in the Test project.

Message options:

 * access - set the acces of the generated class to internal rather than public.
 * triggers - have the class methods BeforeSerialize and AfterDeserialize called accordingly.
 * preserveunknown - keep all unknown fields during deserialization to be written back when serializing the class.
 * external - generate serialization code for a class we don't have control over, such as one from a third party DLL.
 * imported - utilize already generated code in the current generated messages.
 * type - default: class, but you can make the serializer work with struct or interfaces.

Field options:

 * access - default: public, can be any, even private if generating a local class(default)
 * codetype - set an int64 field type to "DateTime" or "TimeSpan", the serializer will do the conversion for you.
 * generate - if set to false(default: true), the field/property is expected to be defined elsewhere in the project rather than the generated code.
 * readonly - make the message field a c# readonly field rather than a property.

## Example

This is a part of the Test/Example.proto:

	package ExampleNamespace;
	
	message Person {
	  option namespace = "Personal";
	  
	  required string name = 1;
	  required int32 id = 2;
	  optional string email = 3;
	
	  enum PhoneType {
	    MOBILE = 0;
	    HOME = 1;
	    WORK = 2;
	  }
	
	  message PhoneNumber {
	    required string number = 1;
	    optional PhoneType type = 2 [default = HOME];
	  }
	
	  repeated PhoneNumber phone = 4;
	}

When compiled it you will have the following class to work with.

	public partial class Person
	{
		public enum PhoneType
		{
			MOBILE = 0,
			HOME = 1,
			WORK = 2,
		}
	
		public string Name { get; set; }
		public int Id { get; set; }
		public string Email { get; set; }
		public List<Personal.Person.PhoneNumber> Phone { get; set; }
	
	
		public partial class PhoneNumber
		{
			public string Number { get; set; }
			public Personal.Person.PhoneType Type { get; set; }
		}
	}

Writing this to a stream:

	Person person = new Person();
	...
	Person.Serialize(stream, person);

Reading from a stream:

	Person person2 = Person.Deserialize(stream);
