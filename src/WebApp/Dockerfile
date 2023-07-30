FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
EXPOSE 80
EXPOSE 433

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["*.csproj", "./WebApp/"]

COPY . /src/WebApp/   
WORKDIR "/src/WebApp/"
RUN dotnet restore "WebApp.csproj"
RUN dotnet build "WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApp.csproj" -c Release -o /app/publish   

FROM runtime AS final   
COPY --from=publish /app/publish .
CMD ["dotnet", "WebApp.dll"]
