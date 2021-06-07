 
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY . .
ENTRYPOINT ["dotnet", "run", "-e add 3 5"]