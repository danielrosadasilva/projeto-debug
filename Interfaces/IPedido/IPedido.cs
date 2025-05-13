using projeto_debug.Models.Pedido;

namespace projeto_debug.Interfaces.IPedido;

public interface IPedido
{
    public void Preparar(Pedido pedido);
    public void IniciarEntrega(Pedido pedido);
    public void FinalizarEntrega(Pedido pedido);
}