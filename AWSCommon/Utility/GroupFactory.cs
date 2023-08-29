namespace CloudCommonInterface
{
    class GroupFactory:AbstractFactory
    {
        public override CloudConnectionParams ConnectToAWS(CloudConnectionParams cloudConnectionParams)
        {
            return new AWS(cloudConnectionParams);
        }
        public override CloudConnectionParams ConnectToAZURE(CloudConnectionParams cloudConnectionParams)
        {
            return new AZURE(cloudConnectionParams);
        }
        public override CloudConnectionParams ConnectToGCP(CloudConnectionParams cloudConnectionParams)
        {
            return new GCP(cloudConnectionParams);
        }
    }
}
