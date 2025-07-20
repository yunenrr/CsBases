class Program
{
    static void Main()
    {
        // Declaración explícita
        int quantity = 5;
        string message = "Hello, World!";
        decimal price = 19.99m;
        WriteLine($"Cantidad: {quantity}, Saludo: {message}, Precio: {price:C}"); // El C indica formato de moneda

        // Declaración con var
        var gretting = "Hola";
        decimal porcentage = 20.00m;
        WriteLine($"Saludo: {gretting}, Porcentaje: {porcentage}");
    }
}