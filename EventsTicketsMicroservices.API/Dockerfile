FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
#EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["EventsTicketsMicroservices.API/EventsTicketsMicroservices.API.csproj", "EventsTicketsMicroservices.API/"]
RUN dotnet restore "EventsTicketsMicroservices.API/EventsTicketsMicroservices.API.csproj"
COPY . .
WORKDIR "/src/EventsTicketsMicroservices.API"
RUN dotnet build "EventsTicketsMicroservices.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EventsTicketsMicroservices.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EventsTicketsMicroservices.API.dll"]
