using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Glyfada.Standard;


namespace R5T.Southampton.Glyfada.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddGitSourceControlOperator(this IServiceCollection services)
        {
            services
                .AddSingleton<ISourceControlOperator, GitSourceControlOperator>()
                .AddGitOperator()
                ;

            return services;
        }
    }
}
