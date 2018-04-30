FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ActiveAzureAcademy.Lab.Multiregion.sln ./
COPY src/ActiveAzureAcademy.Lab.Multiregion/ActiveAzureAcademy.Lab.Multiregion.csproj src/ActiveAzureAcademy.Lab.Multiregion/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/src/ActiveAzureAcademy.Lab.Multiregion
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ActiveAzureAcademy.Lab.Multiregion.dll"]
