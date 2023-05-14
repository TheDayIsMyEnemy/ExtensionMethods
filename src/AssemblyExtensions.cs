using System.Reflection;

namespace ExtensionMethods
{
    public static class AssemblyExtensions
    {
        public static string? ShortName(this Assembly? assembly) =>
            assembly?.GetName()?.Name?.Split(", ").FirstOrDefault();
    }
}
