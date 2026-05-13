using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Sistema_bancario_Sprint.Services;
using Sistema_bancario_Sprint.models;

namespace Sistema_bancario_Sprint.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContasController : ControllerBase
{
    private readonly IContaService _service;

    public ContasController(IContaService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var contas = await _service.GetAllAsync();
        return Ok(contas);
    }

    [HttpGet("{id}")]
    [Authorize]
    public async Task<IActionResult> GetById(int id)
    {
        // Ensure the caller is the owner of the account
        var claimId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (!int.TryParse(claimId, out var ownerId) || ownerId != id)
            return Forbid();

        var conta = await _service.GetByIdAsync(id);
        if (conta == null) return NotFound();

        var result = new {
            id = conta.Id,
            nome = conta.Nome,
            email = conta.Email,
            saldo = conta.Saldo,
            tipo = conta.GetType().Name
        };

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Conta conta)
    {
        var created = await _service.CreateAsync(conta);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }
}
