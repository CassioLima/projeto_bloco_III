FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["services/EventBuying.API/EventBuying.API.csproj", "services/EventBuying.API/"]
RUN dotnet restore "services/EventBuying.API/EventBuying.API.csproj"
COPY . .
WORKDIR "/src/services/EventBuying.API"
RUN dotnet build "EventBuying.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EventBuying.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EventBuying.API.dll"]
