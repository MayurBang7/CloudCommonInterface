namespace CloudCommonInterface
{
    abstract class AbstractFactory
    {
        public abstract CloudConnectionParams ConnectToAWS(CloudConnectionParams cloudConnectionParams);
        public abstract CloudConnectionParams ConnectToAZURE(CloudConnectionParams cloudConnectionParams);
        public abstract CloudConnectionParams ConnectToGCP(CloudConnectionParams cloudConnectionParams);
    }
}
