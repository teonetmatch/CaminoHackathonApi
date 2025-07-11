// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cmp/types/v1/contact_info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cmp.Types.V1 {

  /// <summary>Holder for reflection information generated from cmp/types/v1/contact_info.proto</summary>
  public static partial class ContactInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for cmp/types/v1/contact_info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContactInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9jbXAvdHlwZXMvdjEvY29udGFjdF9pbmZvLnByb3RvEgxjbXAudHlwZXMu",
            "djEaGmNtcC90eXBlcy92MS9hZGRyZXNzLnByb3RvGhhjbXAvdHlwZXMvdjEv",
            "ZW1haWwucHJvdG8aF2NtcC90eXBlcy92MS9saW5rLnByb3RvGhhjbXAvdHlw",
            "ZXMvdjEvcGhvbmUucHJvdG8iogEKC0NvbnRhY3RJbmZvEiYKB2FkZHJlc3MY",
            "ASADKAsyFS5jbXAudHlwZXMudjEuQWRkcmVzcxIjCgZwaG9uZXMYAiADKAsy",
            "Ey5jbXAudHlwZXMudjEuUGhvbmUSIwoGZW1haWxzGAMgAygLMhMuY21wLnR5",
            "cGVzLnYxLkVtYWlsEiEKBWxpbmtzGAQgAygLMhIuY21wLnR5cGVzLnYxLkxp",
            "bmtiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cmp.Types.V1.AddressReflection.Descriptor, global::Cmp.Types.V1.EmailReflection.Descriptor, global::Cmp.Types.V1.LinkReflection.Descriptor, global::Cmp.Types.V1.PhoneReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cmp.Types.V1.ContactInfo), global::Cmp.Types.V1.ContactInfo.Parser, new[]{ "Address", "Phones", "Emails", "Links" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Contact Info for general use.
  ///
  /// ![Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/contact_info.proto.dot.xs.svg)
  ///
  /// [Open Message Diagram](https://storage.googleapis.com/docs-cmp-files/diagrams/proto/cmp/types/v1/contact_info.proto.dot.svg)
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ContactInfo : pb::IMessage<ContactInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ContactInfo> _parser = new pb::MessageParser<ContactInfo>(() => new ContactInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ContactInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cmp.Types.V1.ContactInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContactInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContactInfo(ContactInfo other) : this() {
      address_ = other.address_.Clone();
      phones_ = other.phones_.Clone();
      emails_ = other.emails_.Clone();
      links_ = other.links_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContactInfo Clone() {
      return new ContactInfo(this);
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Cmp.Types.V1.Address> _repeated_address_codec
        = pb::FieldCodec.ForMessage(10, global::Cmp.Types.V1.Address.Parser);
    private readonly pbc::RepeatedField<global::Cmp.Types.V1.Address> address_ = new pbc::RepeatedField<global::Cmp.Types.V1.Address>();
    /// <summary>
    /// Address
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cmp.Types.V1.Address> Address {
      get { return address_; }
    }

    /// <summary>Field number for the "phones" field.</summary>
    public const int PhonesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Cmp.Types.V1.Phone> _repeated_phones_codec
        = pb::FieldCodec.ForMessage(18, global::Cmp.Types.V1.Phone.Parser);
    private readonly pbc::RepeatedField<global::Cmp.Types.V1.Phone> phones_ = new pbc::RepeatedField<global::Cmp.Types.V1.Phone>();
    /// <summary>
    /// Phones
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cmp.Types.V1.Phone> Phones {
      get { return phones_; }
    }

    /// <summary>Field number for the "emails" field.</summary>
    public const int EmailsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Cmp.Types.V1.Email> _repeated_emails_codec
        = pb::FieldCodec.ForMessage(26, global::Cmp.Types.V1.Email.Parser);
    private readonly pbc::RepeatedField<global::Cmp.Types.V1.Email> emails_ = new pbc::RepeatedField<global::Cmp.Types.V1.Email>();
    /// <summary>
    /// Emails
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cmp.Types.V1.Email> Emails {
      get { return emails_; }
    }

    /// <summary>Field number for the "links" field.</summary>
    public const int LinksFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Cmp.Types.V1.Link> _repeated_links_codec
        = pb::FieldCodec.ForMessage(34, global::Cmp.Types.V1.Link.Parser);
    private readonly pbc::RepeatedField<global::Cmp.Types.V1.Link> links_ = new pbc::RepeatedField<global::Cmp.Types.V1.Link>();
    /// <summary>
    /// Websites
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Cmp.Types.V1.Link> Links {
      get { return links_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ContactInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ContactInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!address_.Equals(other.address_)) return false;
      if(!phones_.Equals(other.phones_)) return false;
      if(!emails_.Equals(other.emails_)) return false;
      if(!links_.Equals(other.links_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= address_.GetHashCode();
      hash ^= phones_.GetHashCode();
      hash ^= emails_.GetHashCode();
      hash ^= links_.GetHashCode();
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
      address_.WriteTo(output, _repeated_address_codec);
      phones_.WriteTo(output, _repeated_phones_codec);
      emails_.WriteTo(output, _repeated_emails_codec);
      links_.WriteTo(output, _repeated_links_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      address_.WriteTo(ref output, _repeated_address_codec);
      phones_.WriteTo(ref output, _repeated_phones_codec);
      emails_.WriteTo(ref output, _repeated_emails_codec);
      links_.WriteTo(ref output, _repeated_links_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += address_.CalculateSize(_repeated_address_codec);
      size += phones_.CalculateSize(_repeated_phones_codec);
      size += emails_.CalculateSize(_repeated_emails_codec);
      size += links_.CalculateSize(_repeated_links_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ContactInfo other) {
      if (other == null) {
        return;
      }
      address_.Add(other.address_);
      phones_.Add(other.phones_);
      emails_.Add(other.emails_);
      links_.Add(other.links_);
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
            address_.AddEntriesFrom(input, _repeated_address_codec);
            break;
          }
          case 18: {
            phones_.AddEntriesFrom(input, _repeated_phones_codec);
            break;
          }
          case 26: {
            emails_.AddEntriesFrom(input, _repeated_emails_codec);
            break;
          }
          case 34: {
            links_.AddEntriesFrom(input, _repeated_links_codec);
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
            address_.AddEntriesFrom(ref input, _repeated_address_codec);
            break;
          }
          case 18: {
            phones_.AddEntriesFrom(ref input, _repeated_phones_codec);
            break;
          }
          case 26: {
            emails_.AddEntriesFrom(ref input, _repeated_emails_codec);
            break;
          }
          case 34: {
            links_.AddEntriesFrom(ref input, _repeated_links_codec);
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
