#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ProjectPowerWebApi/ProjectPowerWebApi.csproj", "ProjectPowerWebApi/"]
COPY ["ProjectPowerData/ProjectPowerData.csproj", "ProjectPowerData/"]
COPY ["ProjectPower/ProjectPower.csproj", "ProjectPower/"]
RUN dotnet restore "ProjectPowerWebApi/ProjectPowerWebApi.csproj"
COPY . .
WORKDIR "/src/ProjectPowerWebApi"
RUN dotnet build "ProjectPowerWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectPowerWebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectPowerWebApi.dll"]