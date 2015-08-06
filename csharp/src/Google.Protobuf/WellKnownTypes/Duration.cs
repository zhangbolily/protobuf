// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/protobuf/duration.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Duration {

      #region Descriptor
      public static pbr::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbr::FileDescriptor descriptor;

      static Duration() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "Ch5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8SD2dvb2dsZS5wcm90", 
              "b2J1ZiIqCghEdXJhdGlvbhIPCgdzZWNvbmRzGAEgASgDEg0KBW5hbm9zGAIg", 
              "ASgFQlAKE2NvbS5nb29nbGUucHJvdG9idWZCDUR1cmF0aW9uUHJvdG9QAaAB", 
              "AaICA0dQQqoCHkdvb2dsZS5Qcm90b2J1Zi5XZWxsS25vd25UeXBlc2IGcHJv", 
              "dG8z"));
        descriptor = pbr::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbr::FileDescriptor[] { },
            new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
              new pbr::GeneratedCodeInfo(typeof(global::Google.Protobuf.WellKnownTypes.Duration), new[]{ "Seconds", "Nanos" }, null, null, null)
            }));
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Duration : pb::IMessage<Duration> {
    private static readonly pb::MessageParser<Duration> _parser = new pb::MessageParser<Duration>(() => new Duration());
    public static pb::MessageParser<Duration> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.WellKnownTypes.Proto.Duration.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Duration() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Duration(Duration other) : this() {
      seconds_ = other.seconds_;
      nanos_ = other.nanos_;
    }

    public Duration Clone() {
      return new Duration(this);
    }

    public const int SecondsFieldNumber = 1;
    private long seconds_;
    public long Seconds {
      get { return seconds_; }
      set {
        seconds_ = value;
      }
    }

    public const int NanosFieldNumber = 2;
    private int nanos_;
    public int Nanos {
      get { return nanos_; }
      set {
        nanos_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Duration);
    }

    public bool Equals(Duration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Seconds != other.Seconds) return false;
      if (Nanos != other.Nanos) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Seconds != 0L) hash ^= Seconds.GetHashCode();
      if (Nanos != 0) hash ^= Nanos.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Seconds != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Seconds);
      }
      if (Nanos != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Nanos);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Seconds != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Seconds);
      }
      if (Nanos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Nanos);
      }
      return size;
    }

    public void MergeFrom(Duration other) {
      if (other == null) {
        return;
      }
      if (other.Seconds != 0L) {
        Seconds = other.Seconds;
      }
      if (other.Nanos != 0) {
        Nanos = other.Nanos;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              return;
            }
            input.ConsumeLastField();
            break;
          case 8: {
            Seconds = input.ReadInt64();
            break;
          }
          case 16: {
            Nanos = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
