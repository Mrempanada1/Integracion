using Integracion.Models;
using Microsoft.AspNetCore.Mvc;

namespace Integracion.Controllers
        
{
    [ApiController]
    [Route("[cliente]")]
    public class CLienteController: ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            // Listar clientes

            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id = "1",
                    nombre = "Tama",
                    descripcion = "bateria tama",
                    categoria = "Percusion",
                    precio = "250000",
                    stock = "12"
                }
            };
            return clientes;
        }
        [HttpPatch]
        [Route("modificar")]
        public dynamic modificarCliente()
        {
            return new
            {

            };
        }
        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente()
        {
            return new
            {

            };

        }
        [HttpPut]
        [Route("actualizar")]
        public dynamic actualizarCliente()
        {
            return new
            {

            };
        }
        [HttpDelete]
        [Route("Eliminar")]
        public dynamic eliminarCliente()
        {
            return new
            {

            };
        }

    }
}
