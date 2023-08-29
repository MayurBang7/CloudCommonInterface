using CloudCommonInterface.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ICloudStorage = CloudCommonInterface.Common.Interfaces.ICloudStorage;

namespace CloudCommonInterface.ControllerBase
{
    [ApiController]
    [Route("[controller]")]
    public class CloudController : Controller
    {
        private ICloudStorage _cloudStorageServices;

        public CloudController()
        {

        }

        [HttpGet("{documentName}")]
        public IActionResult GetDocumentFromCloud(string documentName, string cloudType)
        {
            try
            {


                if (string.IsNullOrEmpty(documentName))
                    return ReturnMessage("The 'documentName' parameter is required", (int)HttpStatusCode.BadRequest);

                var document = _cloudStorageServices.DownloadDocument(documentName);

                return File(document, "application/octet-stream", documentName);
            }
            catch (Exception ex)
            {
                return ValidateException(ex);
            }
        }

        [HttpPost]
        public IActionResult UploadDocumentToCloud(IFormFile file, int Clientid)
        {
            try
            {
                if (file is null || file.Length <= 0)
                    return ReturnMessage("file is required to upload", (int)HttpStatusCode.BadRequest);
                var result = _cloudStorageServices.UploadDocument(file);

                return ReturnMessage(string.Empty, (int)HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return ReturnMessage(ex.Message, (int)HttpStatusCode.InternalServerError);
            }
        }

        [HttpDelete("{documentName}")]
        public IActionResult DeletetDocumentFromCloud(string documentName)
        {
            try
            {
                if (string.IsNullOrEmpty(documentName))
                    return ReturnMessage("The 'documentName' parameter is required", (int)HttpStatusCode.BadRequest);

                var result = _cloudStorageServices.DeleteDocument(documentName);

                return ReturnMessage(string.Format("The document '{0}' is deleted successfully", documentName));
            }
            catch (Exception ex)
            {
                return ValidateException(ex);
            }
        }

        [HttpDelete("{documentName}/{versionId}")]
        public IActionResult DeletetDocumentFromCloud(string documentName, string versionId)
        {
            try
            {
                if (string.IsNullOrEmpty(documentName))
                    return ReturnMessage("The 'documentName' parameter is required", (int)HttpStatusCode.BadRequest);

                if (string.IsNullOrEmpty(versionId))
                    return ReturnMessage("The 'versionId' parameter is required", (int)HttpStatusCode.BadRequest);

                var result = _cloudStorageServices.DeleteDocument(documentName, versionId);

                return ReturnMessage(string.Format("The document '{0}' is deleted successfully", documentName));
            }
            catch (Exception ex)
            {
                return ValidateException(ex);
            }
        }

        private IActionResult ReturnMessage(string message, int? statusCode = null)
        {
            return new ContentResult()
            {
                Content = message,
                ContentType = "application/json",
                StatusCode = statusCode
            };
        }

        private IActionResult ValidateException(Exception ex)
        {
            if (ex.InnerException != null && ex.InnerException is FileNotFoundException)
                return ReturnMessage(ex.Message, (int)HttpStatusCode.NotFound);

            return ReturnMessage(ex.Message, (int)HttpStatusCode.InternalServerError);
        }
    }
}
