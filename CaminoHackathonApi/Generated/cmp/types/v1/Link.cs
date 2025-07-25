// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cmp/types/v1/link.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cmp.Types.V1 {

  /// <summary>Holder for reflection information generated from cmp/types/v1/link.proto</summary>
  public static partial class LinkReflection {

    #region Descriptor
    /// <summary>File descriptor for cmp/types/v1/link.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdjbXAvdHlwZXMvdjEvbGluay5wcm90bxIMY21wLnR5cGVzLnYxIk4KBExp",
            "bmsSJAoEdHlwZRgBIAEoDjIWLmNtcC50eXBlcy52MS5MaW5rVHlwZRITCgtk",
            "ZXNjcmlwdGlvbhgCIAEoCRILCgNyZWYYAyABKAkqlAMKCExpbmtUeXBlEhkK",
            "FUxJTktfVFlQRV9VTlNQRUNJRklFRBAAEhMKD0xJTktfVFlQRV9PVEhFUhAB",
            "EhUKEUxJTktfVFlQRV9XRUJTSVRFEAISFQoRTElOS19UWVBFX0NIRUNLSU4Q",
            "AxIVChFMSU5LX1RZUEVfQk9PS0lORxAEEhUKEUxJTktfVFlQRV9TVVBQT1JU",
            "EAUSFgoSTElOS19UWVBFX0ZFRURCQUNLEAYSFwoTTElOS19UWVBFX0NPTVBM",
            "QUlOVBAHEhYKEkxJTktfVFlQRV9GQUNFQk9PSxAIEhcKE0xJTktfVFlQRV9J",
            "TlNUQUdSQU0QCRIPCgtMSU5LX1RZUEVfWBAKEhYKEkxJTktfVFlQRV9MSU5L",
            "RURJThALEhUKEUxJTktfVFlQRV9ESVNDT1JEEAwSFAoQTElOS19UWVBFX01F",
            "RElVTRANEhQKEExJTktfVFlQRV9USUtUT0sQDhIWChJMSU5LX1RZUEVfV0hB",
            "VFNBUFAQDxIWChJMSU5LX1RZUEVfVEVMRUdSQU0QEGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cmp.Types.V1.LinkType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cmp.Types.V1.Link), global::Cmp.Types.V1.Link.Parser, new[]{ "Type", "Description", "Ref" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum LinkType {
    [pbr::OriginalName("LINK_TYPE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("LINK_TYPE_OTHER")] Other = 1,
    [pbr::OriginalName("LINK_TYPE_WEBSITE")] Website = 2,
    [pbr::OriginalName("LINK_TYPE_CHECKIN")] Checkin = 3,
    [pbr::OriginalName("LINK_TYPE_BOOKING")] Booking = 4,
    [pbr::OriginalName("LINK_TYPE_SUPPORT")] Support = 5,
    [pbr::OriginalName("LINK_TYPE_FEEDBACK")] Feedback = 6,
    [pbr::OriginalName("LINK_TYPE_COMPLAINT")] Complaint = 7,
    [pbr::OriginalName("LINK_TYPE_FACEBOOK")] Facebook = 8,
    [pbr::OriginalName("LINK_TYPE_INSTAGRAM")] Instagram = 9,
    [pbr::OriginalName("LINK_TYPE_X")] X = 10,
    [pbr::OriginalName("LINK_TYPE_LINKEDIN")] Linkedin = 11,
    [pbr::OriginalName("LINK_TYPE_DISCORD")] Discord = 12,
    [pbr::OriginalName("LINK_TYPE_MEDIUM")] Medium = 13,
    [pbr::OriginalName("LINK_TYPE_TIKTOK")] Tiktok = 14,
    [pbr::OriginalName("LINK_TYPE_WHATSAPP")] Whatsapp = 15,
    [pbr::OriginalName("LINK_TYPE_TELEGRAM")] Telegram = 16,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Link is used to represent websites, social media contact, online check-in url, ... etc
  ///
  /// ![Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/link.proto.dot.xs.svg)
  ///
  /// [Open Message Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/link.proto.dot.svg)
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Link : pb::IMessage<Link>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Link> _parser = new pb::MessageParser<Link>(() => new Link());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Link> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cmp.Types.V1.LinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Link() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Link(Link other) : this() {
      type_ = other.type_;
      description_ = other.description_;
      ref_ = other.ref_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Link Clone() {
      return new Link(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Cmp.Types.V1.LinkType type_ = global::Cmp.Types.V1.LinkType.Unspecified;
    /// <summary>
    /// Link type
    ///
    /// Ex: "LG" or "TC"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cmp.Types.V1.LinkType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    /// <summary>
    /// Link description
    ///
    /// Ex: "Baggage conditions"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ref" field.</summary>
    public const int RefFieldNumber = 3;
    private string ref_ = "";
    /// <summary>
    /// Link reference
    ///
    /// Ex: "https://api.lyko.tech/v2.1/transfers/ebaa9aed-dbc4-4d51-a41a-336a3c3e9bfc/pdf-terms-and-conditions"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Ref {
      get { return ref_; }
      set {
        ref_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Link);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Link other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Description != other.Description) return false;
      if (Ref != other.Ref) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::Cmp.Types.V1.LinkType.Unspecified) hash ^= Type.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Ref.Length != 0) hash ^= Ref.GetHashCode();
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
      if (Type != global::Cmp.Types.V1.LinkType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Ref.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ref);
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
      if (Type != global::Cmp.Types.V1.LinkType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Ref.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ref);
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
      if (Type != global::Cmp.Types.V1.LinkType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Ref.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ref);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Link other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::Cmp.Types.V1.LinkType.Unspecified) {
        Type = other.Type;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Ref.Length != 0) {
        Ref = other.Ref;
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
          case 8: {
            Type = (global::Cmp.Types.V1.LinkType) input.ReadEnum();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 26: {
            Ref = input.ReadString();
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
          case 8: {
            Type = (global::Cmp.Types.V1.LinkType) input.ReadEnum();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 26: {
            Ref = input.ReadString();
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
