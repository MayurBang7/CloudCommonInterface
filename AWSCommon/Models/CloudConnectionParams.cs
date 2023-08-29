namespace CloudCommonInterface
{
    public class CloudConnectionParams
    {
        internal string CloudType { get; set; }
        internal int storageDue { get; set; }
        internal string bucketName { get; set; }//folder name
        internal string fileName { get; set; }//file name
        internal string ConnectionString { get; set; }//blob connection string or any other
        internal string Region { get; set; }
        internal string AccessKey { get; set; }//Access key
        internal string SecretAccessKey { get; set; }
        internal string SessionToken { get; set; }
        
    }
}
