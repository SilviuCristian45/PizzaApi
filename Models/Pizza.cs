
public record Pizza 
{
    public int id { get; set; }
    public PizzaType type { get; set; }
    public int popularityRating { get; set; }
    public List<Topping> toppings { get; set; }
    public double price { get; set; }
    public string description { get; set; }
}