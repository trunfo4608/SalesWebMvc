# SalesWebMvc

O SalesWebMvc é um sistema de que registra a venda de um vendedor e 
o departamento ao qual ele pertence o vendedor,desenvolvido em ASP.NET 
Core MVC com o uso do Entity Framework.

## Pré-requisitos

Antes de executar o projeto, verifique se você atende aos seguintes pré-requisitos:

- **Visual Studio 2019:** Baixe e instale o [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/downloads/).

- **SQL Server 2012:** Baixe e instale o [SQL Server 2012](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).

## Configuração

1. Clone o repositório FinancasApp em sua máquina local.

2. Abra o projeto no Visual Studio 2019.

3. Abra o arquivo 'appsettings.json' no projeto e modifique a string de conexão para apontar para o seu servidor SQL Server.

4. Abra o Console do Gerenciador de Pacotes no Visual Studio e execute o seguinte comando para aplicar as migrações do Entity Framework e criar o banco de dados: update-database
