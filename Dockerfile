FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY global.json Directory.Build.props .editorconfig VscDotnetCore8LibStudy.sln ./
COPY StringLibrary/StringLibrary.csproj StringLibrary/
COPY ShowCase/ShowCase.csproj ShowCase/
COPY StringLibraryTest/StringLibraryTest.csproj StringLibraryTest/
RUN dotnet restore
COPY . .
RUN dotnet build --no-restore --configuration Release

# docker build --target test .
FROM build AS test
RUN dotnet format --verify-no-changes --no-restore \
    && dotnet test --no-build --configuration Release

FROM build AS publish
RUN dotnet publish ShowCase --no-build --configuration Release --output /app

FROM mcr.microsoft.com/dotnet/runtime:10.0
WORKDIR /app
COPY --from=publish /app .
USER $APP_UID
ENTRYPOINT ["dotnet", "ShowCase.dll"]
