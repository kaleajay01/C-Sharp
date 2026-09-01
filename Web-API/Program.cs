using WebAPI.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var products = new List<Product>
{
    new Product
    {
        Id = 1,
        Name = "Laptop",
        Price = 75000
    },
    new Product
    {
        Id = 2,
        Name = "Mouse",
        Price = 1500
    },
    new Product
    {
        Id = 3,
        Name = "Keyboard",
        Price = 3000
    }
};

app.MapGet("/", () =>
{
    return "My Minimal API is running!";
});

app.MapGet("/products", () =>
{
    return Results.Ok(products);
});

app.MapGet("/products/{id}",(int id)=>
{
   var product = products.FirstOrDefault(p=>p.Id==id);
   if(product == null)
    {
        return Results.NotFound("Product not found");
    }
    return Results.Ok(product);
});

app.MapPost("/products",(Product product)=>
{
   product.Id = product.Count + 1 ;
   products.Add(product);
   return Results.Ok(product);
});

app.Run();