using EletronicosStore.Application.Interfaces;
using EletronicosStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EletronicosStore.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly IProdutoRepository _repository;

    public ProdutosController(IProdutoRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var produtos = await _repository.GetAllAsync();
        return Ok(produtos);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Produto produto)
    {
        await _repository.AddAsync(produto);
        await _repository.SaveChangesAsync();
        return Ok(produto);
    }
}