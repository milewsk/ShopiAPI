# .NET 9 image
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release

# Select folder with codebase
WORKDIR /src

# Copy projects
COPY ["src/Shopi.Application/Shopi.Application.csproj", "src/Shopi.Application/Shopi.Application/"]
COPY ["src/Shopi.Infrastructure/Shopi.Infrastructure.csproj", "src/Shopi.Infrastructure/Shopi.Infrastructure/"]
COPY ["src/Shopi.Domain/Shopi.Domain.csproj", "src/Shopi.Domain/Shopi.Domain/"]
COPY ["src/Shopi.Presentation/Shopi.Presentation.csproj", "src/Shopi.Presentation/Shopi.Presentation/"]
COPY ["src/Shopi.API/Shopi.API.csproj", "src/Shopi.AP/Shopi.ShopiAPI/"]

RUN dotnet restore "src/Shopi.API/Shopi.API.csproj"
COPY . .
WORKDIR "/src/src/Shopi.API"
RUN dotnet build "Shopi.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Shopi.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Use ASP.NET to create server
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 8080
EXPOSE 8081

# Start application
ENTRYPOINT ["dotnet", "ShopiAPI.dll"]
