namespace EletronicosStore.Domain.Entities;

public class Pedido
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
   
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
}