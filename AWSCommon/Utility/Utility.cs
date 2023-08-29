namespace CloudCommonInterface.Common.Utility
{
    public class Utility
    {
        public CloudConnectionParams GetConnectionParams(string ClientId)
        {
            AbstractFactory factory = new GroupFactory();
            CloudConnectionParams cloudConnectionParams = new CloudConnectionParams();
            //Get details from DB 
            var CloudType = "AWS";

            switch (cloudConnectionParams.CloudType)
            {
                case "AWS":
                    return factory.ConnectToAWS(cloudConnectionParams);

                case "Azure":
                    return factory.ConnectToAWS(cloudConnectionParams);
                case "GCP":
                    return factory.ConnectToAWS(cloudConnectionParams);
                default:
                    return null;
            }
        }
    }
}
