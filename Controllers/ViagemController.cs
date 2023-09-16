using API_Viagem.Data;
using API_Viagem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace API_Viagem.Controllers;

[ApiController]
[Route("[Controller]")]
public class ViagemController : ControllerBase
{
    private ViagemDbContext _dbContext;

    public ViagemController(ViagemDbContext dbContext)
    {
        _dbContext = dbContext;
    }


    [HttpPost()]
    [Route("CadastrarCliente")]
    public IActionResult CadastrarCliente(Cliente cliente)
    {
        _dbContext.Add(cliente);
        _dbContext.SaveChanges();
        return Created("", cliente);
    }

    [HttpPost()]
    [Route("CadastrarHospedagem")]
    public IActionResult CadastrarHospedagem(Hospedagem hospedagem)
    {
        _dbContext.Add(hospedagem);
        _dbContext.SaveChanges();
        return Created("", hospedagem);
    }
    [HttpGet]
    [Route("listaHospedagem")]
    public async Task<ActionResult<IEnumerable<Hospedagem>>> ListarHospedagem()
    {
        return await _dbContext.Hospedagem.ToListAsync();
    }
}
