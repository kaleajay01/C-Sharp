namespace WebAPI.Models;
public class Product
{
    public int Id { get; internal set; }
    public string Name {get; set;} 
    public decimal Price {get; set;}
    public int Count { get; internal set; }

    internal void Remove(Product product)
    {
        throw new NotImplementedException();
    }
}