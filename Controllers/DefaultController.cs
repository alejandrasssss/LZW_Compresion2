using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace Lzw_compresion2.Controllers
{



    public class DefaultController : ControllerBase
    {
        [HttpPost]
        [Route("api")]
        public async Task<IActionResult> PostDescompresion(IFormFile file, string nombre)
        {
            var filePath = Path.GetTempFileName();
            if (file.Length > 0)
                using (var stream = new FileStream(filePath, FileMode.Create))
                    await file.CopyToAsync(stream);
           /// aqui va el metodo para comprimir
            return Ok();

        }
    }

    
}