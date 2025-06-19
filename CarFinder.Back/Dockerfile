# --- Build Stage ---
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project files for API, Application, Infrastructure, and Domain layers
COPY ["CarFinder/CarFinder.csproj", "CarFinder/"]
COPY ["CarFinder.Application/CarFinder.Application.csproj", "CarFinder.Application/"]
COPY ["CarFinder.Infrastructure/CarFinder.Infrastructure.csproj", "CarFinder.Infrastructure/"]
COPY ["CarFinder.Domain/CarFinder.Domain.csproj", "CarFinder.Domain/"]

# Restore NuGet packages
RUN dotnet restore "CarFinder/CarFinder.csproj"

# Copy the rest of the source code
COPY . .

# Build and publish the app
WORKDIR "/src/CarFinder"
RUN dotnet publish "CarFinder.csproj" -c Release -o /app/publish

# --- Runtime Stage ---
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Expose the port your app listens on
EXPOSE 5000

# Set environment variables if needed
ENV ASPNETCORE_URLS=http://+:5000

ENTRYPOINT ["dotnet", "CarFinder.dll"]
