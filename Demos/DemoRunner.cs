namespace NamespacePlayground;

using NamespacePlayground.Demos;

internal static class DemoRunner
{
    public static void RunAll()
    {
        var demos = new (string Title, Action Action)[]
        {
            ("1. Namespaces can be nested", NestedNamespacesDemo.Run),
            ("2. Classes in different namespaces can have the same name", SameNameDifferentNamespacesDemo.Run),
            ("3. Use the 'using' directive to simplify access to types in a namespace", UsingDirectiveDemo.Run),
            ("4 & 11. Avoid deep nesting of namespaces", AvoidDeepNestingDemo.Run),
            ("5 & 13. Follow & be consistent with naming conventions", NamingConventionsDemo.Run),
            ("6 & 12 & 16. Organize namespaces by feature / functionality", OrganizedByFeatureDemo.Run),
            ("7. Use namespaces to control scope & avoid collisions", ScopeAndCollisionsDemo.Run),
            ("8. Consider global usings in .NET 6+", GlobalUsingsDemo.Run),
            ("9. Document namespaces", DocumentNamespacesDemo.Run),
            ("10 & 20. Review and refactor namespaces over time", RefactorNamespacesDemo.Run),
            ("14 & 18. Separate public API from internal implementation", PublicVsInternalDemo.Run),
            ("15. Consider impact of namespace changes", ImpactOfChangesDemo.Run),
            ("17. Avoid generic namespace names", AvoidGenericNamesDemo.Run),
            ("19. Namespaces improve readability & maintainability", ReadabilityMaintainabilityDemo.Run)
        };

        var index = 1;
        foreach (var (title, action) in demos)
        {
            Console.WriteLine();
            Console.WriteLine($"--- Demo {index}: {title} ---");
            action();
            index++;
        }
    }
}
