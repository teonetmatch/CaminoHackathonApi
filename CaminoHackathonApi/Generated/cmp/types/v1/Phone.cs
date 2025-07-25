// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cmp/types/v1/phone.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cmp.Types.V1 {

  /// <summary>Holder for reflection information generated from cmp/types/v1/phone.proto</summary>
  public static partial class PhoneReflection {

    #region Descriptor
    /// <summary>File descriptor for cmp/types/v1/phone.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PhoneReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhjbXAvdHlwZXMvdjEvcGhvbmUucHJvdG8SDGNtcC50eXBlcy52MSJTCgVQ",
            "aG9uZRIOCgZudW1iZXIYASABKAkSJQoEdHlwZRgCIAEoDjIXLmNtcC50eXBl",
            "cy52MS5QaG9uZVR5cGUSEwoLZGVzY3JpcHRpb24YAyABKAkq2QMKCVBob25l",
            "VHlwZRIaChZQSE9ORV9UWVBFX1VOU1BFQ0lGSUVEEAASFAoQUEhPTkVfVFlQ",
            "RV9PVEhFUhABEhgKFFBIT05FX1RZUEVfUkVDRVBUSU9OEAISFgoSUEhPTkVf",
            "VFlQRV9CT09LSU5HEAMSFgoSUEhPTkVfVFlQRV9TVVBQT1JUEAQSGAoUUEhP",
            "TkVfVFlQRV9JTlFVSVJJRVMQBRIgChxQSE9ORV9UWVBFX1RSQU5TUE9SVF9T",
            "RVJWSUNFEAYSHQoZUEhPTkVfVFlQRV9SRU5UQUxfU0VSVklDRRAHEiMKH1BI",
            "T05FX1RZUEVfQUNUSVZJVFlfQ09PUkRJTkFUT1IQCBIWChJQSE9ORV9UWVBF",
            "X0JJTExJTkcQCRIYChRQSE9ORV9UWVBFX0VNRVJHRU5DWRAKEhIKDlBIT05F",
            "X1RZUEVfRkFYEAsSFQoRUEhPTkVfVFlQRV9NT0JJTEUQDBITCg9QSE9ORV9U",
            "WVBFX0hPTUUQDRIXChNQSE9ORV9UWVBFX0JVU0lORVNTEA4SGAoUUEhPTkVf",
            "VFlQRV9UT0xMX0ZSRUUQDxIWChJQSE9ORV9UWVBFX0hPVExJTkUQEBITCg9Q",
            "SE9ORV9UWVBFX1dPUksQEWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cmp.Types.V1.PhoneType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cmp.Types.V1.Phone), global::Cmp.Types.V1.Phone.Parser, new[]{ "Number", "Type", "Description" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum PhoneType {
    [pbr::OriginalName("PHONE_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// For phone numbers that don't fit into other categories.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_OTHER")] Other = 1,
    /// <summary>
    /// For accommodation properties like hotels.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_RECEPTION")] Reception = 2,
    /// <summary>
    /// Booking-related inquiries.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_BOOKING")] Booking = 3,
    /// <summary>
    /// Customer support and service.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_SUPPORT")] Support = 4,
    /// <summary>
    /// General inquiries.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_INQUIRIES")] Inquiries = 5,
    /// <summary>
    /// Transport services, like taxi or shuttle services.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_TRANSPORT_SERVICE")] TransportService = 6,
    /// <summary>
    /// Car rental service numbers.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_RENTAL_SERVICE")] RentalService = 7,
    /// <summary>
    /// Coordinators for activities or events.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_ACTIVITY_COORDINATOR")] ActivityCoordinator = 8,
    /// <summary>
    /// Billing and payment inquiries.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_BILLING")] Billing = 9,
    /// <summary>
    /// Emergency contact numbers.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_EMERGENCY")] Emergency = 10,
    /// <summary>
    /// Fax numbers.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_FAX")] Fax = 11,
    /// <summary>
    /// Mobile phone numbers.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_MOBILE")] Mobile = 12,
    /// <summary>
    /// Home phone numbers.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_HOME")] Home = 13,
    /// <summary>
    /// Business or office phone numbers.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_BUSINESS")] Business = 14,
    /// <summary>
    /// Toll-free numbers.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_TOLL_FREE")] TollFree = 15,
    /// <summary>
    /// Hotlines, for specialized support or services.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_HOTLINE")] Hotline = 16,
    /// <summary>
    /// Work phone numbers.
    /// </summary>
    [pbr::OriginalName("PHONE_TYPE_WORK")] Work = 17,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Phone type to be used in various types as hotels, holiday homes etc.
  ///
  /// ![Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/phone.proto.dot.xs.svg)
  ///
  /// [Open Message Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/phone.proto.dot.svg)
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Phone : pb::IMessage<Phone>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Phone> _parser = new pb::MessageParser<Phone>(() => new Phone());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Phone> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cmp.Types.V1.PhoneReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Phone() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Phone(Phone other) : this() {
      number_ = other.number_;
      type_ = other.type_;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Phone Clone() {
      return new Phone(this);
    }

    /// <summary>Field number for the "number" field.</summary>
    public const int NumberFieldNumber = 1;
    private string number_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Number {
      get { return number_; }
      set {
        number_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Cmp.Types.V1.PhoneType type_ = global::Cmp.Types.V1.PhoneType.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cmp.Types.V1.PhoneType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Phone);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Phone other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Number != other.Number) return false;
      if (Type != other.Type) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Number.Length != 0) hash ^= Number.GetHashCode();
      if (Type != global::Cmp.Types.V1.PhoneType.Unspecified) hash ^= Type.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Number.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Number);
      }
      if (Type != global::Cmp.Types.V1.PhoneType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Number.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Number);
      }
      if (Type != global::Cmp.Types.V1.PhoneType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Number.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Number);
      }
      if (Type != global::Cmp.Types.V1.PhoneType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Phone other) {
      if (other == null) {
        return;
      }
      if (other.Number.Length != 0) {
        Number = other.Number;
      }
      if (other.Type != global::Cmp.Types.V1.PhoneType.Unspecified) {
        Type = other.Type;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Number = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Cmp.Types.V1.PhoneType) input.ReadEnum();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Number = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Cmp.Types.V1.PhoneType) input.ReadEnum();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
