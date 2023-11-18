// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto_file.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from proto_file.proto</summary>
public static partial class ProtoFileReflection {

  #region Descriptor
  /// <summary>File descriptor for proto_file.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ProtoFileReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBwcm90b19maWxlLnByb3RvIkoKBUJsb2NrEgwKBGhhc2gYASABKAwSDQoF",
          "ZXBvY2gYAiABKAUSDgoGbGVuZ3RoGAMgASgFEhQKDHRyYW5zYWN0aW9ucxgE",
          "IAEoCSJOCgdDb250ZW50EhsKB21lc3NhZ2UYASABKAsyCC5NZXNzYWdlSAAS",
          "FwoFYmxvY2sYAiABKAsyBi5CbG9ja0gAQg0KC0NvbnRlbnREYXRhIlEKB01l",
          "c3NhZ2USGwoMbWVzc2FnZV90eXBlGAEgASgOMgUuVHlwZRIZCgdjb250ZW50",
          "GAIgASgLMgguQ29udGVudBIOCgZzZW5kZXIYAyABKAUqJwoEVHlwZRILCgdQ",
          "cm9wb3NlEAASCAoEVm90ZRABEggKBEVjaG8QAmIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Type), }, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Block), global::Block.Parser, new[]{ "Hash", "Epoch", "Length", "Transactions" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Content), global::Content.Parser, new[]{ "Message", "Block" }, new[]{ "ContentData" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Message), global::Message.Parser, new[]{ "MessageType", "Content", "Sender" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Enums
public enum Type {
  [pbr::OriginalName("Propose")] Propose = 0,
  [pbr::OriginalName("Vote")] Vote = 1,
  [pbr::OriginalName("Echo")] Echo = 2,
}

#endregion

#region Messages
[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class Block : pb::IMessage<Block>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Block> _parser = new pb::MessageParser<Block>(() => new Block());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Block> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ProtoFileReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Block() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Block(Block other) : this() {
    hash_ = other.hash_;
    epoch_ = other.epoch_;
    length_ = other.length_;
    transactions_ = other.transactions_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Block Clone() {
    return new Block(this);
  }

  /// <summary>Field number for the "hash" field.</summary>
  public const int HashFieldNumber = 1;
  private pb::ByteString hash_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pb::ByteString Hash {
    get { return hash_; }
    set {
      hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "epoch" field.</summary>
  public const int EpochFieldNumber = 2;
  private int epoch_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Epoch {
    get { return epoch_; }
    set {
      epoch_ = value;
    }
  }

  /// <summary>Field number for the "length" field.</summary>
  public const int LengthFieldNumber = 3;
  private int length_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Length {
    get { return length_; }
    set {
      length_ = value;
    }
  }

  /// <summary>Field number for the "transactions" field.</summary>
  public const int TransactionsFieldNumber = 4;
  private string transactions_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Transactions {
    get { return transactions_; }
    set {
      transactions_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Block);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Block other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Hash != other.Hash) return false;
    if (Epoch != other.Epoch) return false;
    if (Length != other.Length) return false;
    if (Transactions != other.Transactions) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Hash.Length != 0) hash ^= Hash.GetHashCode();
    if (Epoch != 0) hash ^= Epoch.GetHashCode();
    if (Length != 0) hash ^= Length.GetHashCode();
    if (Transactions.Length != 0) hash ^= Transactions.GetHashCode();
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
    if (Hash.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Hash);
    }
    if (Epoch != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Epoch);
    }
    if (Length != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Length);
    }
    if (Transactions.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Transactions);
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
    if (Hash.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Hash);
    }
    if (Epoch != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Epoch);
    }
    if (Length != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Length);
    }
    if (Transactions.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Transactions);
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
    if (Hash.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Hash);
    }
    if (Epoch != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Epoch);
    }
    if (Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Length);
    }
    if (Transactions.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Transactions);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Block other) {
    if (other == null) {
      return;
    }
    if (other.Hash.Length != 0) {
      Hash = other.Hash;
    }
    if (other.Epoch != 0) {
      Epoch = other.Epoch;
    }
    if (other.Length != 0) {
      Length = other.Length;
    }
    if (other.Transactions.Length != 0) {
      Transactions = other.Transactions;
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
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Hash = input.ReadBytes();
          break;
        }
        case 16: {
          Epoch = input.ReadInt32();
          break;
        }
        case 24: {
          Length = input.ReadInt32();
          break;
        }
        case 34: {
          Transactions = input.ReadString();
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
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Hash = input.ReadBytes();
          break;
        }
        case 16: {
          Epoch = input.ReadInt32();
          break;
        }
        case 24: {
          Length = input.ReadInt32();
          break;
        }
        case 34: {
          Transactions = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class Content : pb::IMessage<Content>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Content> _parser = new pb::MessageParser<Content>(() => new Content());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Content> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ProtoFileReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Content() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Content(Content other) : this() {
    switch (other.ContentDataCase) {
      case ContentDataOneofCase.Message:
        Message = other.Message.Clone();
        break;
      case ContentDataOneofCase.Block:
        Block = other.Block.Clone();
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Content Clone() {
    return new Content(this);
  }

  /// <summary>Field number for the "message" field.</summary>
  public const int MessageFieldNumber = 1;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Message Message {
    get { return contentDataCase_ == ContentDataOneofCase.Message ? (global::Message) contentData_ : null; }
    set {
      contentData_ = value;
      contentDataCase_ = value == null ? ContentDataOneofCase.None : ContentDataOneofCase.Message;
    }
  }

  /// <summary>Field number for the "block" field.</summary>
  public const int BlockFieldNumber = 2;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Block Block {
    get { return contentDataCase_ == ContentDataOneofCase.Block ? (global::Block) contentData_ : null; }
    set {
      contentData_ = value;
      contentDataCase_ = value == null ? ContentDataOneofCase.None : ContentDataOneofCase.Block;
    }
  }

  private object contentData_;
  /// <summary>Enum of possible cases for the "ContentData" oneof.</summary>
  public enum ContentDataOneofCase {
    None = 0,
    Message = 1,
    Block = 2,
  }
  private ContentDataOneofCase contentDataCase_ = ContentDataOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ContentDataOneofCase ContentDataCase {
    get { return contentDataCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearContentData() {
    contentDataCase_ = ContentDataOneofCase.None;
    contentData_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Content);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Content other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Message, other.Message)) return false;
    if (!object.Equals(Block, other.Block)) return false;
    if (ContentDataCase != other.ContentDataCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (contentDataCase_ == ContentDataOneofCase.Message) hash ^= Message.GetHashCode();
    if (contentDataCase_ == ContentDataOneofCase.Block) hash ^= Block.GetHashCode();
    hash ^= (int) contentDataCase_;
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
    if (contentDataCase_ == ContentDataOneofCase.Message) {
      output.WriteRawTag(10);
      output.WriteMessage(Message);
    }
    if (contentDataCase_ == ContentDataOneofCase.Block) {
      output.WriteRawTag(18);
      output.WriteMessage(Block);
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
    if (contentDataCase_ == ContentDataOneofCase.Message) {
      output.WriteRawTag(10);
      output.WriteMessage(Message);
    }
    if (contentDataCase_ == ContentDataOneofCase.Block) {
      output.WriteRawTag(18);
      output.WriteMessage(Block);
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
    if (contentDataCase_ == ContentDataOneofCase.Message) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Message);
    }
    if (contentDataCase_ == ContentDataOneofCase.Block) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Block);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Content other) {
    if (other == null) {
      return;
    }
    switch (other.ContentDataCase) {
      case ContentDataOneofCase.Message:
        if (Message == null) {
          Message = new global::Message();
        }
        Message.MergeFrom(other.Message);
        break;
      case ContentDataOneofCase.Block:
        if (Block == null) {
          Block = new global::Block();
        }
        Block.MergeFrom(other.Block);
        break;
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
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          global::Message subBuilder = new global::Message();
          if (contentDataCase_ == ContentDataOneofCase.Message) {
            subBuilder.MergeFrom(Message);
          }
          input.ReadMessage(subBuilder);
          Message = subBuilder;
          break;
        }
        case 18: {
          global::Block subBuilder = new global::Block();
          if (contentDataCase_ == ContentDataOneofCase.Block) {
            subBuilder.MergeFrom(Block);
          }
          input.ReadMessage(subBuilder);
          Block = subBuilder;
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
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          global::Message subBuilder = new global::Message();
          if (contentDataCase_ == ContentDataOneofCase.Message) {
            subBuilder.MergeFrom(Message);
          }
          input.ReadMessage(subBuilder);
          Message = subBuilder;
          break;
        }
        case 18: {
          global::Block subBuilder = new global::Block();
          if (contentDataCase_ == ContentDataOneofCase.Block) {
            subBuilder.MergeFrom(Block);
          }
          input.ReadMessage(subBuilder);
          Block = subBuilder;
          break;
        }
      }
    }
  }
  #endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class Message : pb::IMessage<Message>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Message> _parser = new pb::MessageParser<Message>(() => new Message());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Message> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ProtoFileReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Message() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Message(Message other) : this() {
    messageType_ = other.messageType_;
    content_ = other.content_ != null ? other.content_.Clone() : null;
    sender_ = other.sender_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Message Clone() {
    return new Message(this);
  }

  /// <summary>Field number for the "message_type" field.</summary>
  public const int MessageTypeFieldNumber = 1;
  private global::Type messageType_ = global::Type.Propose;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Type MessageType {
    get { return messageType_; }
    set {
      messageType_ = value;
    }
  }

  /// <summary>Field number for the "content" field.</summary>
  public const int ContentFieldNumber = 2;
  private global::Content content_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Content Content {
    get { return content_; }
    set {
      content_ = value;
    }
  }

  /// <summary>Field number for the "sender" field.</summary>
  public const int SenderFieldNumber = 3;
  private int sender_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Sender {
    get { return sender_; }
    set {
      sender_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Message);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Message other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MessageType != other.MessageType) return false;
    if (!object.Equals(Content, other.Content)) return false;
    if (Sender != other.Sender) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (MessageType != global::Type.Propose) hash ^= MessageType.GetHashCode();
    if (content_ != null) hash ^= Content.GetHashCode();
    if (Sender != 0) hash ^= Sender.GetHashCode();
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
    if (MessageType != global::Type.Propose) {
      output.WriteRawTag(8);
      output.WriteEnum((int) MessageType);
    }
    if (content_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(Content);
    }
    if (Sender != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Sender);
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
    if (MessageType != global::Type.Propose) {
      output.WriteRawTag(8);
      output.WriteEnum((int) MessageType);
    }
    if (content_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(Content);
    }
    if (Sender != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Sender);
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
    if (MessageType != global::Type.Propose) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageType);
    }
    if (content_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Content);
    }
    if (Sender != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Sender);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Message other) {
    if (other == null) {
      return;
    }
    if (other.MessageType != global::Type.Propose) {
      MessageType = other.MessageType;
    }
    if (other.content_ != null) {
      if (content_ == null) {
        Content = new global::Content();
      }
      Content.MergeFrom(other.Content);
    }
    if (other.Sender != 0) {
      Sender = other.Sender;
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
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          MessageType = (global::Type) input.ReadEnum();
          break;
        }
        case 18: {
          if (content_ == null) {
            Content = new global::Content();
          }
          input.ReadMessage(Content);
          break;
        }
        case 24: {
          Sender = input.ReadInt32();
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
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          MessageType = (global::Type) input.ReadEnum();
          break;
        }
        case 18: {
          if (content_ == null) {
            Content = new global::Content();
          }
          input.ReadMessage(Content);
          break;
        }
        case 24: {
          Sender = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
