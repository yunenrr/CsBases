using CsBases.Fundamentals;

public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        // Obtener de una base de datos, API externa o archivo.
        //return new Product("Producto simulado", 500);
        // Simulando una búsqueda de producto
        WriteLine($"Buscando producto con ID: {id}");
        await Task.Delay(2000);
        return new Product("Producto simulado", 500);
    }
}