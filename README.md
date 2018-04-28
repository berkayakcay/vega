# vega

## VS Code Extentions 
* ASP.NET Helpers 
* C#
* C# Extentions
* docker
* mssql
* REST Client




## MSSQL / Linux
docker pull microsoft/mssql-server-linux:2017-latest

  
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=<YourStrong!Passw0rd>" -p 1433:1433 -d microsoft/mssql-server-linux:2017-latest
   


## dotnet watch 
<ItemGroup>
    <DotNetCliToolReference Include="Microsoft.DotNet.Watcher.Tools" Version="2.0.0" />
</ItemGroup>


dotnet restore


