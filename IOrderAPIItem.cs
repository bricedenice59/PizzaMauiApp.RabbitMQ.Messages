namespace PizzaMauiApp.RabbitMq.Messages;

public interface IOrderApiItem
{
    public Guid ItemId { get; set; }
    public int Quantity { get; set; }
}