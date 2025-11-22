namespace NamespacePlayground.Internal.Customers.Repositories;

using NamespacePlayground.PublicApi.Customers.V1;

/// <summary>
/// Internal repository implementation for customers.
/// This lives under Internal.* to show separation from PublicApi.*.
/// </summary>
internal sealed class CustomerRepository
{
    private readonly List<Customer> _store = new();

    public void Save(Customer customer)
    {
        _store.Add(customer);
        Console.WriteLine($"[Internal] Saved customer '{customer.Name}' to in‑memory store.");
    }
}
