# Instruções

Instruções para criação das imagens docker e instruções para execução da aplicação

## Criação imagens do docker

### pedidos

na pasta `./Pedidos/` execute os comandos `dotnet restore`, `dotnet build`, `dotnet publish -o out` estes comandos irão criar os executaveis do projeto dotnet para a plataforma especifica.

sem seguida execute o comando `docker build . -t pedidos` para criar a imagem de pedidos

### notificacoes

na pasta `./notificacoes/` execute o comando `docker build . -t notificacoes` para criar a imagem do serviço de notificações.

### produtos

na pasta `./produtos/` execute o comando `docker build . -t produtos` para criar a imagem do servico de produtos

## Executando

Para execução, alem dos 3 serviços principais de nossa aplicação, subimos também o mongodb, isso tudo configurado por um composer docker que irá fazer esse vinculo para nós.

para executar os serviços execute `docker-compose up` na pasta raiz do projeto.
