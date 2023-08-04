using Rabbit.Application.Interfaces;
using Rabbit.Domain;
using Rabbit.Repositories.Interfaces;

namespace Rabbit.Application.Services
{
    public class RabbitMessageService : IRabbitMessageService
    {
        private readonly IRabbitMessageRepository _rabbitMessageRepository;
        public RabbitMessageService(IRabbitMessageRepository rabbitMessageRepository)
        {
            _rabbitMessageRepository = rabbitMessageRepository;
        }
        public void SendMessage(RabbitMessage message)
        {
            _rabbitMessageRepository.SendMessage(message);
        }
    }

}
