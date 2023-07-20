
using APImoeda.Models;
using AutoMapper;
using ConvertendoMoeda.Data;
using ConvertendoMoeda.Data.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ConvertendoMoeda.Controllers;

[ApiController]
[Route("[Controller]")]
public class MoedasController : ControllerBase
{
    private SistemaTarefasDBContext _context;
    private IMapper _mapper;

    public MoedasController(SistemaTarefasDBContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Adiciona um filme ao banco de dados
    /// </summary>
    /// <param name="moedaDto">Objeto com os campos necessários para criação de um filme</param>
    /// <returns>IActionResult</returns>
    /// <response code="201">Caso inserção seja feita com sucesso</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult AdicionarMoeda([FromBody] CreateMoedaDto moedaDto) //Retorna "201 created" quando o filme for criado.
    {
        MoedasModel moeda = _mapper.Map<MoedasModel>(moedaDto);
        _context.Moedas.Add(moeda);
        _context.SaveChanges();
        return CreatedAtAction(nameof(BuscarTodasAsMoedasPorID), new { id = moeda.Id }, moeda);
    }

    [HttpGet]

    public IEnumerable<ReadMoedaDto> BuscarTodasAsMoedas()
    {
        return _mapper.Map<List<ReadMoedaDto>>(_context.Moedas);
    }

    [HttpGet("{id}")]

    public IActionResult BuscarTodasAsMoedasPorID(int id) ////IActionResult me retorna o resultado da Busca. No exemplo abaixo, se o filme for = a nulo, vai retornar "Não encontrado"
    {
        var moeda = _context.Moedas.FirstOrDefault(moeda => moeda.Id == id);
        if (moeda == null) return NotFound();
        var moedaDto = _mapper.Map<ReadMoedaDto>(moeda);
        return Ok(moedaDto);
    }

    [HttpPut("{id}")]

    public IActionResult AtualizaMoeda(int id, [FromBody] UpdateMoedaDto moedaDto)
    {
        var moeda = _context.Moedas.FirstOrDefault(moeda => moeda.Id == id);
        if (moeda == null) return NotFound();
        _mapper.Map(moedaDto, moeda);
        _context.SaveChanges();
        return NoContent();
    }


    [HttpPatch("{id}")]
    public IActionResult AtualizaMoedaPATCH(int id, JsonPatchDocument<UpdateMoedaDto> patch)
    {
        var moeda = _context.Moedas.FirstOrDefault(moeda => moeda.Id == id);
        if (moeda == null) return NotFound();

        var MoedaParaAtualizar = _mapper.Map<UpdateMoedaDto>(moeda);

        patch.ApplyTo(MoedaParaAtualizar, ModelState);

        if (!TryValidateModel(MoedaParaAtualizar))
        {
            return ValidationProblem(ModelState);
        }
        _mapper.Map(MoedaParaAtualizar, moeda);
        _context.SaveChanges();
        return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult DeletarMoeda(int id)
    {
        var moeda = _context.Moedas.FirstOrDefault(moeda => moeda.Id == id);
        if (moeda == null) return NotFound();
        _context.Remove(moeda);
        _context.SaveChanges();
        return NoContent();
    }
}

