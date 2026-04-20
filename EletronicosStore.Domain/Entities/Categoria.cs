namespace EletronicosStore.Domain.Entities;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}