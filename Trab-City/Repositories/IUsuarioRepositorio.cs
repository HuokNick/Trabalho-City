using Trab_City.Models;

namespace Trab_City.Repositories
{
 

    public interface IUsuarioRepositorio
    {

        Task<bool> Cadastrar(UsuarioModel usuario, string senhaPura);

        Task<UsuarioModel?> BuscarEmail(string email);
    }
}

