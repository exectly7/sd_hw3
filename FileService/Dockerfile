FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["FileService.Entities/FileService.Entities.csproj", "FileService.Entities/"]
COPY ["FileService.Infrastructure/FileService.Infrastructure.csproj", "FileService.Infrastructure/"]
COPY ["FileService.UseCases/FileService.UseCases.csproj", "FileService.UseCases/"]
COPY ["FileService.Presentation/FileService.Presentation.csproj", "FileService.Presentation/"]
COPY ["FileService.Host/FileService.Host.csproj", "FileService.Host/"]

RUN dotnet restore "FileService.Host/FileService.Host.csproj"

COPY . .
WORKDIR "/src/FileService.Host"
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /out .

ENTRYPOINT ["dotnet", "FileService.Host.dll"]