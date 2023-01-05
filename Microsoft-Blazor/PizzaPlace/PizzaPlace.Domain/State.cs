namespace PizzaPlace.Domain;

public class State
{
    public ShoppingBasket Basket { get; } = new ShoppingBasket();
    public Pizza? CurrentPizza { get; set; }
    public Menu Menu { get; } = new Menu();

    public decimal TotalPrice
    => Basket.Orders.Sum(id => Menu.GetPizza(id)!.Price);

    public UI UI { get; set; } = new UI();
}