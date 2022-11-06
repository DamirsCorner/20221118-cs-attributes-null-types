namespace NullableTypesInAttributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class MyAttribute : Attribute
{
    public MyAttribute() { }

    public MyAttribute(int nullableParameter)
    {
        NullableParameter = nullableParameter;
    }

    public int? NullableParameter { get; set; }
}
