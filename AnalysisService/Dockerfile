FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["AnalysisService.Entities/AnalysisService.Entities.csproj", "AnalysisService.Entities/"]
COPY ["AnalysisService.Infrastructure/AnalysisService.Infrastructure.csproj", "AnalysisService.Infrastructure/"]
COPY ["AnalysisService.UseCases/AnalysisService.UseCases.csproj", "AnalysisService.UseCases/"]
COPY ["AnalysisService.Presentation/AnalysisService.Presentation.csproj", "AnalysisService.Presentation/"]
COPY ["AnalysisService.Host/AnalysisService.Host.csproj", "AnalysisService.Host/"]

RUN dotnet restore "AnalysisService.Host/AnalysisService.Host.csproj"

COPY . .
WORKDIR "/src/AnalysisService.Host"

RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /out .

ENTRYPOINT ["dotnet", "AnalysisService.Host.dll"]