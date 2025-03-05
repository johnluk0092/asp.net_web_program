# Lesson 2

## Installed package (NuGet)

Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

## In Terminal (Tools/NutGet Package Manager /Package Manager Console)

dotnet tool install --global dotnet-ef

cd ./WebsiteBanHang

dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet run