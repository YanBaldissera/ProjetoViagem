using API_Viagem.Data;
using API_Viagem.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
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
        if(_dbContext is null) return NotFound();
        if(_dbContext.Cliente is null) return NotFound();
        _dbContext.Add(cliente);
        _dbContext.SaveChanges();
        return Created("", cliente);
    }

    [HttpGet]
    [Route("loginUsuario")]
    public async Task<ActionResult<Cliente>> LoginUsuario([FromQuery] string nomeUsuario, [FromQuery] string senhaUsuario) // FromQuery recebe a solicitação da URL da string
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Cliente is null) return NotFound();
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
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hospedagem is null) return NotFound();
        _dbContext.Add(hospedagem);
        _dbContext.SaveChanges();
        return Created("", hospedagem);
    }

    [HttpGet]
    [Route("listaHospedagem")]
    public async Task<ActionResult<IEnumerable<Hospedagem>>> ListarHospedagem()
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hospedagem is null) return NotFound();
        var validação = await _dbContext.Hospedagem.Where(h => h.Status != "inválido").ToListAsync();
        return validação;
    }

    [HttpPatch]
    [Route("mudarStatus/{status}")]
    public async Task<ActionResult> MudarStatus(string cnpj, [FromQuery] string status)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hospedagem is null) return NotFound();
        var hospedagemTemp = await _dbContext.Hospedagem.FindAsync(cnpj);
        if (hospedagemTemp is null) return NotFound();
        hospedagemTemp.Status = status;
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

}
