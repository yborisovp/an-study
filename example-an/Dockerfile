FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["example-an/example-an.csproj", "example-an/"]
RUN dotnet restore "example-an/example-an.csproj"
COPY . .
WORKDIR "/src/example-an"
RUN dotnet build "example-an.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "example-an.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "example-an.dll"]
