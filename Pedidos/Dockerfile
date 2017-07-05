FROM microsoft/dotnet:runtime
WORKDIR /dotnetapp
COPY out .
EXPOSE 5000
ENTRYPOINT ["dotnet", "Pedidos.dll"]