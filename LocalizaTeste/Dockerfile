
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
RUN ls
# Copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore
#RUN dotnet restore "Localiza.Model.csproj"

RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
RUN ls
COPY --from=build-env /app/out .
RUN ls
ENTRYPOINT ["dotnet", "Localiza.API.dll"]