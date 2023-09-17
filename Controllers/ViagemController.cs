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
    [HttpGet]
    [Route("loginUsuario")]
    public async Task<ActionResult<Cliente>> LoginUsuario([FromQuery] string nomeUsuario, [FromQuery] string senhaUsuario) // FromQuery recebe a solicitação da URL da string
    {
        var cliente = await _dbContext.Cliente.SingleOrDefaultAsync(c => c.Nome == nomeUsuario);//sinlgeordefaultasync faz a consulta no banco de dados no banco de dados

        if (cliente == null)
        {
            return BadRequest("Nome de usuário não encontrado");
        }

        if (cliente.Senha != senhaUsuario)
        {
            return BadRequest("Senha incorreta");
        }

        return Ok("Login efetuado com sucesso!!");
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
