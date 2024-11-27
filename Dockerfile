# Usa la imagen oficial de .NET SDK como base para la construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar los archivos de proyecto y restaurar las dependencias
COPY *.csproj .
RUN dotnet restore

# Copiar el resto de los archivos de la aplicación
COPY . .

# Publicar la aplicación en el directorio /app/out
RUN dotnet publish -c Release -o /app/out

# Usa una imagen ligera de .NET para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base

# Establece el directorio de trabajo para la ejecución de la API
WORKDIR /app

# Copia el archivo .env
COPY .env .env

ENV ASPNETCORE_ENVIRONMENT=Development


ENV JWT_KEY=jhQYUT3287UIRM3-2Q5R32125JÑOEWR-SDGS.443643SDAADFASFA23OP5-ADF-_AVRRWW
ENV JWT_ISSUER = http://localhost:8080
ENV JWT_EXPIRES_IN = 30

# Copia los archivos de la fase de construcción
COPY --from=build /app/out .

# Expone el puerto 80 para que la API sea accesible desde fuera del contenedor
EXPOSE 8080

# Comando para ejecutar la API de .NET
ENTRYPOINT ["dotnet", "assestment-JuaJoseZapata.dll"]
