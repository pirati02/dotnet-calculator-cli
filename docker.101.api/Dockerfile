FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["docker.101.api/docker.101.api.csproj", "docker.101.api/"]
RUN dotnet restore "docker.101.api/docker.101.api.csproj"
COPY . .
WORKDIR "/src/docker.101.api"
RUN dotnet build "docker.101.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "docker.101.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "docker.101.api.dll"]
