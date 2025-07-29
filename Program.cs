using System.Threading.Tasks;
using CsBases.Fundamentals;

class Program
{
    static async Task Main()
    {
        var laptop = new Product("Laptop", 1200);
        WriteLine(laptop.GetDescription());

        var soporte = new ServiceProduct("Soporte Técnico", 300, 30);
        WriteLine(soporte.GetDescription());

        var product = new Product("Mouse Gamer", 700);
        var productDto = ProductAdapter.ToDto(product);
        WriteLine($"{productDto.Name} - {productDto.Price:c} - Código: {productDto.Code}");

        // Inyección de dependencias
        ILabelService labelService = new LabelService();
        var manager = new ProductManager(labelService);
        var monitor = new Product("Monitor", 100);
        var installation = new ServiceProduct("Instalación de monitor", 20, 30);
        manager.PrintLabel(monitor);
        manager.PrintLabel(installation);

        var firstProduct = await new ProductRepository().GetProduct(1);
        firstProduct.Description = "Esta es la descripción del primer producto";
        AttributeProcesor.ApplyUpperCase(firstProduct);
        WriteLine($"{firstProduct.Name} - {firstProduct.Price:c} - {firstProduct.Description}");
    }
}