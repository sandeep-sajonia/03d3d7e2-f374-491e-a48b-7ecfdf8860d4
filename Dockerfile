FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY src /src
RUN dotnet publish src/LIS.App/LIS.App.csproj -c Release -o /app/release

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/release .

ENTRYPOINT ["dotnet", "LIS.App.dll"]
