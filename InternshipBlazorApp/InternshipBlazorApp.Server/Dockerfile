FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["InternshipBlazorApp/InternshipBlazorApp.Server/InternshipBlazorApp.Server.csproj", "InternshipBlazorApp/InternshipBlazorApp.Server/"]
RUN dotnet restore "InternshipBlazorApp/InternshipBlazorApp.Server/InternshipBlazorApp.Server.csproj"
COPY . .
WORKDIR "/src/InternshipBlazorApp/InternshipBlazorApp.Server"
RUN dotnet build "./InternshipBlazorApp.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./InternshipBlazorApp.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InternshipBlazorApp.Server.dll"]
