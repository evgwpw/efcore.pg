namespace Microsoft.EntityFrameworkCore.Scaffolding.Internal
{
    public class NpgsqlScaffoldingCodeGenerator : IScaffoldingProviderCodeGenerator
    {
        public virtual string GenerateUseProvider(string connectionString, string language)
            => $".{nameof(NpgsqlDbContextOptionsExtensions.UseNpgsql)}" + "(System.Configuration.ConfigurationManager.ConnectionStrings[\"ConnectionString\"].ConnectionString)";
            /**language == "CSharp"
                ? $".{nameof(NpgsqlDbContextOptionsExtensions.UseNpgsql)}({GenerateVerbatimStringLiteral(connectionString)})"
                : null;*/

        static string GenerateVerbatimStringLiteral(string value) => "@\"" + value.Replace("\"", "\"\"") + "\"";
    }
}
