# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY CalculadoraRedes.sln ./
COPY Client/ ./Client/
COPY Shared/ ./Shared/
COPY Server/ ./Server/

WORKDIR /src/Server
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Server.dll"]
