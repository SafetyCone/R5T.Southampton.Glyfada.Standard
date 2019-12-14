using System;

using Microsoft.Extensions.Configuration;

using R5T.Glyfada.Standard;


namespace R5T.Southampton.Glyfada.Standard
{
    public static class IConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddGitSourceControlOperatorConfiguration(this IConfigurationBuilder configurationBuilder, IServiceProvider configurationServiceProvider)
        {
            configurationBuilder
                .AddGitConfiguration(configurationServiceProvider)
                ;

            return configurationBuilder;
        }
    }
}
