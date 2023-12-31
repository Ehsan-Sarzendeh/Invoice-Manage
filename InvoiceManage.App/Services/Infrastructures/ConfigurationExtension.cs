using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Services.Infrastructures
{
    public static class ConfigurationExtension
    {
        public static ParamType? GetParamType(this string section, string input, int type, int pattern)
        {
            var paramOption = Program.Configuration
                .GetSection("StepsConfigurations")
                .GetSection(section)
                .GetSection(input)[$"{type}{pattern}"];

            return paramOption switch
            {
                "M" => ParamType.Required,
                "MC" => ParamType.SemiRequired,
                "A" => ParamType.Optional,
                "I" => ParamType.Ignore,
                _ => null
            };
        }
    }
}