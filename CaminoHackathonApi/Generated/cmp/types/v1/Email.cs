// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cmp/types/v1/email.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cmp.Types.V1 {

  /// <summary>Holder for reflection information generated from cmp/types/v1/email.proto</summary>
  public static partial class EmailReflection {

    #region Descriptor
    /// <summary>File descriptor for cmp/types/v1/email.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EmailReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhjbXAvdHlwZXMvdjEvZW1haWwucHJvdG8SDGNtcC50eXBlcy52MSJUCgVF",
            "bWFpbBIPCgdhZGRyZXNzGAEgASgJEiUKBHR5cGUYAiABKA4yFy5jbXAudHlw",
            "ZXMudjEuRW1haWxUeXBlEhMKC2Rlc2NyaXB0aW9uGAMgASgJKuEDCglFbWFp",
            "bFR5cGUSGgoWRU1BSUxfVFlQRV9VTlNQRUNJRklFRBAAEhQKEEVNQUlMX1RZ",
            "UEVfT1RIRVIQARIYChRFTUFJTF9UWVBFX1JFQ0VQVElPThACEhYKEkVNQUlM",
            "X1RZUEVfQk9PS0lORxADEhYKEkVNQUlMX1RZUEVfU1VQUE9SVBAEEh8KG0VN",
            "QUlMX1RZUEVfSU5RVUlSWV9SRVNQT05TRRAFEh0KGUVNQUlMX1RZUEVfVFJB",
            "TlNQT1JUX0lORk8QBhIiCh5FTUFJTF9UWVBFX1JFTlRBTF9DT05GSVJNQVRJ",
            "T04QBxIfChtFTUFJTF9UWVBFX0FDVElWSVRZX0RFVEFJTFMQCBIfChtFTUFJ",
            "TF9UWVBFX0ZFRURCQUNLX1JFUVVFU1QQCRIWChJFTUFJTF9UWVBFX0JJTExJ",
            "TkcQChIbChdFTUFJTF9UWVBFX0NBTkNFTExBVElPThALEhcKE0VNQUlMX1RZ",
            "UEVfUkVNSU5ERVIQDBIaChZFTUFJTF9UWVBFX1BST01PVElPTkFMEA0SFgoS",
            "RU1BSUxfVFlQRV9VUERBVEVTEA4SFQoRRU1BSUxfVFlQRV9BTEVSVFMQDxIZ",
            "ChVFTUFJTF9UWVBFX05FV1NMRVRURVIQEGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cmp.Types.V1.EmailType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cmp.Types.V1.Email), global::Cmp.Types.V1.Email.Parser, new[]{ "Address", "Type", "Description" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Email Types
  ///
  /// FIXME: Check email types
  /// </summary>
  public enum EmailType {
    [pbr::OriginalName("EMAIL_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// For emails that don't fit into other categories.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_OTHER")] Other = 1,
    /// <summary>
    /// For accommodation properties like hotels.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_RECEPTION")] Reception = 2,
    /// <summary>
    /// For booking confirmations.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_BOOKING")] Booking = 3,
    /// <summary>
    /// General customer support.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_SUPPORT")] Support = 4,
    /// <summary>
    /// Responses to customer inquiries.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_INQUIRY_RESPONSE")] InquiryResponse = 5,
    /// <summary>
    /// Information regarding transport services.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_TRANSPORT_INFO")] TransportInfo = 6,
    /// <summary>
    /// Confirmation for car rentals.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_RENTAL_CONFIRMATION")] RentalConfirmation = 7,
    /// <summary>
    /// Details about booked activities or events.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_ACTIVITY_DETAILS")] ActivityDetails = 8,
    /// <summary>
    /// Requests for customer feedback.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_FEEDBACK_REQUEST")] FeedbackRequest = 9,
    /// <summary>
    /// Billing and payment related emails.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_BILLING")] Billing = 10,
    /// <summary>
    /// Cancellation notices.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_CANCELLATION")] Cancellation = 11,
    /// <summary>
    /// Reminders for reservations or activities.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_REMINDER")] Reminder = 12,
    /// <summary>
    /// Promotional emails, offers, discounts.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_PROMOTIONAL")] Promotional = 13,
    /// <summary>
    /// Updates about services or policy changes.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_UPDATES")] Updates = 14,
    /// <summary>
    /// Alerts or important notices.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_ALERTS")] Alerts = 15,
    /// <summary>
    /// Regular newsletters.
    /// </summary>
    [pbr::OriginalName("EMAIL_TYPE_NEWSLETTER")] Newsletter = 16,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Email type for general use.
  ///
  /// ![Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/email.proto.dot.xs.svg)
  ///
  /// [Open Message Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/email.proto.dot.svg)
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Email : pb::IMessage<Email>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Email> _parser = new pb::MessageParser<Email>(() => new Email());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Email> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cmp.Types.V1.EmailReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Email() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Email(Email other) : this() {
      address_ = other.address_;
      type_ = other.type_;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Email Clone() {
      return new Email(this);
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 1;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Cmp.Types.V1.EmailType type_ = global::Cmp.Types.V1.EmailType.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cmp.Types.V1.EmailType Type {
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
      return Equals(other as Email);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Email other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Address != other.Address) return false;
      if (Type != other.Type) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (Type != global::Cmp.Types.V1.EmailType.Unspecified) hash ^= Type.GetHashCode();
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
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (Type != global::Cmp.Types.V1.EmailType.Unspecified) {
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
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (Type != global::Cmp.Types.V1.EmailType.Unspecified) {
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
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (Type != global::Cmp.Types.V1.EmailType.Unspecified) {
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
    public void MergeFrom(Email other) {
      if (other == null) {
        return;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.Type != global::Cmp.Types.V1.EmailType.Unspecified) {
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
            Address = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Cmp.Types.V1.EmailType) input.ReadEnum();
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
            Address = input.ReadString();
            break;
          }
          case 16: {
            Type = (global::Cmp.Types.V1.EmailType) input.ReadEnum();
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
