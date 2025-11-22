namespace NamespacePlayground.Demos;

// Aliases used in several demos
using CustomerV1 = NamespacePlayground.PublicApi.Customers.V1.Customer;
using CustomerV2 = NamespacePlayground.PublicApi.Customers.V2.Customer;
using InternalRepo = NamespacePlayground.Internal.Customers.Repositories.CustomerRepository;

internal static class NestedNamespacesDemo
{
    public static void Run()
    {
        Console.WriteLine("Namespaces can be *nested* using dot‑separated identifiers.");
        Console.WriteLine("Example: NamespacePlayground.PublicApi.Customers.V1");
        Console.WriteLine("Type full name: " + typeof(CustomerV1).FullName);
    }
}

internal static class SameNameDifferentNamespacesDemo
{
    public static void Run()
    {
        Console.WriteLine("Different namespaces can contain types with the same name.");
        var v1 = new CustomerV1("Alice");
        var v2 = new CustomerV2("Alice", loyaltyPoints: 42);

        Console.WriteLine($"V1 customer: {v1.Name}");
        Console.WriteLine($"V2 customer: {v2.Name} (loyalty: {v2.LoyaltyPoints})");
        Console.WriteLine("The compiler distinguishes them by namespace (V1 vs V2).");
    }
}

internal static class UsingDirectiveDemo
{
    public static void Run()
    {
        Console.WriteLine("The 'using' directive avoids typing long fully‑qualified names.");
        Console.WriteLine("In this file we use type aliases CustomerV1 / CustomerV2 defined at the top.");
        Console.WriteLine("Without them we would write NamespacePlayground.PublicApi.Customers.V1.Customer, etc.");
    }
}

internal static class AvoidDeepNestingDemo
{
    public static void Run()
    {
        Console.WriteLine("Deep namespace nesting hurts readability.");
        Console.WriteLine("We keep namespaces at ~3–4 levels: NamespacePlayground.PublicApi.Customers.V1");
        Console.WriteLine("Avoid names like Company.Product.Feature.Area.SubArea.Detail.Something.");
    }
}

internal static class NamingConventionsDemo
{
    public static void Run()
    {
        Console.WriteLine("Namespaces should follow PascalCase and mirror logical areas.");
        Console.WriteLine("Good: NamespacePlayground.PublicApi, NamespacePlayground.Internal.Customers");
        Console.WriteLine("Bad: namespace helpers or namespace mycompany_utils (generic / inconsistent).");
    }
}

internal static class OrganizedByFeatureDemo
{
    public static void Run()
    {
        Console.WriteLine("We organize namespaces by *feature*.");
        Console.WriteLine("PublicApi.Customers contains the customer contract used by callers.");
        Console.WriteLine("Internal.Customers.Repositories contains the storage implementation.");
        Console.WriteLine("This makes large solutions easier to navigate (rule 6, 12, 16).");
    }
}

internal static class ScopeAndCollisionsDemo
{
    public static void Run()
    {
        Console.WriteLine("Namespaces control scope and prevent naming collisions (rule 7).");
        Console.WriteLine("We can safely have an 'Customer' type in multiple namespaces (V1, V2, Internal).");
        Console.WriteLine("Code chooses the right one via using directives or fully‑qualified names.");
    }
}

internal static class GlobalUsingsDemo
{
    public static void Run()
    {
        Console.WriteLine("Global usings (C# 10+) let you declare common usings once for the entire project.");
        Console.WriteLine("Open GlobalUsings.cs to see global using System; and others.");
        Console.WriteLine("In .NET 6+ many BCL namespaces are added automatically via ImplicitUsings.");
    }
}

internal static class DocumentNamespacesDemo
{
    public static void Run()
    {
        Console.WriteLine("You can document namespaces in a few ways:");
        Console.WriteLine(" - XML documentation files (for public APIs).");
        Console.WriteLine(" - README / architecture docs describing namespace layout.");
        Console.WriteLine(" - Comments at the top of key files explaining their role.");
    }
}

internal static class RefactorNamespacesDemo
{
    public static void Run()
    {
        Console.WriteLine("As the project evolves, review namespace layout (rules 10 & 20).");
        Console.WriteLine("For example, if a feature grows, split it into sub‑namespaces:");
        Console.WriteLine("  NamespacePlayground.PublicApi.Customers -> .V1, .V2");
        Console.WriteLine("Use IDE refactoring tools to move types safely.");
    }
}

internal static class PublicVsInternalDemo
{
    public static void Run()
    {
        Console.WriteLine("Namespaces can separate public API from internal implementation (rules 14 & 18).");
        Console.WriteLine("PublicApi.* namespaces expose contracts to consumers.");
        Console.WriteLine("Internal.* namespaces hide repositories and infrastructure details.");

        var customer = new CustomerV1("Bob");
        var repo = new InternalRepo();
        repo.Save(customer);

        Console.WriteLine("Callers reference only PublicApi.* while infrastructure uses Internal.*.");
    }
}

internal static class ImpactOfChangesDemo
{
    public static void Run()
    {
        Console.WriteLine("Changing a namespace is a *breaking* change for consumers (rule 15).");
        Console.WriteLine("PublicApi namespaces are part of your public surface: rename with care.");
        Console.WriteLine("Internal namespaces can change more freely, but still prefer automated refactors.");
    }
}

internal static class AvoidGenericNamesDemo
{
    public static void Run()
    {
        Console.WriteLine("Avoid generic or meaningless namespace names (rule 17).");
        Console.WriteLine("Bad: Common, Utils, Helper, Misc, Stuff.");
        Console.WriteLine("Better: Logging, Billing, Customers, Provisioning, etc.");
    }
}

internal static class ReadabilityMaintainabilityDemo
{
    public static void Run()
    {
        Console.WriteLine("A clear namespace strategy makes the whole codebase easier to read and maintain (rule 19).");
        Console.WriteLine("When a new dev opens the solution, the namespace names should tell a story.");
    }
}
