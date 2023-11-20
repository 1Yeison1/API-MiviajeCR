using api_miviajecr.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_miviajecr.Services.ServicioFavoritos
{
    public interface IFavoritoRepositorio
    {
        Task<List<Favorito>> ObtenerFavoritos();
    }
}
