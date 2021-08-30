using GraphQL.Types;
using System;

namespace GraphQLNet5.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IServiceProvider provider)
            : base(provider)
        {
        }
    }
}
