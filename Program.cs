using CsBases.Fundamentals;

class Program
{
    static void Main()
    {
        // Declaración explícita
        int quantity = 5;
        string message = "Hello World!";
        decimal price = 19.99m;
        //WriteLine($"Cantidad: {quantity}, Saludo: {message}, Precio: {price:C}"); // El C indica formato de moneda

        // Declaración con var
        var gretting = "Hola";
        decimal porcentage = 20.00m;
        //WriteLine($"Saludo: {gretting}, Porcentaje: {porcentage}");

        var laptop = new Product("Laptop", 1200);
        WriteLine(laptop.GetDescription());

        var soporte = new ServiceProduct("Soporte Técnico", 300, 30);
        WriteLine(soporte.GetDescription());
    }
}