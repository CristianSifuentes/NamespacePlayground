namespace NamespacePlayground;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("""
====================================================
   C# Namespace Best Practices (20 Rules Demo)
   Targeting modern C# (C# 12+/14 preview) and .NET 8
====================================================
This console app walks through 20 best‑practice rules
for namespaces in C#, with small demos for each rule.
""");

        DemoRunner.RunAll();

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
