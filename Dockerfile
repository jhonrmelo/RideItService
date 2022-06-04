FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /app
COPY . .
WORKDIR /app/tcc-service.Api
RUN dotnet restore

RUN dotnet publish -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS final
WORKDIR /app
EXPOSE 80 443 5001 5000 44308
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "tcc-service.Api.dll", "--environment=Development"]


##################### Instruções de uso #####################
# Na pasta raiz do projeto execute os seguintes comandos:

# docker image build -t tcc-service .
# docker container run -p 80:80 --name tcc-service tcc-service

# Acesse o swagger pelo navegador em: http://localhost/swagger/index.html