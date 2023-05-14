using System.Reflection;

namespace ExtensionMethods
{
    public static class TypeExtensions
    {
        public static object GetDefault(this Type t)
        {
            var defaultValue = typeof(TypeExtensions)!
                .GetRuntimeMethod(nameof(GetDefaultGeneric), Array.Empty<Type>())!
                .MakeGenericMethod(t)
                .Invoke(null, null);

            return defaultValue!;
        }

        public static T? GetDefaultGeneric<T>() => default;
    }
}
