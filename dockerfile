FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as builder

WORKDIR /app
COPY . /app

RUN dotnet restore
RUN dotnet publish -o ./myTestService


FROM mcr.microsoft.com/dotnet/core/aspnet:latest as run


WORKDIR /myTestService
COPY --from=builder /app/myTestService ./
ENTRYPOINT ["dotnet", "MyTestService.dll"]