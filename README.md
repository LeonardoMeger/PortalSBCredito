rojeto PortalSBCredito

Este projeto foi desenvolvido utilizando a arquitetura Domain-Driven Design (DDD), com .NET 8, Entity Framework Core e um banco de dados SQL.

Tecnologias Utilizadas

.NET 8

C#

Entity Framework Core

SQL Server

Arquitetura DDD (Domain-Driven Design)

Estrutura do Projeto

Configuração e Execução

Pré-requisitos

Antes de rodar o projeto, certifique-se de ter instalado:

.NET 8 SDK

Banco de dados SQL Server

Configuração do Banco de Dados

Defina a string de conexão no arquivo appsettings.json da API:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=NomeDoBanco;User Id=usuario;Password=senha;"
}

Execute as migrações do Entity Framework:

dotnet ef database update

Executando o Projeto

Para rodar a API, utilize o comando:

dotnet run --project src/PortalSBCredito

A API estará disponível em http://localhost:5071 (ou conforme configuração no launchSettings.json).
