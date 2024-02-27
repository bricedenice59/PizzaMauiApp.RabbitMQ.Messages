
namespace PizzaMauiApp.RabbitMq.Messages;

public interface IKitchenOrderAccepted
{
    public Guid OrderId { get; set; }
    public string UserId { get; set; }
    public List<IOrderItem> Items { get; set; }
    public DateTime CreatedAt{ get; set; }
}