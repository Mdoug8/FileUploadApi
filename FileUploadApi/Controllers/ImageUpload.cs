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
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "Upload feito com sucesso." + "\r\n"+"Nome do arquivo:" + objFile.files.FileName + "\r\n"+ "Tamanho do arquivo em bytes:"+ objFile.files.Length + "\r\n" + "Código Hash do arquivo:"+objFile.files.GetHashCode();
                    }
                }
                else
                {
                    return "Erro.";
                }

            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }
    }
}
