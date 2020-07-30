using DotNetGraphQL.Infra;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class ExemploQuery : ObjectGraphType<object>
    {
        public ExemploQuery(UsuarioRepositorio repositorio)
        {
            Field<ListGraphType<UsuarioType>>("usuario",
                arguments: new QueryArguments(new QueryArgument[]
                {
                    new QueryArgument<IdGraphType>{Name="id"},
                    new QueryArgument<StringGraphType>{Name="nome"}
                }),
                resolve: contexto =>
                {
                    var filtro = new UsuarioFiltro()
                    {
                        Id = contexto.GetArgument<int>("id"),
                        Nome = contexto.GetArgument<string>("nome"),
                    };

                    return repositorio.OnObterUsuarios(filtro);
                }

                );
        }
    }
}