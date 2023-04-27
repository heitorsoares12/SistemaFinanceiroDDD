using Domain.Interfaces.Generics;
using Entities.Entidades;

namespace Domain.Interfaces.IUsuarioSistemaFinanceiro;

public interface InterfaceUsuarioSistemaFinanceiro : InterfaceGeneric<UsuarioSistemaFinanceiro>
{
    Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int IdSistema);

    Task RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios);

    Task<IList<UsuarioSistemaFinanceiro>> ObterUsuarioPorEmail(string emailUsuario);
}