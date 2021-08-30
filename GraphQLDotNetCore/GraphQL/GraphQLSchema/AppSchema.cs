using GraphQL.Types;
using GraphQLNet5.GraphQL.GraphQLQueries;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GraphQLNet5.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<AppQuery>();
        }
    }
}
