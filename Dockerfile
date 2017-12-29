FROM microsoft/dotnet:sdk AS Build
WORKDIR /Psythyst.Core.Data
COPY ./Psythyst.Core.Data ./
RUN dotnet restore
RUN dotnet publish -c Release -o ./Publish