using api_miviajecr.Services.ServicioUsuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using api_miviajecr.Models;

namespace api_miviajecr.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost("api/registrarUsuario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RegistrarUsuario([FromBody] Usuario usuario)
        {
            if (usuario==null)
            {
                return BadRequest();
            }

            return Ok(await _usuarioRepositorio.InsertaUsuario(usuario));
        }
    }
}
