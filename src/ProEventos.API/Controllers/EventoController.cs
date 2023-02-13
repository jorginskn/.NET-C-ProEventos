using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento[]{
          new Evento(){
            EventoId = 1 ,
            Tema = "Angular 11 e DOTNET 5",
            Local = "Brasília DF",
            Lote = "Primeiro Lote",
            QtdPessoas  = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.jpg"
          },
           new Evento(){
            EventoId = 2 ,
            Tema = "C# 11 e DOTNET 5",
            Local = "SP ",
            Lote = "Segundo Lote",
            QtdPessoas  = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.jpg"
          }
    };

    public EventoController()
    {
    }

    [HttpGet]

    public IEnumerable<Evento> Get()
    {
        return _evento;
    }
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetEventById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]

    public string InserirItem()
    {
        return "Exemplo";
    }


    [HttpPut("{id}")]

    public string Put(int id)
    {
        return $"Exemplo de put com id = {id}";
    }


    [HttpDelete("{id}")]

    public string Deletado(int id)
    {
        return $"Evento deletado  {id}";
    }

}
