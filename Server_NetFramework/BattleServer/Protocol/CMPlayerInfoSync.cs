// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: CMPlayerInfoSync.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Message {

  /// <summary>Holder for reflection information generated from CMPlayerInfoSync.proto</summary>
  public static partial class CMPlayerInfoSyncReflection {

    #region Descriptor
    /// <summary>File descriptor for CMPlayerInfoSync.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CMPlayerInfoSyncReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZDTVBsYXllckluZm9TeW5jLnByb3RvEgdtZXNzYWdlGgtJbmZvcy5wcm90",
            "byI1ChBDTVBsYXllckluZm9TeW5jEiEKBGluZm8YASABKAsyEy5tZXNzYWdl",
            "LlBsYXllckluZm9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Message.InfosReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Message.CMPlayerInfoSync), global::Message.CMPlayerInfoSync.Parser, new[]{ "Info" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 主服 -> 客户端 匹配成功响应
  /// </summary>
  public sealed partial class CMPlayerInfoSync : pb::IMessage<CMPlayerInfoSync> {
    private static readonly pb::MessageParser<CMPlayerInfoSync> _parser = new pb::MessageParser<CMPlayerInfoSync>(() => new CMPlayerInfoSync());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CMPlayerInfoSync> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Message.CMPlayerInfoSyncReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CMPlayerInfoSync() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CMPlayerInfoSync(CMPlayerInfoSync other) : this() {
      Info = other.info_ != null ? other.Info.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CMPlayerInfoSync Clone() {
      return new CMPlayerInfoSync(this);
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 1;
    private global::Message.PlayerInfo info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Message.PlayerInfo Info {
      get { return info_; }
      set {
        info_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CMPlayerInfoSync);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CMPlayerInfoSync other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Info, other.Info)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (info_ != null) hash ^= Info.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (info_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Info);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CMPlayerInfoSync other) {
      if (other == null) {
        return;
      }
      if (other.info_ != null) {
        if (info_ == null) {
          info_ = new global::Message.PlayerInfo();
        }
        Info.MergeFrom(other.Info);
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
            if (info_ == null) {
              info_ = new global::Message.PlayerInfo();
            }
            input.ReadMessage(info_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
