// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ProtoNum.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Message {

  /// <summary>Holder for reflection information generated from ProtoNum.proto</summary>
  public static partial class ProtoNumReflection {

    #region Descriptor
    /// <summary>File descriptor for ProtoNum.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoNumReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5Qcm90b051bS5wcm90bxIHbWVzc2FnZSq/AQoIUHJvdG9OdW0SCwoHVW5r",
            "bm93bhAAEhMKDkNNTG9naW5SZXF1ZXN0EOkHEhEKDENNTG9naW5SZXBseRDq",
            "BxIXChJDTVN0YXJ0R2FtZVJlcXVlc3QQ6wcSFQoQQ01TdGFydEdhbWVSZXBs",
            "eRDsBxITCg5DQkxvZ2luUmVxdWVzdBDRDxIRCgxDQkxvZ2luUmVwbHkQ0g8S",
            "EwoOQk1Mb2dpblJlcXVlc3QQuRcSEQoMQk1Mb2dpblJlcGx5ELoXYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Message.ProtoNumTest), }, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// 消息头枚举，不用于消息收发
  /// !!! 名字必须对应到消息类型
  /// </summary>
  public enum ProtoNumTest {
    [pbr::OriginalName("Unknown")] Unknown = 0,
    [pbr::OriginalName("CMLoginRequest")] CmloginRequest = 1001,
    [pbr::OriginalName("CMLoginReply")] CmloginReply = 1002,
    [pbr::OriginalName("CMStartGameRequest")] CmstartGameRequest = 1003,
    [pbr::OriginalName("CMStartGameReply")] CmstartGameReply = 1004,
    [pbr::OriginalName("CBLoginRequest")] CbloginRequest = 2001,
    [pbr::OriginalName("CBLoginReply")] CbloginReply = 2002,
    [pbr::OriginalName("BMLoginRequest")] BmloginRequest = 3001,
    [pbr::OriginalName("BMLoginReply")] BmloginReply = 3002,
  }

  #endregion

}

#endregion Designer generated code
