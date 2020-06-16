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
