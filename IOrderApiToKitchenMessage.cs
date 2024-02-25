namespace PizzaMauiApp.RabbitMq.Messages;

public interface IOrderApiToKitchenMessage
{
    public Guid OrderId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt{ get; set; }
    public List<IOrderItem> Items { get; set; }
}