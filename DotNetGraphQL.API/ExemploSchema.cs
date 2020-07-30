using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotNetGraphQL.API
{
    public class ExemploSchema : Schema
    {
        public ExemploSchema(IServiceProvider serviceProvider)
        : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<ExemploQuery>();
            Mutation = serviceProvider.GetRequiredService<ExemploMutation>();
        }
    }
}