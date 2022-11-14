using ETicaretAPI.Infrastructure.Operations;
using Microsoft.AspNetCore.Hosting;

namespace ETicaretAPI.Infrastructure.Services
{
    public class FileService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        
    }
}
