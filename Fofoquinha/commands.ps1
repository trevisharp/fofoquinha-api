dotnet new web
dotnet new gitignore

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

$env:SQL_CONNECTION = "Data Source=localhost;Initial Catalog=Fofoquinha;Trust Server Certificate=true;Integrated Security=true"
$env:JWT_SECRET = "adbfoahfodsahoifdsjoifjdssoidjfdsfojsfa"

dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialModel
dotnet ef database update

dotnet add package xunit
dotnet add package xunit.runner.visualstudio
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package Moq

dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer

dotnet add package Swashbuckle.AspNetCore
