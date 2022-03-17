
namespace WaitersApp
{
    public interface Emailing
    {
        void SendEmail(string email);
        void SendEmail(Receipt receipt);
    }
}
