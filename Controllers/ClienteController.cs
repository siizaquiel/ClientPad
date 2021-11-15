using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClientePad.api.Models;

namespace ClientePad.api.Controllers
{
    
   [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private List<Cliente> _cliente;
        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;

            _cliente = new List<Cliente>();

            _cliente.Add(new Cliente(1, "Alan", "12345678901", new DateTime(1980, 6, 1), 1385.12, "M"));
            _cliente.Add(new Cliente(2, "Pedro", "12345678902", new DateTime(2009, 12, 2), 1200.00, "M"));
            _cliente.Add(new Cliente(3, "Alessandra", "12345678903", new DateTime(2002, 12, 6), 1300.00, "F"));
            _cliente.Add(new Cliente(4, "Gilmar", "12345678905", new DateTime(1998, 7, 3), 1200.00, "M"));
            _cliente.Add(new Cliente(5, "Vanessa", "12345678912", new DateTime(2000, 2, 9), 1400.00, "F"));
        
        }

        [HttpGet]
         public IActionResult Get()
        {
        return Ok(_cliente);
        } 



        [HttpGet("{id:int}")]
        public IActionResult GetbyId(int id)
        {
            var cliente = _cliente.Where(cl => cl.Id == id).FirstOrDefault();

            if (cliente == null)
            {
                return NotFound(new {message = "Cliente não encontrado!", id = id});
            }

            return Ok(cliente);
        }





       [HttpGet("{nome}")]
        public IActionResult GetbyNome(string nome)
        {
            var cliente = _cliente.Where(cl => cl.Nome == nome).FirstOrDefault();

            if (cliente == null)
            {
                return NotFound(new {message = "Cliente não encontrado!", nome = nome});
            }

            return Ok(cliente);
        }





    }
   

}