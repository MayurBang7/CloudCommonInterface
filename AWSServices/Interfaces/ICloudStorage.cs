using Microsoft.AspNetCore.Http;

namespace CloudCommonInterface.Services.Interfaces
{
    public interface ICloudStorage
    {
        Task<byte[]> DownloadFileAsync(string file);

        Task<bool> UploadFileAsync(IFormFile file);

        Task<bool> DeleteFileAsync(string fileName, string versionId = "");
    }
}
