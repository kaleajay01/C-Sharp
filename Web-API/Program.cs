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
   product.Id = products.Count + 1 ;
   products.Add(product);
   return Results.Ok(product);
});

app.MapPut("/products/{id}",(int id, Product product)=>
{
   var existingProduct = products.FirstOrDefault(p => p.Id == id);
   if(existingProduct == null)
    {
        return Results.NotFound();
    }
    existingProduct.Name = product.Name;
    existingProduct.Price = product.Price;

    return Results.Ok(existingProduct);
});

app.MapDelete("/products/{id}",(int id)=>
{
    var removeproduct = products.FirstOrDefault(p=>p.Id==id);
    if(removeproduct == null)
    {
        return Results.NotFound();
    }
    products.Remove(removeproduct);
    return Results.Ok();
});

app.Run();