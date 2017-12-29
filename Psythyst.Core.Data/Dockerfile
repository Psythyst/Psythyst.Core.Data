FROM microsoft/dotnet:sdk AS Build
WORKDIR /Psythyst.Core.Data
COPY ./ ./
RUN dotnet restore
RUN dotnet publish -c Release -o ./Publish