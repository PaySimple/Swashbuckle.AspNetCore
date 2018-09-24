using Newtonsoft.Json.Serialization;

namespace Swashbuckle.AspNetCore.SwaggerGen
{
    internal static class StringExtensions
    {
        private static readonly SnakeCaseNamingStrategy SnakeCaseStrategy = new SnakeCaseNamingStrategy();

        internal static string ToCamelCase(this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return char.ToLowerInvariant(value[0]) + value.Substring(1);
        }

        internal static string ToSnakeCase(this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return SnakeCaseStrategy.GetPropertyName(value, false);
        }

        internal static string ToTitleCase(this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return char.ToUpperInvariant(value[0]) + value.Substring(1);
        }
    }
}
