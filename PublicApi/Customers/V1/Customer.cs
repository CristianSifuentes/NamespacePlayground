namespace NamespacePlayground.PublicApi.Customers.V1;

/// <summary>
/// Public customer contract, version 1.
/// Demonstrates a simple public type inside a nested namespace.
/// </summary>
public sealed class Customer
{
    public Customer(string name) => Name = name;

    public string Name { get; }
}
