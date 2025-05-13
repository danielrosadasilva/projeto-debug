// See https://aka.ms/new-console-template for more information
using projeto_debug.Models.Pedido;

Pedido pedido = new();

pedido.StatePedido.Preparar(pedido);
pedido.StatePedido.IniciarEntrega(pedido);
pedido.StatePedido.FinalizarEntrega(pedido);

