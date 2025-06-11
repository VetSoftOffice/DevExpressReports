
FROM mcr.microsoft.com/dotnet/aspnet:8.0-bookworm-slim AS base
# USER $APP_UID # Disabled for sudo privilege
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Install the latest version of font libraries (from devexpress docs)
RUN apt update &&\
    apt install -y libc6 libicu-dev libfontconfig1

# (Optional step) Install the ttf-mscorefonts-installer package (from devexpress docs)
# to use Microsoft TrueType core fonts in the application
RUN echo "deb http://ftp.debian.org/debian/ bullseye contrib" >> /etc/apt/sources.list
RUN apt update
RUN apt install -y ttf-mscorefonts-installer 


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0-bookworm-slim AS publish
ARG BUILD_CONFIGURATION=Release
ARG DEVEXPRESS_NUGET_API_KEY="d741vNWM8MRmply6ZweCO2ihJb99GU3ootPmt5s5vn66jbMcYK"

WORKDIR /src
COPY ["./DevExpressReports.csproj", "./"]
RUN dotnet nuget add source https://nuget.devexpress.com/${DEVEXPRESS_NUGET_API_KEY}/api/v3/index.json
RUN dotnet restore "./DevExpressReports.csproj"
COPY . .


RUN dotnet publish "./DevExpressReports.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false


FROM mcr.microsoft.com/dotnet/sdk:9.0-bookworm-slim AS cert 
WORKDIR /cert
RUN dotnet dev-certs https -ep ./aspnetapp.pfx -p VeryStrongPassword
RUN dotnet dev-certs https --trust

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=cert /cert/aspnetapp.pfx /app/aspnetapp.pfx

# Add environment variables
ENV ASPNETCORE_HTTPS_PORTS=8081
ENV ASPNETCORE_HTTP_PORTS=8080
ENV ASPNETCORE_Kestrel__Certificates__Default__Password="VeryStrongPassword"
ENV ASPNETCORE_Kestrel__Certificates__Default__Path="/app/aspnetapp.pfx"

ENTRYPOINT ["dotnet", "DevExpressReports.dll"]
