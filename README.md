# NetCoreOracleDemo
NetCoreOracleDemo
## 基本信息
1. 安装组件包
  1. 安装Oracle.EntityFrameworkCore2.19.70
1.2 安装Oracle.ManagedDataAccess.Core2.19.70
1.3 安装Microsoft.EntityFrameworkCore2.2.6
1.4 安装Microsoft.EntityFrameworkCore.Relational2.2.6
1.5 安装Microsoft.EntityFrameworkCore.Tools2.2.6
2. DbFirst映射数据实体对象
Scaffold-DbContext "User Id=CARGO;Password=CARGO;Data Source=192.168.0.43:1521/ORCL;" Oracle.EntityFrameworkCore -Context "CARGOContext"  -OutputDir Models -Force -UseDatabaseNames
3. 修改兼容性设置
optionsBuilder.UseOracle("User Id=CARGO;Password=CARGO;Data Source=192.168.0.43:1521/ORCL;", options =>
{
	// 这里只能设置11或12
	options.UseOracleSQLCompatibility("11");
});
4. 获取Sequence
使用Oracle.ManagedDataAccess.Core+T4模版

gRPC 是一种与语言无关的高性能远程过程调用 (RPC) 框架。
gRPC 的主要优点是：
现代高性能轻量级 RPC 框架。
协定优先 API 开发，默认使用协议缓冲区，允许与语言无关的实现。
可用于多种语言的工具，以生成强类型服务器和客户端。
支持客户端、服务器和双向流式处理调用。
使用 Protobuf 二进制序列化减少对网络的使用。
这些优点使 gRPC 适用于：
效率至关重要的轻量级微服务。
需要多种语言用于开发的 Polyglot 系统。
需要处理流式处理请求或响应的点对点实时服务。

Azure 应用服务或 IIS 当前不支持 ASP.NET Core gRPC。 Http.Sys 的 HTTP/2 实现不支持 gRPC 依赖的 HTTP 响应尾随标头。

安装工具
dotnet tool install -g dotnet-grpc

先定位到Service
dotnet grpc add-file ../../protos/*.proto -S Service

定位到Client

dotnet grpc add-file ../../protos/*.proto -S Client