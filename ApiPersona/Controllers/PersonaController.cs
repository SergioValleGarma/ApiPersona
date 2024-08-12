using ApiPersona.Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPersona.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            List<Persona> list = new List<Persona>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(new Persona { id = i, Nombre = "Sergio" + i });
            }
            return list;
        }
    }
}
