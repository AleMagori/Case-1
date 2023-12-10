# Case-1
Imagine que você está utilizando o Git para desenvolver uma nova feature em um projeto colaborativo. Qual seria o passo a passo detalhado para conduzir a execução dessa feature?

# Passo a passo de como desenvolver a feature até a execução:

1 - Realizar o login na conta do Github;

2 - Agora será necessário criar um novo repositório. Para isso, realize os comandos a seguir:
   No canto superior direito, clique no "+" e escolha "new repository";

3 - É necessário o preenchimento das informações do repositório. Nessa etapa, escolha o nome, adicione uma descrição (é opcional), escolha se o repositório será público ou privado e inclua um arquivo de README (Opcional);

4 - Após preencher as informações do repositório, clique em "Create repository". Com isso, o repositório será criado com sucesso;

5 - Assim que o repositório estiver criado no Github, é preciso clonar (ou copiar) para a máquina local. Para isso, obtenha o URL do repositório seguindo os comandos a seguir:
   No GitHub, vá até o repositório que gostaria de clonar.
   Clique no botão Verde (Code) perto do topo da página.
   Copie o URL fornecido. Exemplo: https://github.com/AleMagori/Case-1.git

6 - Abra o Git Bash (ou terminal do Visual Studio), vá até o diretório onde deseja clonar o repositório e realize o comando abaixo:
     git clone https://github.com/AleMagori/Case-1.git
    Assim que pressionar o Enter, o Git vai baixar uma cópia do repositório para o computador;

7 - Ainda no Git, crie uma nova branch local para trabalhar em sua feature usando o comando:
     git checkout -b desafioNovaBranch

 8 - Desenvolva o código da aplicação e faça as alterações e salve;

 9 - Verifique os arquivos que foram alterados usando o comando:
     git status
 
 10 - Adicione os arquivos modificados. Há duas opções: adicionar um arquivo específico ou adicionar todos os arquivos que foram alterados:
     git add file1 
     git add .

 11 - Realize o commit das alterações usando o comando:
     git commit  -m "incluindo informacoes do passo a passo no readme"

 12 - Para enviar as alterações no Github, use o comando:
     git push origin desafioNovaBranch

 13 - Agora, vá para o GitHub e crie um "Pull request" para mesclar as alterações no branch principal. Ou seja, suas alterações serão revisadas por outros colaboradores e, estando tudo certo, ocorrerá a aprovação. Caso contrário, podem solicitar outras alterações ou até mesmo discutir sobre a alteração que foi realizada.

 14 - Durante esse tempo de revisão, provavelmente houve outros "Pull requests" aprovados e que já foram mesclados na branch principal. Isso pode causar conflitos com a branch que ainda não foi aprovada. Dessa forma, é recomendado que faça o comando abaixo:
     git pull origin main
 Com isso, terá as últimas alterações e, se houver algum tipo de conflito, o Git irá informar através das marcas "<<<<<<<" e ">>>>>>>". Essas macas indicam onde estão as alterações conflitantes. Dessa forma, você terá que editar e realizar a alteração correta. Após resolver todos os conflitos, pode realizar o commit e em seguida realizar o push como descrito no passo 11 e 12.

 15 - Após o "Pull request" ser aprovado, pode ser mesclado com a branch principal (main ou master);

16 - Como a branch que estava trabalhando foi aprovada e mesclada na branch principal, podemos realizar a exclusão da branch usando o comando:
     git branch -d desafioNovaBranch