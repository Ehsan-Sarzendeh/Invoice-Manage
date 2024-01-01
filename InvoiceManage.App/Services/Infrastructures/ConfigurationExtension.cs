using InvoiceManage.App.Forms.Common;

namespace InvoiceManage.App.Services.Infrastructures
{
    public static class ConfigurationExtension
    {
        public static Mode? GetMode(this string input, int type, int pattern)
        {
            var a = Program.Configuration
                .GetSection("StepsConfigurations");

            var b = Program.Configuration
                .GetSection("StepsConfigurations")
                .GetSection(input);

            var paramOption = Program.Configuration
                .GetSection("StepsConfigurations")
                .GetSection(input)[$"{type}{pattern}"];

            return paramOption switch
            {
                "M" => Mode.Required,
                "MC" => Mode.SemiRequired,
                "A" => Mode.Optional,
                "I" => Mode.Ignore,
                _ => null
            };
        }
    }
}