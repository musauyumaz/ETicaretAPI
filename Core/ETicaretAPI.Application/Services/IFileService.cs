using Microsoft.AspNetCore.Http;

namespace ETicaretAPI.Application.Services
{
    public interface IFileService
    {
        Task<IList<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files);
        Task<bool> CopyFileAsync(string path, IFormFile file);
    }
}
