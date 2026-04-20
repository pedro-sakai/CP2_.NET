namespace EletronicosStore.Domain.Entities;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public int Estoque { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; } = null!;

    public virtual ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();
}