using projeto_debug.Interfaces.IPedido;

namespace projeto_debug.Models.Pedido;

public class Preparando : IPedido
{
    public void FinalizarEntrega(Pedido pedido)
    {
        throw new Exception("o pedido ainda está sendo preparado");
    }

    public void IniciarEntrega(Pedido pedido)
    {
        Console.WriteLine("Entrega iniciada");
        pedido.StatePedido = new EntregaIniciada();
    }

    public void Preparar(Pedido pedido)
    {
        throw new Exception("o pedido já está sendo preparado.");
    }
}