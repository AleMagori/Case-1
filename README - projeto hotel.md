# Projeto Hotel 
Realizado a criação do projeto de gerenciamento de funcionários de um hotel na linguagem C# com conexão ao MySQL.

1 - **Criação do Banco de Dados:**

   - Utilizei o MySQL para criar o banco de dados.

2 - **Tabelas e Inserção de Dados:**

   - Criei as tabelas de funcionários e departamentos e inseri informações no MySQL.

3 - **Extensões necessárias no Visual Code:**

   - Verifiquei e instalei as extensões necessárias no Visual Code:

     - SQLtools (https://marketplace.visualstudio.com/items?itemName=mtxr.sqltools).

     - SQLtools MySQL/MariaDB/TiDB (https://marketplace.visualstudio.com/items?itemName=mtxr.sqltools-driver-mysql).

4 - **Teste de conexão com MySQL e Visual Code:**

   - Como já tinha realizado a criação do banco de dados consegui realizar o teste no SQLtools e tive sucesso na conexão.

5 - **Código C#** 

   - Realização do código em C#.

6 - **Configuração do ambiente .NET Core SDK:**

   - Verifique se possui o .NET Core SDK instalado, caso não tenha acesse o site oficial e siga as instruções: https://dotnet.microsoft.com/download.
   
7 - **Verificação do ambiente .NET Core SDK:**
   - No prompt de comando (ou no terminal do Visual Code, conforme preferência), verifique a correta instalação do .NET Core SDK com o comando:
   - Executei `dotnet --version`.
   - Se a instalação ocorreu com sucesso, irá demonstrar a versão do SDK. 

8 - **Verificação do Extensão "C#":** 
   - Certifique de ter a extensão "C#" está instalada.

9 - **Criação e Restauração do Projeto em C#:**
   - Utilizei o comando `dotnet new console -o hotel` para criar o projeto, com isso será demonstrado na pasta do projeto o arquivo hotel.csproj.
   - Executei `dotnet restore` para restaurar as bibliotecas e ferramentas necessárias como o pacote Nuget.

10 - **Adição do Pacote NuGet "MySql.Data":**
    - Adicionei o pacote MySql.Data usando o comando `dotnet add package MySql.Data`.
    - Quando realizar isso irá atualizar o arquivo hotel.csproj.

11 - **Execução do Projeto:**
 - Executei o projeto com o comando `dotnet run`.Com isso irá demonstrar as tabelas funcionários e departamentos cadastradas no Mysql.

12 - **Branch e Upload no GitHub:** 
    - Seguir o README-case-1 a partir do tópico 8, criando uma nova branch antes de enviar para a main.

Este guia abrange desde a configuração inicial até a execução bem-sucedida do projeto. Caso tenha mais alguma dúvida ou sugestão, estou à disposição!