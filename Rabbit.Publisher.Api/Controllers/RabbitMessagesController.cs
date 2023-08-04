using Microsoft.AspNetCore.Mvc;
using Rabbit.Domain;
using Rabbit.Publisher.Api.Controllers.Presenters.Interfaces;

namespace Rabbit.Publisher.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitMessagesController : ControllerBase
    {
        private readonly IRabbitMessagePresenter _rabbitMessagePresenter;

        public RabbitMessagesController(IRabbitMessagePresenter rabbitMessagePresenter)
        {
            _rabbitMessagePresenter = rabbitMessagePresenter;
        }

        [HttpPost]
        public void Post([FromBody] RabbitMessage message)
        {
            _rabbitMessagePresenter.SendMessage(message);
        }
    }
}
