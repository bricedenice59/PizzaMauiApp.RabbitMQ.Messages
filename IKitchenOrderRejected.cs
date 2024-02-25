
namespace PizzaMauiApp.RabbitMq.Messages;

public interface IKitchenOrderRejected
{
    public Guid OrderId { get; set; }
    public Guid UserId { get; set; }
    public List<IOrderItem> Items { get; set; }
    public DateTime CreatedAt{ get; set; }
}