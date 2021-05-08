using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageUpload : ControllerBase
    {
        public static IWebHostEnvironment _environment;
        public ImageUpload(IWebHostEnvironment environment)
        {
            _environment = environment;

        }

        public class FileUPloadAPI
        {
            public IFormFile files { get; set; }
        }

        [HttpPost]
        public async Task<string> Post([FromForm]FileUPloadAPI objFile)
        {
            try
            {
                // verifica se o tamanho do arquivo e maior que 0, condicao de existencia 
                if (objFile.files.Length > 0)
                {
                    // condicao de existencia para a criacao do diretorio
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        //cria todos os diretorios e subdiretorios no caminho especificado, a menos que eles ja existam.
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }

                    // para recursos nao gerenciados, usar o using e uma coisa boa para poder ser feito a desalocacao de memoria quando o objeto nao estiver mais sendo usado
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        // le os bits do fluxo atual e os grava em um outro fluxo
                        objFile.files.CopyTo(fileStream);
                        //limpa os buffers desse fluxo e faz com que todos os dados armazenados em buffer sejam gravados no arquivo.
                        fileStream.Flush();
                        return "Upload feito com sucesso." + "\r\n"+"Nome do arquivo:" + objFile.files.FileName + "\r\n"+ "Tamanho do arquivo em bytes:"+ objFile.files.Length + "\r\n" + "Código Hash do arquivo:"+objFile.files.GetHashCode();
                    }
                }
                else
                {
                    return "Erro ao fazer Upload. Verifique se seu arquivo e valido";
                }

            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
    }
}
