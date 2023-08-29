using Amazon.S3;
using CloudCommonInterface.Common.Interfaces;
using IServiceStorage = CloudCommonInterface.Services.Interfaces.ICloudStorage;
using Microsoft.AspNetCore.Http;
using ICloudStorage = CloudCommonInterface.Common.Interfaces.ICloudStorage;

namespace CloudCommonInterface.Common.Features
{
    public class CloudStorage : ICloudStorage
    {
        private readonly IServiceStorage _Services;
        public CloudStorage(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, string region, string bucketName, string Cloudtype)
        {
            _Services = new Services.AWSServices.AWSStorageServices(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, region, bucketName);
        }

        public byte[] DownloadDocument(string documentName)
        {
            try
            {
                return _Services.DownloadFileAsync(documentName).Result;
            }

            catch (Exception)
            {
                throw;
            }
        }

        public bool UploadDocument(IFormFile file)
        {
            return _Services.UploadFileAsync(file).Result;
        }

        public bool DeleteDocument(string fileName, string versionId = "")
        {
            return _Services.DeleteFileAsync(fileName).Result;
        }
    }
}