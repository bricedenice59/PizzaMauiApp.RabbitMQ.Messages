namespace PizzaMauiApp.RabbitMq.Messages;

public interface IKitchenToOrderAPIMessage
{
    public Guid OrderId { get; set; }
    public Guid UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<IOrderItem> Items { get; set; }
    public bool IsAccepted { get; set; }
}