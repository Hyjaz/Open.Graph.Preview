FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:44371

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /Open.Graph.Preview
COPY ./Open.Graph.Preview.csproj /Open.Graph.Preview/
RUN dotnet restore /Open.Graph.Preview/Open.Graph.Preview.csproj
COPY . /Open.Graph.Preview/
RUN dotnet build Open.Graph.Preview.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Open.Graph.Preview.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Open.Graph.Preview.dll"]
