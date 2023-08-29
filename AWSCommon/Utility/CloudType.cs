namespace CloudCommonInterface
{
    //all types of cloud storage to be defined here temporarily
    public class AWS : CloudConnectionParams
    {
        public AWS(CloudConnectionParams cloudConnectionParams)
        {
            this.CloudType = cloudConnectionParams.CloudType;
            this.bucketName = "";
            this.storageDue = 500;
            this.AccessKey = "";
            this.SecretAccessKey = "";
            this.SessionToken = "";
            this.fileName = "";
            this.Region = "INDIA";
        }
    }
    public class AZURE : CloudConnectionParams
    {
        public AZURE(CloudConnectionParams cloudConnectionParams)
        {
            this.CloudType = "AZURE";
            this.bucketName = "";
            this.storageDue = 500;
            this.ConnectionString = "";
            this.fileName = "";
        }
    }

    public class GCP : CloudConnectionParams
    {
        public GCP(CloudConnectionParams cloudConnectionParams)
        {
            this.CloudType = "GCP";
            this.ConnectionString = "";
            this.storageDue = 1000;
            this.AccessKey = "";
            this.SecretAccessKey = "";
            this.SessionToken = "";
            this.fileName = "";
        }
    }
}
