# Case-1
Imagine que você está utilizando o Git para desenvolver uma nova feature em um projeto colaborativo. Qual seria o passo a passo detalhado para conduzir a execução dessa feature?

# Passo a passo de como desenvolver a feature até a execução:

1 - **GitHub:** 
   - Realizar o login na conta do Github.

2 - **Criação do Repositório no Github:**
   - Agora será necessário criar um novo repositório. Para isso, realize os comandos a seguir:
    - No canto superior direito, clique no `+` e escolha `new repository`.
    - Preencha as informações do repositório, como nome, descrição (opcional), público ou privado, e inclua um arquivo README (opcional).
    - Após o preenchimento, clique em `Create repository` para criar o repositório com sucesso.

3 - **Clonar o Repositório para a Máquina Local:**
   - Assim que o repositório estiver criado no Github, é preciso clonar (ou copiar) para a máquina local. Para isso, obtenha o URL do repositório seguindo os comandos a seguir:
    - No GitHub, vá até o repositório que gostaria de clonar.
    - Clique no botão Verde (Code) perto do topo da página.
    - Copie o URL fornecido. Exemplo: `https://github.com/AleMagori/Case-1.git`.
    - Abra o Git Bash (ou terminal do Visual Studio) e vá até o diretório desejado.
    - Execute o comando: `git clone https://github.com/AleMagori/Case-1.git` para baixar uma cópia do repositório.

4 - **Criar Nova Branch Local para a Feature:**
   - Ainda no Git, crie uma nova branch local para trabalhar em sua feature.
    - Execute o comando: `git checkout -b desafioNovaBranch`.

5 - **Desenvolver a Feature:**
   - Desenvolva o código da aplicação e faça as alterações necessárias.

6 - **Verificar Alterações:**
   - Verifique os arquivos que foram alterados.
    - Execute o comando: `git status`.
 
7 - **Adicionar Arquivos Modificados:**
   - Adicione os arquivos modificados. 
   - Há duas opções: adicionar um arquivo específico ou adicionar todos os arquivos que foram alterados:
    - Execute o comando para arquivo específico: `git add file1` .
    - Execute o comando adicionar todos os arquivos: `git add .`.

8 - **Realizar Commit das Alterações:**
   - Faça o commit das alterações .
    - Execute o comando: `git commit -m "incluindo informações do passo a passo no readme"`.

9 - **Enviar Alterações para o Github:** 
   - Para enviar as alterações no Github.
    - Execute o comando: `git push origin desafioNovaBranch`.

10 - **Criar Pull Request no Github:**
    - Vá para o GitHub e crie um `Pull request` para mesclar as alterações no branch principal.
    - Suas alterações serão revisadas por outros colaboradores. Se tudo estiver correto, ocorrerá a aprovação. Caso contrário, podem ser solicitadas outras alterações ou discussões sobre a alteração realizada.

11 - **Resolver Conflitos (Se Necessário):**
    - Durante a revisão, pode haver conflitos com outras alterações já mescladas na branch principal.Pode causar conflitos com a branch que ainda não foi aprovada.
    - Execute o comando: `git pull origin main` para obter as últimas alterações e resolver conflitos(se houver), caso tenha conflitos o Git irá informar através das marcas "<<<<<<<" e ">>>>>>>". Essas macas indicam onde estão as alterações conflitantes. Dessa forma, você terá que editar e realizar a alteração correta. Após resolver todos os conflitos, pode realizar o commit e em seguida realizar o push como descritos nos tópicos 8 e 9.

12 - **Merge da Branch Aprovada:**
    - Após o "Pull request" ser aprovado, faça o merge com a branch principal.

13 - **Excluir Branch Local (Opcional):** 
    - Caso deseje, exclua a branch local.
    - Execute o comando: `git branch -d desafioNovaBranch`.

Este guia abrange desde a configuração inicial até a execução bem-sucedida do projeto. Caso tenha mais alguma dúvida ou sugestão, estou à disposição!