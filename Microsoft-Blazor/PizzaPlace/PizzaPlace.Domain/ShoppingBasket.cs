namespace PizzaPlace.Domain;

public class ShoppingBasket
{
    public Customer Customer { get; set; } = new Customer();
    public bool HasPaid { get; set; }
    public List<int> Orders { get; set; } = new List<int>();

    public void Add(int pizzaId)
    => Orders.Add(pizzaId);

    public void RemoveAt(int pos)
    => Orders.RemoveAt(pos);
}