﻿Scaffold-DbContext "server=localhost;port=3306;user=xxy;password=xxy@678.com;database=new_schema" MySql.Data.EntityFrameworkCore -OutputDir new_schema -f
Scaffold-DbContext "server=localhost;port=3306;user=xxy;password=xxy@678.com;database=new_schema;TreatTinyAsBoolean=true" MySql.Data.EntityFrameworkCore -OutputDir Models -f

Scaffold-DbContext "server=localhost;port=3306;user=xxy;password=xxy@678.com;database=newship2;TreatTinyAsBoolean=true" MySql.Data.EntityFrameworkCore -OutputDir Models -f