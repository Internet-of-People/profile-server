// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: IopCan.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Iop.Can {

  /// <summary>Holder for reflection information generated from IopCan.proto</summary>
  public static partial class IopCanReflection {

    #region Descriptor
    /// <summary>File descriptor for IopCan.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IopCanReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxJb3BDYW4ucHJvdG8SB2lvcC5jYW4itQEKDENhbklwbnNFbnRyeRINCgV2",
            "YWx1ZRgBIAEoDBIRCglzaWduYXR1cmUYAiABKAwSOQoNdmFsaWRpdHlfdHlw",
            "ZRgDIAEoDjIiLmlvcC5jYW4uQ2FuSXBuc0VudHJ5LlZhbGlkaXR5VHlwZRIQ",
            "Cgh2YWxpZGl0eRgEIAEoDBIQCghzZXF1ZW5jZRgFIAEoBBILCgN0dGwYBiAB",
            "KAQiFwoMVmFsaWRpdHlUeXBlEgcKA0VPTBAAImoKDENhbkNyeXB0b0tleRIr",
            "CgR0eXBlGAEgASgOMh0uaW9wLmNhbi5DYW5DcnlwdG9LZXkuS2V5VHlwZRIM",
            "CgRkYXRhGAIgASgMIh8KB0tleVR5cGUSBwoDUlNBEAASCwoHRUQyNTUxORAB",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Iop.Can.CanIpnsEntry), global::Iop.Can.CanIpnsEntry.Parser, new[]{ "Value", "Signature", "ValidityType", "Validity", "Sequence", "Ttl" }, null, new[]{ typeof(global::Iop.Can.CanIpnsEntry.Types.ValidityType) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Iop.Can.CanCryptoKey), global::Iop.Can.CanCryptoKey.Parser, new[]{ "Type", "Data" }, null, new[]{ typeof(global::Iop.Can.CanCryptoKey.Types.KeyType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  /// IPNS record as defined in https://github.com/DeCentral-Budapest/go-ipfs/blob/master/namesys/pb/namesys.proto
  /// </summary>
  public sealed partial class CanIpnsEntry : pb::IMessage<CanIpnsEntry> {
    private static readonly pb::MessageParser<CanIpnsEntry> _parser = new pb::MessageParser<CanIpnsEntry>(() => new CanIpnsEntry());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CanIpnsEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Iop.Can.IopCanReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CanIpnsEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CanIpnsEntry(CanIpnsEntry other) : this() {
      value_ = other.value_;
      signature_ = other.signature_;
      validityType_ = other.validityType_;
      validity_ = other.validity_;
      sequence_ = other.sequence_;
      ttl_ = other.ttl_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CanIpnsEntry Clone() {
      return new CanIpnsEntry(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private pb::ByteString value_ = pb::ByteString.Empty;
    /// <summary>
    /// IPFS path string converted to byte array. The path string has to be "/ipfs/$objectHashEncoded",
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 2;
    private pb::ByteString signature_ = pb::ByteString.Empty;
    /// <summary>
    /// where $objectHashEncoded is base58 encoded hash of the CAN object that the client received as `CanStoreDataResponse.hash`.
    /// The base58 encoding must be used without the multibase prefix - for example "/ipfs/QmaRvpLT4RgBDVY6cQKwqQGQNtbM31KSqh8TxvQgFoEUus".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "validity_type" field.</summary>
    public const int ValidityTypeFieldNumber = 3;
    private global::Iop.Can.CanIpnsEntry.Types.ValidityType validityType_ = 0;
    /// <summary>
    /// Type of meaning of 'validity' field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Iop.Can.CanIpnsEntry.Types.ValidityType ValidityType {
      get { return validityType_; }
      set {
        validityType_ = value;
      }
    }

    /// <summary>Field number for the "validity" field.</summary>
    public const int ValidityFieldNumber = 4;
    private pb::ByteString validity_ = pb::ByteString.Empty;
    /// <summary>
    /// RFC3339 UTF-8 string converted to byte array.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Validity {
      get { return validity_; }
      set {
        validity_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sequence" field.</summary>
    public const int SequenceFieldNumber = 5;
    private ulong sequence_;
    /// <summary>
    /// Record sequence number that has to be increased on updates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Sequence {
      get { return sequence_; }
      set {
        sequence_ = value;
      }
    }

    /// <summary>Field number for the "ttl" field.</summary>
    public const int TtlFieldNumber = 6;
    private ulong ttl_;
    /// <summary>
    /// Time to live of the IPNS record in cache in nanoseconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Ttl {
      get { return ttl_; }
      set {
        ttl_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CanIpnsEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CanIpnsEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      if (Signature != other.Signature) return false;
      if (ValidityType != other.ValidityType) return false;
      if (Validity != other.Validity) return false;
      if (Sequence != other.Sequence) return false;
      if (Ttl != other.Ttl) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (ValidityType != 0) hash ^= ValidityType.GetHashCode();
      if (Validity.Length != 0) hash ^= Validity.GetHashCode();
      if (Sequence != 0UL) hash ^= Sequence.GetHashCode();
      if (Ttl != 0UL) hash ^= Ttl.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Value);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Signature);
      }
      if (ValidityType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ValidityType);
      }
      if (Validity.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Validity);
      }
      if (Sequence != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(Sequence);
      }
      if (Ttl != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(Ttl);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
      }
      if (ValidityType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ValidityType);
      }
      if (Validity.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Validity);
      }
      if (Sequence != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Sequence);
      }
      if (Ttl != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Ttl);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CanIpnsEntry other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.ValidityType != 0) {
        ValidityType = other.ValidityType;
      }
      if (other.Validity.Length != 0) {
        Validity = other.Validity;
      }
      if (other.Sequence != 0UL) {
        Sequence = other.Sequence;
      }
      if (other.Ttl != 0UL) {
        Ttl = other.Ttl;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Value = input.ReadBytes();
            break;
          }
          case 18: {
            Signature = input.ReadBytes();
            break;
          }
          case 24: {
            validityType_ = (global::Iop.Can.CanIpnsEntry.Types.ValidityType) input.ReadEnum();
            break;
          }
          case 34: {
            Validity = input.ReadBytes();
            break;
          }
          case 40: {
            Sequence = input.ReadUInt64();
            break;
          }
          case 48: {
            Ttl = input.ReadUInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CanIpnsEntry message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Type of validity value.
      /// </summary>
      public enum ValidityType {
        /// <summary>
        /// Validity value is specifies a time until which the IPNS record is valid.
        /// </summary>
        [pbr::OriginalName("EOL")] Eol = 0,
      }

    }
    #endregion

  }

  /// <summary>
  ///
  /// Representation of a cryptographic key in CAN API.
  /// </summary>
  public sealed partial class CanCryptoKey : pb::IMessage<CanCryptoKey> {
    private static readonly pb::MessageParser<CanCryptoKey> _parser = new pb::MessageParser<CanCryptoKey>(() => new CanCryptoKey());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CanCryptoKey> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Iop.Can.IopCanReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CanCryptoKey() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CanCryptoKey(CanCryptoKey other) : this() {
      type_ = other.type_;
      data_ = other.data_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CanCryptoKey Clone() {
      return new CanCryptoKey(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Iop.Can.CanCryptoKey.Types.KeyType type_ = 0;
    /// <summary>
    /// Type of the key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Iop.Can.CanCryptoKey.Types.KeyType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 2;
    private pb::ByteString data_ = pb::ByteString.Empty;
    /// <summary>
    /// Key binary data.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CanCryptoKey);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CanCryptoKey other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Data != other.Data) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Data);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CanCryptoKey other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            type_ = (global::Iop.Can.CanCryptoKey.Types.KeyType) input.ReadEnum();
            break;
          }
          case 18: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CanCryptoKey message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Type of the key algorithm. 
      /// </summary>
      public enum KeyType {
        [pbr::OriginalName("RSA")] Rsa = 0,
        [pbr::OriginalName("ED25519")] Ed25519 = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
