#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.16.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
//using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
//using Thrift.Transport;
//using Thrift.Transport.Client;
//using Thrift.Transport.Server;
//using Thrift.Processor;


#nullable disable                // suppress C# 8.0 nullable contexts (we still support earlier versions)
#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Parquet.Thrift
{

  public partial class TimeUnit : TBase
  {
    private global::Parquet.Thrift.MilliSeconds _MILLIS;
    private global::Parquet.Thrift.MicroSeconds _MICROS;
    private global::Parquet.Thrift.NanoSeconds _NANOS;

    public global::Parquet.Thrift.MilliSeconds MILLIS
    {
      get
      {
        return _MILLIS;
      }
      set
      {
        __isset.MILLIS = true;
        this._MILLIS = value;
      }
    }

    public global::Parquet.Thrift.MicroSeconds MICROS
    {
      get
      {
        return _MICROS;
      }
      set
      {
        __isset.MICROS = true;
        this._MICROS = value;
      }
    }

    public global::Parquet.Thrift.NanoSeconds NANOS
    {
      get
      {
        return _NANOS;
      }
      set
      {
        __isset.NANOS = true;
        this._NANOS = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool MILLIS;
      public bool MICROS;
      public bool NANOS;
    }

    public TimeUnit()
    {
    }

    public TimeUnit DeepCopy()
    {
      var tmp50 = new TimeUnit();
      if((MILLIS != null) && __isset.MILLIS)
      {
        tmp50.MILLIS = (global::Parquet.Thrift.MilliSeconds)this.MILLIS.DeepCopy();
      }
      tmp50.__isset.MILLIS = this.__isset.MILLIS;
      if((MICROS != null) && __isset.MICROS)
      {
        tmp50.MICROS = (global::Parquet.Thrift.MicroSeconds)this.MICROS.DeepCopy();
      }
      tmp50.__isset.MICROS = this.__isset.MICROS;
      if((NANOS != null) && __isset.NANOS)
      {
        tmp50.NANOS = (global::Parquet.Thrift.NanoSeconds)this.NANOS.DeepCopy();
      }
      tmp50.__isset.NANOS = this.__isset.NANOS;
      return tmp50;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Struct)
              {
                MILLIS = new global::Parquet.Thrift.MilliSeconds();
                await MILLIS.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                MICROS = new global::Parquet.Thrift.MicroSeconds();
                await MICROS.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                NANOS = new global::Parquet.Thrift.NanoSeconds();
                await NANOS.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp51 = new TStruct("TimeUnit");
        await oprot.WriteStructBeginAsync(tmp51, cancellationToken);
        var tmp52 = new TField();
        if((MILLIS != null) && __isset.MILLIS)
        {
          tmp52.Name = "MILLIS";
          tmp52.Type = TType.Struct;
          tmp52.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp52, cancellationToken);
          await MILLIS.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((MICROS != null) && __isset.MICROS)
        {
          tmp52.Name = "MICROS";
          tmp52.Type = TType.Struct;
          tmp52.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp52, cancellationToken);
          await MICROS.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((NANOS != null) && __isset.NANOS)
        {
          tmp52.Name = "NANOS";
          tmp52.Type = TType.Struct;
          tmp52.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp52, cancellationToken);
          await NANOS.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is TimeUnit other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.MILLIS == other.__isset.MILLIS) && ((!__isset.MILLIS) || (global::System.Object.Equals(MILLIS, other.MILLIS))))
        && ((__isset.MICROS == other.__isset.MICROS) && ((!__isset.MICROS) || (global::System.Object.Equals(MICROS, other.MICROS))))
        && ((__isset.NANOS == other.__isset.NANOS) && ((!__isset.NANOS) || (global::System.Object.Equals(NANOS, other.NANOS))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((MILLIS != null) && __isset.MILLIS)
        {
          hashcode = (hashcode * 397) + MILLIS.GetHashCode();
        }
        if((MICROS != null) && __isset.MICROS)
        {
          hashcode = (hashcode * 397) + MICROS.GetHashCode();
        }
        if((NANOS != null) && __isset.NANOS)
        {
          hashcode = (hashcode * 397) + NANOS.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp53 = new StringBuilder("TimeUnit(");
      int tmp54 = 0;
      if((MILLIS != null) && __isset.MILLIS)
      {
        if(0 < tmp54++) { tmp53.Append(", "); }
        tmp53.Append("MILLIS: ");
        MILLIS.ToString(tmp53);
      }
      if((MICROS != null) && __isset.MICROS)
      {
        if(0 < tmp54++) { tmp53.Append(", "); }
        tmp53.Append("MICROS: ");
        MICROS.ToString(tmp53);
      }
      if((NANOS != null) && __isset.NANOS)
      {
        if(0 < tmp54++) { tmp53.Append(", "); }
        tmp53.Append("NANOS: ");
        NANOS.ToString(tmp53);
      }
      tmp53.Append(')');
      return tmp53.ToString();
    }
  }

}
