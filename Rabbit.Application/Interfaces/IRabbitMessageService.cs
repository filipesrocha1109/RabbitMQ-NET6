using Rabbit.Domain;

namespace Rabbit.Application.Interfaces
{
    public interface IRabbitMessageService
    {
        void SendMessage(RabbitMessage message);
    }
}
