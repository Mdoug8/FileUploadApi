# FileUploadApi

Esse projeto tem o interesse de demostrar o funcionamento de uma webservice Rest para upload de arquivos. 

Esse projeto foi elaborado usando ASP.NET Core utilizando linguagem C#.

Para executar o projeto, será necessário instalar os seguintes programas:
* https://visualstudio.microsoft.com/pt-br/downloads/
* https://www.postman.com/downloads/

Para iniciar o desenvolvimento, é necessário clonar o projeto do gitHub num diretório de sua preferência:

cd "diretório de sua preferência"

git clone https://github.com/Mdoug8/FileUploadApi.git

Para que você possa acessar e utilizar o projeto siga os seguintes passos:
1. Abra o Visual Studio 2019
2. Se você não tiver uma conta cadastrada então cadastre uma.
3. Vai na opção “Abrir um Projeto ou uma solução”.
4. Pesquise em qual diretório você fez o clone e entre na pasta.
5. Dentro da pasta selecione o arquivo FileUploadApi.sln e aperte em abrir.
6. Na barra de ferramentas aperta no botão verde que se chama “llS Express”
7. Ao apertar esse botão ele vai abrir uma guia no seu navegador, copie o link da aba.
8. Após copiar o link abra o programa Postman.
9. Se você não tem uma conta criada então crie uma para poder entrar.
10. Na tela de home terá uma opção “start with something new” e logo abaixo dele terá a opção “Create New”, clique nessa opção “Create New”.
11. Na parte de cima da tela terá uma aba chamada “Overview” e ao lado dessa aba terá uma opção de adicionar uma nova aba com o botão “+”, clique nesse botão e crie uma nova aba.
12. A tela irá mudar e vai aparecer novos campos. Com o link que você copiou no passo 7, cole ele onde está escrito “Enter request URL”
13. Ao lado desse campo do passo 12 mude a opção de “GET” para “POST”. 
14. Logo embaixo terá uma pequena barra de menu, selecione a opção “Body”.
15. Logo após selecionar essa opção irá aparecer novas opções embaixo para poder selecionar, selecione a opção “form-data”.
16. Logo abaixo vai aparecer três opções que são “Key”, “Value” e “Description”.
17. No campo key mude a opção de text para file e escreva no campo o texto “files”.
18. Após completar o passo 16 irá observar no campo de Value que apareceu a opção “Select files”, clique nessa opção e selecione o arquivo que deseja fazer upload.
19. Após selecionar o arquivo aperte no botão “Send” que fica logo acima.
20. Observe que na parte debaixo da tela vai aparecer as informações acerca do upload.
21. Após isso volte para o Visual Studio e aperte no botão vermelho na barra de ferramentas chamado “Encerrar Depuração”. Observe que com isso o serviço web deixa de funcionar a não ser que você bote para funcionar novamente.
22. Observe que no lado direito da tela tem uma janela chamada “Gerenciador de soluções”, nessa janela vá no arquivo “wwwroot” dentro dela tem a pasta “Upload” e observe que o arquivo que você fez upload está salvo nessa pasta.

Com isso você já irá conseguir utilizar a proposta da API e observar o funcionamento dela.
