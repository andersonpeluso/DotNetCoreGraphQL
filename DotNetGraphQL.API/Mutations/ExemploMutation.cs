using DotNetGraphQL.Infra;
using GraphQL;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class ExemploMutation : ObjectGraphType<object>
    {
        public ExemploMutation(UsuarioRepositorio repositorio)
        {
            Name = "Mutation";
            Field<UsuarioType>("criarUsuario",
                arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<UsuarioInputType>> { Name = "usuario" }
                ),
                resolve: context =>
                {
                    var usuario = context.GetArgument<Usuario>("usuario");
                    return repositorio.OnAdicionar(usuario);
                });

            Field<UsuarioType>("alterarUsuario",
                arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<UsuarioInputType>> { Name = "usuario" },
                new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "usuarioId" }
                ),
                resolve: context =>
                {
                    var usuario = context.GetArgument<Usuario>("usuario");
                    var id = context.GetArgument<int>("usuarioId");
                    var dbUsuario = repositorio.OnObterUsuarioPorId(id);

                    if (dbUsuario is null)
                    {
                        context.Errors.Add(new ExecutionError("Não foi possivel encontrar usuário na base de dados."));
                        return null;
                    }
                    return repositorio.OnAlterar(dbUsuario, usuario);
                });

            Field<StringGraphType>("removerUsuario",
                arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "usuarioId" }
                ),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("usuarioId");
                    var dbUsuario = repositorio.OnObterUsuarioPorId(id);

                    if (dbUsuario is null)
                    {
                        context.Errors.Add(new ExecutionError("Não foi possivel encontrar usuário na base de dados."));
                        return null;
                    }
                    repositorio.OnRemover(dbUsuario);
                    return $"O usuario com id {id} foi removido";
                });
        }
    }
}