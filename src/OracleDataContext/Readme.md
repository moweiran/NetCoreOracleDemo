﻿## 1. 安装组件包
安装Oracle.EntityFrameworkCore2.19.70
安装Oracle.ManagedDataAccess.Core2.19.70
安装Microsoft.EntityFrameworkCore2.2.6
安装Microsoft.EntityFrameworkCore.Relational2.2.6
安装Microsoft.EntityFrameworkCore.Tools2.2.6
## 2. DbFirst映射数据实体对象
Scaffold-DbContext "User Id=CARGO;Password=CARGO;Data Source=192.168.0.43:1521/ORCL;" Oracle.EntityFrameworkCore -Context "CARGOContext"  -OutputDir Models -Force -UseDatabaseNames
## 3. 修改兼容性设置
optionsBuilder.UseOracle("User Id=CARGO;Password=CARGO;Data Source=192.168.0.43:1521/ORCL;", options =>
{
	// 这里只能设置11或12
	options.UseOracleSQLCompatibility("11");
});
## 4. 获取Sequence
使用Oracle.ManagedDataAccess.Core+T4模版
注意应用
```
<#@ assembly Name="C:\Program Files\dotnet\sdk\3.1.401\Microsoft\Microsoft.NET.Build.Extensions\net461\lib\netstandard.dll" #>
<#@ assembly name="C:\Users\Administrator\.nuget\packages\oracle.manageddataaccess.core\2.19.80\lib\netstandard2.0\Oracle.ManagedDataAccess.dll" #>
```

## 5. Oracle EntityFramework Core
当使用FromSqlRaw方法，无法使用Single,SingleOrDefault,First,FirstOrDerault等方法
## 6. Oracle 分页
Skip,Take需要设置UseOracleSQLCompatibility