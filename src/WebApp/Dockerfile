FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["./WebApp/WebApp.csproj", "./WebApp/"]
COPY ["./DynamicFilter.Core/*.csproj", "./DynamicFilter.Core/"]

COPY . . 
RUN dotnet restore "./WebApp/WebApp.csproj"
WORKDIR "WebApp"
RUN dotnet build "WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApp.csproj" -c Release -o /app/publish   

FROM runtime AS final   
EXPOSE 5280
COPY --from=publish /app/publish .
CMD ["dotnet", "WebApp.dll"]
