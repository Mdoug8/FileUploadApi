# FileUploadApi

Esse projeto tem o interesse de demostrar o funcionamento de uma webservice Rest para upload de arquivos. 

Esse projeto foi elaborado usando ASP.NET Core utilizando linguagem C#.

Para executar o projeto, ser� necess�rio instalar os seguintes programas:
* https://visualstudio.microsoft.com/pt-br/downloads/
* https://www.postman.com/downloads/

Para iniciar o desenvolvimento, � necess�rio clonar o projeto do gitHub num diret�rio de sua prefer�ncia:

cd "diret�rio de sua prefer�ncia"

git clone https://github.com/Mdoug8/FileUploadApi.git

Para que voc� possa acessar e utilizar o projeto siga os seguintes passos:
1. Abra o Visual Studio 2019
2. Se voc� n�o tiver uma conta cadastrada ent�o cadastre uma.
3. Vai na op��o �Abrir um Projeto ou uma solu��o�.
4. Pesquise em qual diret�rio voc� fez o clone e entre na pasta.
5. Dentro da pasta selecione o arquivo FileUploadApi.sln e aperte em abrir.
6. Na barra de ferramentas aperta no bot�o verde que se chama �llS Express�
7. Ao apertar esse bot�o ele vai abrir uma guia no seu navegador, copie o link da aba.
8. Ap�s copiar o link abra o programa Postman.
9. Se voc� n�o tem uma conta criada ent�o crie uma para poder entrar.
10. Na tela de home ter� uma op��o �start with something new� e logo abaixo dele ter� a op��o �Create New�, clique nessa op��o �Create New�.
11. Na parte de cima da tela ter� uma aba chamada �Overview� e ao lado dessa aba ter� uma op��o de adicionar uma nova aba com o bot�o �+�, clique nesse bot�o e crie uma nova aba.
12. A tela ir� mudar e vai aparecer novos campos. Com o link que voc� copiou no passo 7, cole ele onde est� escrito �Enter request URL�
13. Ao lado desse campo do passo 12 mude a op��o de �GET� para �POST�. 
14. Logo embaixo ter� uma pequena barra de menu, selecione a op��o �Body�.
15. Logo ap�s selecionar essa op��o ir� aparecer novas op��es embaixo para poder selecionar, selecione a op��o �form-data�.
16. Logo abaixo vai aparecer tr�s op��es que s�o �Key�, �Value� e �Description�.
17. No campo key mude a op��o de text para file e escreva no campo o texto �files�.
18. Ap�s completar o passo 16 ir� observar no campo de Value que apareceu a op��o �Select files�, clique nessa op��o e selecione o arquivo que deseja fazer upload.
19. Ap�s selecionar o arquivo aperte no bot�o �Send� que fica logo acima.
20. Observe que na parte debaixo da tela vai aparecer as informa��es acerca do upload.
21. Ap�s isso volte para o Visual Studio e aperte no bot�o vermelho na barra de ferramentas chamado �Encerrar Depura��o�. Observe que com isso o servi�o web deixa de funcionar a n�o ser que voc� bote para funcionar novamente.
22. Observe que no lado direito da tela tem uma janela chamada �Gerenciador de solu��es�, nessa janela v� no arquivo �wwwroot� dentro dela tem a pasta �Upload� e observe que o arquivo que voc� fez upload est� salvo nessa pasta.

Com isso voc� j� ir� conseguir utilizar a proposta da API e observar o funcionamento dela.
