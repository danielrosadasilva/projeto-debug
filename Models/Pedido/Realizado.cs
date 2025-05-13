namespace projeto_debug.Models.Pedido;

using projeto_debug.Interfaces.IPedido;

public class Realizado : IPedido
{
    public void Preparar(Pedido pedido)
    {
        Console.WriteLine("seu pedido está sendo preparado");
        pedido.StatePedido = new Preparando();
    }

    public void IniciarEntrega(Pedido pedido)
    {
        throw new Exception("Pedido ainda não foi preparado");
    }

    public void FinalizarEntrega(Pedido pedido)
    {
        throw new Exception("Pedido ainda não foi preparado");
    }
}