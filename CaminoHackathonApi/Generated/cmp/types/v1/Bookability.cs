// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cmp/types/v1/bookability.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cmp.Types.V1 {

  /// <summary>Holder for reflection information generated from cmp/types/v1/bookability.proto</summary>
  public static partial class BookabilityReflection {

    #region Descriptor
    /// <summary>File descriptor for cmp/types/v1/bookability.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BookabilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5jbXAvdHlwZXMvdjEvYm9va2FiaWxpdHkucHJvdG8SDGNtcC50eXBlcy52",
            "MRoXY21wL3R5cGVzL3YxL3RpbWUucHJvdG8iaQoLQm9va2FiaWxpdHkSKwoE",
            "dHlwZRgBIAEoDjIdLmNtcC50eXBlcy52MS5Cb29rYWJpbGl0eVR5cGUSLQoR",
            "Y29uZmlybWF0aW9uX3RpbWUYAiABKAsyEi5jbXAudHlwZXMudjEuVGltZSp0",
            "Cg9Cb29rYWJpbGl0eVR5cGUSIAocQk9PS0FCSUxJVFlfVFlQRV9VTlNQRUNJ",
            "RklFRBAAEh4KGkJPT0tBQklMSVRZX1RZUEVfQVZBSUxBQkxFEAESHwobQk9P",
            "S0FCSUxJVFlfVFlQRV9PTl9SRVFVRVNUEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cmp.Types.V1.TimeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cmp.Types.V1.BookabilityType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cmp.Types.V1.Bookability), global::Cmp.Types.V1.Bookability.Parser, new[]{ "Type", "ConfirmationTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum BookabilityType {
    [pbr::OriginalName("BOOKABILITY_TYPE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("BOOKABILITY_TYPE_AVAILABLE")] Available = 1,
    [pbr::OriginalName("BOOKABILITY_TYPE_ON_REQUEST")] OnRequest = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// ![Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/bookability.proto.dot.xs.svg)
  ///
  /// [Open Message Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/bookability.proto.dot.svg)
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Bookability : pb::IMessage<Bookability>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Bookability> _parser = new pb::MessageParser<Bookability>(() => new Bookability());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Bookability> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cmp.Types.V1.BookabilityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Bookability() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Bookability(Bookability other) : this() {
      type_ = other.type_;
      confirmationTime_ = other.confirmationTime_ != null ? other.confirmationTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Bookability Clone() {
      return new Bookability(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Cmp.Types.V1.BookabilityType type_ = global::Cmp.Types.V1.BookabilityType.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cmp.Types.V1.BookabilityType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "confirmation_time" field.</summary>
    public const int ConfirmationTimeFieldNumber = 2;
    private global::Cmp.Types.V1.Time confirmationTime_;
    /// <summary>
    /// In case of a bookable=on_request status, a confirmation time should be given by
    /// the supplier. The supplier is to confirm the on-request booking with that
    /// specified time. If confirmation id not provided, the booking is to be
    /// considered "rejected".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cmp.Types.V1.Time ConfirmationTime {
      get { return confirmationTime_; }
      set {
        confirmationTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Bookability);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Bookability other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (!object.Equals(ConfirmationTime, other.ConfirmationTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::Cmp.Types.V1.BookabilityType.Unspecified) hash ^= Type.GetHashCode();
      if (confirmationTime_ != null) hash ^= ConfirmationTime.GetHashCode();
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
      if (Type != global::Cmp.Types.V1.BookabilityType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (confirmationTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ConfirmationTime);
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
      if (Type != global::Cmp.Types.V1.BookabilityType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (confirmationTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ConfirmationTime);
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
      if (Type != global::Cmp.Types.V1.BookabilityType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (confirmationTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConfirmationTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Bookability other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::Cmp.Types.V1.BookabilityType.Unspecified) {
        Type = other.Type;
      }
      if (other.confirmationTime_ != null) {
        if (confirmationTime_ == null) {
          ConfirmationTime = new global::Cmp.Types.V1.Time();
        }
        ConfirmationTime.MergeFrom(other.ConfirmationTime);
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
            Type = (global::Cmp.Types.V1.BookabilityType) input.ReadEnum();
            break;
          }
          case 18: {
            if (confirmationTime_ == null) {
              ConfirmationTime = new global::Cmp.Types.V1.Time();
            }
            input.ReadMessage(ConfirmationTime);
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
            Type = (global::Cmp.Types.V1.BookabilityType) input.ReadEnum();
            break;
          }
          case 18: {
            if (confirmationTime_ == null) {
              ConfirmationTime = new global::Cmp.Types.V1.Time();
            }
            input.ReadMessage(ConfirmationTime);
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
