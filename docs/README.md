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

## Testes de unidade

As pastas `notificacoes`, `pedidos` e `produtos` desta pasta contem arquivos `**.postman_collection.json` que são os arquivos que configuram nossos testes unitários. nestas pastas também temos os resultados concretos da ultima execução dos mesmos

## Serviços

### pedidos

Gerencia os pedidos de um atacadista

documento do swagger disponivel em `./pedidos-swagger.yaml` ou atravez do link do serviço [http://localhost:5000/swagger/](http://localhost:5000/swagger/)

### notificacoes

Troca de notificações entre as aplicações

documento swagger disponivel em `./notificacoes-swagger.yaml` ou através do link do servico [http://localhost:8080/docs/](http://localhost:8080/docs/)

### produtos

Produtos do lojista

documento swagger disponivel em `./produtos-swagger.yaml` ou através do link do serviço [http://localhost:8090/docs/](http://localhost:8090/docs/)
