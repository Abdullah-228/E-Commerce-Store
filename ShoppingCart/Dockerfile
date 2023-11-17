# Use the official .NET 7 runtime image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base

# Use the official .NET 7 SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Copy your application code into the container
COPY . /app

# Set the working directory to /app
WORKDIR /app

# Build the application
RUN dotnet publish -c Release -o out

# Create the final runtime image
FROM base AS final

# Copy the published output from the build stage
COPY --from=build /app/out .

# Set the environment variable for ASP.NET Core
ENV ASPNETCORE_ENVIRONMENT=Production

# Expose the port that your application will listen on
EXPOSE 5000

# Set the working directory to the application directory
WORKDIR /app

# Specify the entry point for your application
ENTRYPOINT ["dotnet", "SportsStore.dll", "--urls=http://0.0.0.0:3000"]

# Create a non-root user
RUN useradd -ms /bin/bash Abbdullah

# Set the user as the default user for subsequent commands
USER Abdullah