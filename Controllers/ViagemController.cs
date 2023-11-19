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
    [Route("mudarStatusHospedagem/{status}")]
    public async Task<ActionResult> MudarStatusHospedagem(string cnpj, [FromQuery] string status)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hospedagem is null) return NotFound();
        var hospedagemTemp = await _dbContext.Hospedagem.FindAsync(cnpj);
        if (hospedagemTemp is null) return NotFound();
        hospedagemTemp.Status = status;
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpPost()]
    [Route("CadastrarPaises")]
    public IActionResult CadastrarPaises(Paises paises)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Paises is null) return NotFound();
        _dbContext.Add(paises);
        _dbContext.SaveChanges();
        return Created("", paises);
    }

    [HttpGet]
    [Route("listaPaises")]
    public async Task<ActionResult<IEnumerable<Paises>>> ListarPaises()
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Paises is null) return NotFound();
        var validação = await _dbContext.Paises.ToListAsync();
        return validação;
    }

    [HttpPost()]
    [Route("CadastrarCidades")]
    public IActionResult CadastrarCidades(Cidades cidades)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Cidades is null) return NotFound();
        _dbContext.Add(cidades);
        _dbContext.SaveChanges();
        return Created("", cidades);
    }

    [HttpGet]
    [Route("listaCidades")]
    public async Task<ActionResult<IEnumerable<Cidades>>> ListarCidades()
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Cidades is null) return NotFound();
        var validação = await _dbContext.Cidades.ToListAsync();
        return validação;
    }

    [HttpPost()]
    [Route("CadastrarCompanhia")]
    public IActionResult CadastrarCompanhia(Companhia companhia)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Companhia is null) return NotFound();
        _dbContext.Add(companhia);
        _dbContext.SaveChanges();
        return Created("", companhia);
    }

    [HttpGet]
    [Route("listaCompanhia")]
    public async Task<ActionResult<IEnumerable<Companhia>>> ListarCompanhia()
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Companhia is null) return NotFound();
        var validação = await _dbContext.Companhia.ToListAsync();
        return validação;
    }

    [HttpPost()]
    [Route("CadastrarPassagem")]
    public IActionResult CadastrarPassagem(Passagem passagem)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Passagem is null) return NotFound();
        _dbContext.Add(passagem);
        _dbContext.SaveChanges();
        return Created("", passagem);
    }
    [HttpGet]
    [Route("listaPassagem")]
    public async Task<ActionResult<IEnumerable<Passagem>>> ListarPassagem()
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Passagem is null) return NotFound();
        var validação = await _dbContext.Passagem.ToListAsync();
        return validação;
    }

    [HttpPost()]
    [Route("CadastrarGuiaTuristico")]
    public IActionResult CadastrarGuiaTuristico(GuiaTuristico guia)
    {
        if (_dbContext is null) return NotFound();
        if (guia is null) return BadRequest("Dados do Guia Turístico inválidos");

        _dbContext.Add(guia);
        _dbContext.SaveChanges();
        return Created("", guia);
    }

    [HttpGet]
    [Route("listaGuiasTuristicos")]
    public async Task<ActionResult<IEnumerable<GuiaTuristico>>> ListarGuiasTuristicos()
    {
        if (_dbContext is null) return NotFound();
        var guias = await _dbContext.GuiaTuristico.Where(g => g.Status != "inválido").ToListAsync();
        return guias;
    }

    [HttpPatch]
    [Route("AlterarStatusGuia/{status}")]
    public async Task<ActionResult> AlterarStatusGuia(int DocumentoGuia, [FromQuery] string Status)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.GuiaTuristico is null) return NotFound();
        var GuiaTuristicoTemp = await _dbContext.GuiaTuristico.FindAsync(DocumentoGuia);
        if (GuiaTuristicoTemp is null) return NotFound();
        GuiaTuristicoTemp.Status = Status;
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpPost]
    [Route("CadastrarCarros")]
        public async Task<ActionResult<CarroAluguel>> CadastrarCarro(CarroAluguel carro)
        {
            if (_dbContext is null) return NotFound();
            if (carro is null) return BadRequest("Dados do Guia Turístico inválidos");
            _dbContext.Add(carro);
            await _dbContext.SaveChangesAsync();
            return Created("", carro);
        }

        // Método GET para listar carros disponíveis
    [HttpGet]
    [Route("ListarCarros")]
        public async Task<ActionResult<IEnumerable<CarroAluguel>>> ListarCarrosDisponiveis()
        {
            var carrosDisponiveis = await _dbContext.CarrosAluguel
                .Where(c => c.Disponivel == "Disponível")
                .ToListAsync();

            if (carrosDisponiveis == null || carrosDisponiveis.Count == 0)
            {
                return NotFound();
            }

            return carrosDisponiveis;
        }

        // Método PATCH para alterar o status de disponibilidade de um carro
    [HttpPatch]
    [Route("AlterarStatusCarro/{status}")]
        public async Task<IActionResult> AlterarStatusCarro(string Placa, [FromQuery] string NovoStatus)
        {
            var carro = await _dbContext.CarrosAluguel.FirstOrDefaultAsync(c => c.Placa == Placa);

            if (carro == null)
            {
                return NotFound();
            }

            carro.Disponivel = NovoStatus;
            await _dbContext.SaveChangesAsync();
            return Ok();
        }



}
