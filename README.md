# Case-1
 Imagine que você está utilizando o Git para desenvolver uma nova feature em um projeto colaborativo. Quais seria o passo o passo detalhado para conduzir a execução dessa feature?

# Passo a passo de como desenvolver a feature até a execução:
 1 - Realizar o login na conta do Github;

 2 - Agora será necessário criar um novo repositorio para isso realizar os comandos a seguir:
    No canto superior direto, clique no "+" e escolha "new repository";

 3 - É necessário o preenchimento das informações do repositório, nessa etapa irá escolher o nome, adicionar uma descrição(é opcional), escolher se o respositório será público ou privado e incluir um arquivo de README(Opcional);

 4 - Depois que realizar o preenchimento das informações do repositório, clique em "Create respository", com isso o repositório será criado com sucesso;

 5 - Assim que o repositório está criado no Github é preciso clonar( ou copiar) para a máquina local para isso é necessário que obtenha o URL do repositório seguindo os comandos a seguir:
    No GitHub, vá até o repositorio que gostaria de clonar.
    Clique no botão Verde (Code) perto do topo da página.
    Copie o Url fornecido. Exemplo: https://github.com/AleMagori/Case-1.git 

 6 - Abra o Git Bash (ou terminal do Visual Studio) vá até o diretório onde deseja clonar o repositório e realize o comando abaixo:
    git clone https://github.com/AleMagori/Case-1.git
    Assim que precionar o enter o Git vai baixar uma cópia do repositório para o computador;

 7 - Ainda no Git crie uma nova branch local para trabalhar em sua feature usando o comando:
    git checkout -b desafioNovaBranch

 8 - Desenvolva o código da aplicação e alterações e salve;

 9 - Verificar os arquivos que foram alterados usando o comando:
     git status

 10 - Adicione os arquivos modificados tem duas opções adicionar o arquivo especifico ou adicionar todos os arquivos que foram alterados:
     git add file1 
     git add .

 11 - Realizar o commit das alterações usando o comando:
     git commit  -m "incluindo informacoes do passo a passo no readme"

 12 - Para enviar as alterações no Github usando o comando: 
     git push origin desafioNovaBranch
 