namespace EletronicosStore.Domain.Entities;

public class ItemPedido
{
    public int Id { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; } 

    public int PedidoId { get; set; }
    public virtual Pedido Pedido { get; set; } = null!;

    public int ProdutoId { get; set; }
    public virtual Produto Produto { get; set; } = null!;
}