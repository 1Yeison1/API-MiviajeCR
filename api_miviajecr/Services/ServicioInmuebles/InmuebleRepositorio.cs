using api_miviajecr.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_miviajecr.Services.ServicioInmueble
{
    public class InmuebleRepositorio : IInmuebleRepositorio
    {
        private readonly tiusr27pl_ApimisviajescrContext _dbContext;

        public InmuebleRepositorio(tiusr27pl_ApimisviajescrContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Inmueble>> ObtenerInmuebles()
        {
            return await _dbContext.Inmuebles.ToListAsync();
        }

        public async Task<int> InsertarInmueble(Inmueble inmueble)
        {
            if (inmueble != null)
            {
                // Puedes ajustar aquí para incluir solo los campos que deseas
                var inmuebleSimplificado = new
                {
                    inmueble.IdInmueble,
                    inmueble.IdUsuario,
                    inmueble.IdTipoInmueble,
                    inmueble.TituloInmueble,
                    inmueble.DescripcionInmuebles,
                    inmueble.PrecioPorNoche,
                    inmueble.PromedioCalificacion,
                    inmueble.EstaActivo,
                    inmueble.FechaCreacion
                };

                _dbContext.Inmuebles.Add(inmueble);
                return await _dbContext.SaveChangesAsync();
            }
            else
            {
                return -1;
            }
        }
    }
}
