namespace CityInfo.API.ResourceManipulation.Services
{
    public interface  IMailService
    {
        void Send(string subject, string message);
    }
}
