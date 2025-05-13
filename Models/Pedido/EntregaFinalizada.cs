using projeto_debug.Interfaces.IPedido;

namespace projeto_debug.Models.Pedido;

public class EntregaFinalizada : IPedido
{
    public void FinalizarEntrega(Pedido pedido)
    {
        Console.WriteLine("Pedido já foi entregue");
        throw new Exception("Pedido já foi entregue");
    }

    public void IniciarEntrega(Pedido pedido)
    {
         throw new Exception("Pedido já foi entregue");
    }

    public void Preparar(Pedido pedido)
    {
         throw new Exception("Pedido já foi entregue");
    }
}