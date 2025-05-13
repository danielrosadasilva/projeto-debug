using projeto_debug.Interfaces.IPedido;

namespace projeto_debug.Models.Pedido;

public class EntregaIniciada : IPedido
{
    public void FinalizarEntrega(Pedido pedido)
    {
        Console.WriteLine("Entrega finalizada");
        pedido.StatePedido = new EntregaFinalizada();
    }

    public void IniciarEntrega(Pedido pedido)
    {
        throw new Exception("Pedido já saiu para entrega");
    }

    public void Preparar(Pedido pedido)
    {
        throw new Exception("Pedido já saiu pra entrega");
    }
}