using Rabbit.Application.Interfaces;
using Rabbit.Domain;
using Rabbit.Publisher.Api.Controllers.Presenters.Interfaces;

namespace Rabbit.Publisher.Api.Controllers.Presenters
{
    public class RabbitMessagePresenter : IRabbitMessagePresenter
    {
        private readonly IRabbitMessageService _rabbitMessageService;
        public RabbitMessagePresenter(IRabbitMessageService rabbitMessageService)
        {
            _rabbitMessageService = rabbitMessageService;
        }

        public void SendMessage(RabbitMessage message)
        {
            _rabbitMessageService.SendMessage(message);
        }
    }
}
