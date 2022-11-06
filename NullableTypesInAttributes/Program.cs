using NullableTypesInAttributes;
using System.Reflection;

var attributes = typeof(MyRecord).GetCustomAttributes<MyAttribute>(true);
foreach (var attribute in attributes)
{
    Console.WriteLine($"NullableParameter: {attribute.NullableParameter}");
}

[My()]
[My(nullableParameter: 1)]
public record MyRecord();
