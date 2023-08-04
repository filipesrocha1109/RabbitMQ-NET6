using Rabbit.Domain;

namespace Rabbit.Repositories.Interfaces
{
    public interface IRabbitMessageRepository
    {
        void SendMessage(RabbitMessage message);
    }
}
