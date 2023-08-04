using Rabbit.Domain;

namespace Rabbit.Publisher.Api.Controllers.Presenters.Interfaces
{
    public interface IRabbitMessagePresenter
    {
        void SendMessage(RabbitMessage message);
    }
}
