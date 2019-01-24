// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: test.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace v2ray.Core.App.Stats.Command {
  public static partial class StatsService
  {
    static readonly string __ServiceName = "v2ray.core.app.stats.command.StatsService";

    static readonly grpc::Marshaller<global::v2ray.Core.App.Stats.Command.GetStatsRequest> __Marshaller_v2ray_core_app_stats_command_GetStatsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::v2ray.Core.App.Stats.Command.GetStatsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::v2ray.Core.App.Stats.Command.GetStatsResponse> __Marshaller_v2ray_core_app_stats_command_GetStatsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::v2ray.Core.App.Stats.Command.GetStatsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::v2ray.Core.App.Stats.Command.QueryStatsRequest> __Marshaller_v2ray_core_app_stats_command_QueryStatsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::v2ray.Core.App.Stats.Command.QueryStatsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::v2ray.Core.App.Stats.Command.QueryStatsResponse> __Marshaller_v2ray_core_app_stats_command_QueryStatsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::v2ray.Core.App.Stats.Command.QueryStatsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::v2ray.Core.App.Stats.Command.GetStatsRequest, global::v2ray.Core.App.Stats.Command.GetStatsResponse> __Method_GetStats = new grpc::Method<global::v2ray.Core.App.Stats.Command.GetStatsRequest, global::v2ray.Core.App.Stats.Command.GetStatsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStats",
        __Marshaller_v2ray_core_app_stats_command_GetStatsRequest,
        __Marshaller_v2ray_core_app_stats_command_GetStatsResponse);

    static readonly grpc::Method<global::v2ray.Core.App.Stats.Command.QueryStatsRequest, global::v2ray.Core.App.Stats.Command.QueryStatsResponse> __Method_QueryStats = new grpc::Method<global::v2ray.Core.App.Stats.Command.QueryStatsRequest, global::v2ray.Core.App.Stats.Command.QueryStatsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueryStats",
        __Marshaller_v2ray_core_app_stats_command_QueryStatsRequest,
        __Marshaller_v2ray_core_app_stats_command_QueryStatsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::v2ray.Core.App.Stats.Command.TestReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of StatsService</summary>
    public abstract partial class StatsServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::v2ray.Core.App.Stats.Command.GetStatsResponse> GetStats(global::v2ray.Core.App.Stats.Command.GetStatsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::v2ray.Core.App.Stats.Command.QueryStatsResponse> QueryStats(global::v2ray.Core.App.Stats.Command.QueryStatsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for StatsService</summary>
    public partial class StatsServiceClient : grpc::ClientBase<StatsServiceClient>
    {
      /// <summary>Creates a new client for StatsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public StatsServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for StatsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public StatsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected StatsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected StatsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::v2ray.Core.App.Stats.Command.GetStatsResponse GetStats(global::v2ray.Core.App.Stats.Command.GetStatsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStats(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::v2ray.Core.App.Stats.Command.GetStatsResponse GetStats(global::v2ray.Core.App.Stats.Command.GetStatsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetStats, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::v2ray.Core.App.Stats.Command.GetStatsResponse> GetStatsAsync(global::v2ray.Core.App.Stats.Command.GetStatsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetStatsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::v2ray.Core.App.Stats.Command.GetStatsResponse> GetStatsAsync(global::v2ray.Core.App.Stats.Command.GetStatsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetStats, null, options, request);
      }
      public virtual global::v2ray.Core.App.Stats.Command.QueryStatsResponse QueryStats(global::v2ray.Core.App.Stats.Command.QueryStatsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryStats(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::v2ray.Core.App.Stats.Command.QueryStatsResponse QueryStats(global::v2ray.Core.App.Stats.Command.QueryStatsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_QueryStats, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::v2ray.Core.App.Stats.Command.QueryStatsResponse> QueryStatsAsync(global::v2ray.Core.App.Stats.Command.QueryStatsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryStatsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::v2ray.Core.App.Stats.Command.QueryStatsResponse> QueryStatsAsync(global::v2ray.Core.App.Stats.Command.QueryStatsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_QueryStats, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override StatsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new StatsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StatsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetStats, serviceImpl.GetStats)
          .AddMethod(__Method_QueryStats, serviceImpl.QueryStats).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StatsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetStats, serviceImpl.GetStats);
      serviceBinder.AddMethod(__Method_QueryStats, serviceImpl.QueryStats);
    }

  }
}
#endregion
