// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: humanoid.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace VrmProtobuf {

  /// <summary>Holder for reflection information generated from humanoid.proto</summary>
  public static partial class HumanoidReflection {

    #region Descriptor
    /// <summary>File descriptor for humanoid.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HumanoidReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5odW1hbm9pZC5wcm90bxILVnJtUHJvdG9idWYaHmdvb2dsZS9wcm90b2J1",
            "Zi93cmFwcGVycy5wcm90byK0AQoISHVtYW5vaWQSOQoKaHVtYW5Cb25lcxgB",
            "IAMoCzIlLlZybVByb3RvYnVmLkh1bWFub2lkLkh1bWFuQm9uZXNFbnRyeRoZ",
            "CglodW1hbkJvbmUSDAoEbm9kZRgBIAEoBRpSCg9IdW1hbkJvbmVzRW50cnkS",
            "CwoDa2V5GAEgASgJEi4KBXZhbHVlGAIgASgLMh8uVnJtUHJvdG9idWYuSHVt",
            "YW5vaWQuaHVtYW5Cb25lOgI4AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::VrmProtobuf.Humanoid), global::VrmProtobuf.Humanoid.Parser, new[]{ "HumanBones" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::VrmProtobuf.Humanoid.Types.humanBone), global::VrmProtobuf.Humanoid.Types.humanBone.Parser, new[]{ "Node" }, null, null, null, null),
            null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Correspondence between nodes and human bones
  /// </summary>
  public sealed partial class Humanoid : pb::IMessage<Humanoid> {
    private static readonly pb::MessageParser<Humanoid> _parser = new pb::MessageParser<Humanoid>(() => new Humanoid());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Humanoid> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::VrmProtobuf.HumanoidReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Humanoid() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Humanoid(Humanoid other) : this() {
      humanBones_ = other.humanBones_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Humanoid Clone() {
      return new Humanoid(this);
    }

    /// <summary>Field number for the "humanBones" field.</summary>
    public const int HumanBonesFieldNumber = 1;
    private static readonly pbc::MapField<string, global::VrmProtobuf.Humanoid.Types.humanBone>.Codec _map_humanBones_codec
        = new pbc::MapField<string, global::VrmProtobuf.Humanoid.Types.humanBone>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::VrmProtobuf.Humanoid.Types.humanBone.Parser), 10);
    private readonly pbc::MapField<string, global::VrmProtobuf.Humanoid.Types.humanBone> humanBones_ = new pbc::MapField<string, global::VrmProtobuf.Humanoid.Types.humanBone>();
    /// <summary>
    /// Human bone, node map.
    /// Human bone is enum.
    /// Must include required bones.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::VrmProtobuf.Humanoid.Types.humanBone> HumanBones {
      get { return humanBones_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Humanoid);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Humanoid other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!HumanBones.Equals(other.HumanBones)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= HumanBones.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      humanBones_.WriteTo(output, _map_humanBones_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += humanBones_.CalculateSize(_map_humanBones_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Humanoid other) {
      if (other == null) {
        return;
      }
      humanBones_.Add(other.humanBones_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            humanBones_.AddEntriesFrom(input, _map_humanBones_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Humanoid message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// A human bone.
      /// "required": [ "node" ].
      /// </summary>
      public sealed partial class humanBone : pb::IMessage<humanBone> {
        private static readonly pb::MessageParser<humanBone> _parser = new pb::MessageParser<humanBone>(() => new humanBone());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<humanBone> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::VrmProtobuf.Humanoid.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public humanBone() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public humanBone(humanBone other) : this() {
          node_ = other.node_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public humanBone Clone() {
          return new humanBone(this);
        }

        /// <summary>Field number for the "node" field.</summary>
        public const int NodeFieldNumber = 1;
        private int node_;
        /// <summary>
        /// Specify a node.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Node {
          get { return node_; }
          set {
            node_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as humanBone);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(humanBone other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Node != other.Node) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Node != 0) hash ^= Node.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Node != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(Node);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Node != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Node);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(humanBone other) {
          if (other == null) {
            return;
          }
          if (other.Node != 0) {
            Node = other.Node;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                Node = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code