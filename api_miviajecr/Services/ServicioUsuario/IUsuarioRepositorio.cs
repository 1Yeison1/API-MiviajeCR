using System.Threading.Tasks;
using System;
using api_miviajecr.Models;

namespace api_miviajecr.Services.ServicioUsuario
{
    public interface IUsuarioRepositorio
    {
        //Definicion de los metodos,No tiene logica
        Task<int> InsertaUsuario(Usuario usuario);
    }
}
