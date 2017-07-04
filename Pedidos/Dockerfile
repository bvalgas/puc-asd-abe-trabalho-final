FROM microsoft/aspnetcore:1.1
COPY . /app
ARG source
WORKDIR /app

CMD ["dotnet", "restore"]

CMD ["dotnet", "build"]

EXPOSE 5000/tcp

ENTRYPOINT ["dotnet", "run", "--server.urls", "http://0.0.0.0:5000"]

