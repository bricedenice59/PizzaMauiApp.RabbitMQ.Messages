
namespace PizzaMauiApp.RabbitMq.Messages;

public interface IKitchenMessage
{
    public Guid OrderId { get; set; }
    public Guid UserId { get; set; }
    public List<IOrderItem> Items { get; set; }
}