using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCommonInterface.Common.Interfaces
{
    public interface ICloudStorage
    {
        byte[] DownloadDocument(string documentName);

        bool UploadDocument(IFormFile file);

        bool DeleteDocument(string fileName, string versionId = "");
    }
}
