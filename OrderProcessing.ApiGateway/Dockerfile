#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OrderProcessing.ApiGateway/OrderProcessing.ApiGateway.csproj", "OrderProcessing.ApiGateway/"]
RUN dotnet restore "OrderProcessing.ApiGateway/OrderProcessing.ApiGateway.csproj"
COPY . .
WORKDIR "/src/OrderProcessing.ApiGateway"
RUN dotnet build "OrderProcessing.ApiGateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OrderProcessing.ApiGateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrderProcessing.ApiGateway.dll"]