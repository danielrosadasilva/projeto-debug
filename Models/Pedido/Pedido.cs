using projeto_debug.Interfaces.IPedido;

namespace projeto_debug.Models.Pedido;
public class Pedido
{
    public Pedido()
    {
        StatePedido = new Realizado();
    }
    public IPedido StatePedido { get; set; }

}