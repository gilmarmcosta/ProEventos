using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento() 
                {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1 Lote",
                QdtPessoas = 250,
                DataEvento = "18/11/2022",
                ImagemURL = "Foto.png"
                },
                new Evento() 
                {
                EventoId = 2,
                Tema = "Angular 11 e .NET 5 com Angular",
                Local = "Distrito Federal",
                Lote = "2 Lote",
                QdtPessoas = 350,
                DataEvento = "18/11/2022",
                ImagemURL = "Foto.png"
                }
            };
       
        [HttpGet]
        public IEnumerable<Evento> Get()
        {            
            return _evento; 
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {            
            return _evento.Where(evento => evento.EventoId == id); 
        }

        [HttpPost]
        public string Post()
        {            
            return "Exemplo de Metodo Post";
        }
        
        [HttpPut("{id}")]
        public string Put(int id)
        {            
            return $"Exemplo de Metodo Put com id = {id}";
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {            
            return $"Exemplo de Metodo Delete com id = {id}";
        }
    }
}
