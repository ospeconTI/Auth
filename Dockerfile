FROM  mcr.microsoft.com/dotnet/sdk:6.0.302 AS build-env
WORKDIR /Auth
RUN mkdir EventBus
RUN mkdir Services
WORKDIR /Auth/EventBus
RUN mkdir EventBus
RUN mkdir EventBusRabbitMQ
RUN mkdir IntegrationEventLogEF
WORKDIR /Auth/Services/AuthService/src
RUN mkdir Application
RUN mkdir Domain
RUN mkdir Infrastructure


# Copy csproj and restore as distinct layers
COPY Services/AuthService/src/Application/*.csproj ./Application
COPY Services/AuthService/src/Domain/*.csproj ./Domain
COPY Services/AuthService/src/Infrastructure/*.csproj ./Infrastructure

WORKDIR /Auth/EventBus
COPY EventBus/EventBus/*.csproj ./EventBus
COPY EventBus/IntegrationEventLogEF/*.csproj ./IntegrationEventLogEF
COPY EventBus/EventBusRabbitMQ/*.csproj ./EventBusRabbitMQ


WORKDIR /Auth/Services/AuthService/src/Application
RUN dotnet restore

# Copy everything else and build
WORKDIR /Auth
COPY . ./
WORKDIR /Auth/Services/AuthService/src/Application
RUN dotnet publish -c Release -o out

# Build runtime image
FROM  mcr.microsoft.com/dotnet/sdk:6.0.302 
WORKDIR /app
COPY --from=build-env /Auth/Services/AuthService/src/Application/out .
ENTRYPOINT ["dotnet", "Application.dll"]