// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace NamespaceA.NamespaceB
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TableInNestedNS : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static TableInNestedNS GetRootAsTableInNestedNS(ByteBuffer _bb) { return GetRootAsTableInNestedNS(_bb, new TableInNestedNS()); }
  public static TableInNestedNS GetRootAsTableInNestedNS(ByteBuffer _bb, TableInNestedNS obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TableInNestedNS __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Foo { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool MutateFoo(int foo) { int o = __p.__offset(4); if (o != 0) { __p.bb.PutInt(o + __p.bb_pos, foo); return true; } else { return false; } }

  public static Offset<NamespaceA.NamespaceB.TableInNestedNS> CreateTableInNestedNS(FlatBufferBuilder builder,
      int foo = 0) {
    builder.StartTable(1);
    TableInNestedNS.AddFoo(builder, foo);
    return TableInNestedNS.EndTableInNestedNS(builder);
  }

  public static void StartTableInNestedNS(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddFoo(FlatBufferBuilder builder, int foo) { builder.AddInt(0, foo, 0); }
  public static Offset<NamespaceA.NamespaceB.TableInNestedNS> EndTableInNestedNS(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<NamespaceA.NamespaceB.TableInNestedNS>(o);
  }
  public TableInNestedNST UnPack() {
    var _o = new TableInNestedNST();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TableInNestedNST _o) {
    _o.Foo = this.Foo;
  }
  public static Offset<NamespaceA.NamespaceB.TableInNestedNS> Pack(FlatBufferBuilder builder, TableInNestedNST _o) {
    if (_o == null) return default(Offset<NamespaceA.NamespaceB.TableInNestedNS>);
    return CreateTableInNestedNS(
      builder,
      _o.Foo);
  }
};

public class TableInNestedNST
{
  [Newtonsoft.Json.JsonProperty("foo")]
  public int Foo { get; set; }

  public TableInNestedNST() {
    this.Foo = 0;
  }
}


}