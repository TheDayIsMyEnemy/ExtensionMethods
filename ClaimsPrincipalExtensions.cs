using System.Security.Claims;

namespace ExtensionMethods
{
    public static class ClaimsPrincipalExtensions
    {
        public static string? GetId(this ClaimsPrincipal claimsPrincipal) =>
            claimsPrincipal?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        public static string? GetName(this ClaimsPrincipal claimsPrincipal) =>
            claimsPrincipal?.FindFirst(ClaimTypes.Name)?.Value;

        public static string? GetRole(this ClaimsPrincipal claimsPrincipal) =>
            claimsPrincipal?.FindFirst(ClaimTypes.Role)?.Value;
    }
}
