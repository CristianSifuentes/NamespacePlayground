# NamespacePlayground

A small .NET 8 console app that demonstrates **20 best‑practice rules** for namespaces in modern C# (C# 12+/14 preview).

## How to run

```bash
cd NamespacePlayground
dotnet run
```

You'll see each demo printed to the console with explanations and links to the relevant code files.

Key files:
- `Program.cs` – entry point using a file‑scoped namespace.
- `GlobalUsings.cs` – sample of global using statements.
- `Demos/NamespaceDemos.cs` – one class per group of namespace rules.
- `PublicApi/*` – public API namespaces.
- `Internal/*` – internal implementation namespaces.
