using CloudCommonInterface.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace CloudCommonInterface.Services.AzureServices
{
    public class AzureStorageServices : ICloudStorage
    {
        public Task<bool> DeleteFileAsync(string fileName, string versionId = "")
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> DownloadFileAsync(string file)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UploadFileAsync(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
