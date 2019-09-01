FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["EventBuyingAPI/EventBuyingAPI.csproj", "EventBuyingAPI/"]
RUN dotnet restore "EventBuyingAPI/EventBuyingAPI.csproj"
COPY . .
WORKDIR "/src/EventBuyingAPI"
RUN dotnet build "EventBuyingAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EventBuyingAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EventBuyingAPI.dll"]