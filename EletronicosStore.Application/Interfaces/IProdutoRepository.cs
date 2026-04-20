using EletronicosStore.Domain.Entities;

namespace EletronicosStore.Application.Interfaces;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> GetAllAsync();
    Task<Produto?> GetByIdAsync(int id);
    Task AddAsync(Produto produto);
    void Update(Produto produto);
    void Delete(Produto produto);
    Task SaveChangesAsync(); 
}