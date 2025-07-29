[AttributeUsage(AttributeTargets.Property)] // Este atributo se aplica a propiedades
public class UpperCaseAttribute : Attribute
{

}

public static class AttributeProcesor
{
    public static void ApplyUpperCase(object obj)
    {
        var props = obj.GetType().GetProperties(); // Obtiene todas las propiedades del objeto

        foreach(var prop in props)
        {
            // Verifica que la propiedad tenga el atributo y sea de tipo string
            if (prop.PropertyType == typeof(string) && Attribute.IsDefined(prop, typeof(UpperCaseAttribute)))
            {
                var value = prop.GetValue(obj) as string; // Obtiene el valor de la propiedad
                if (!string.IsNullOrWhiteSpace(value))
                {
                    prop.SetValue(obj, value.ToUpper()); // Establece el valor en mayúsculas
                }
            }
        }
    }
}