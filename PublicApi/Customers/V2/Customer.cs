namespace NamespacePlayground.PublicApi.Customers.V2;

/// <summary>
/// Public customer contract, version 2.
/// Same class name as V1 but in a different namespace.
/// </summary>
public sealed class Customer
{
    public Customer(string name, int loyaltyPoints)
    {
        Name = name;
        LoyaltyPoints = loyaltyPoints;
    }

    public string Name { get; }
    public int LoyaltyPoints { get; }
}
