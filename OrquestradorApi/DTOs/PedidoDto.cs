namespace OrquestradorApi.DTOs;

public class PedidoDto
{
    public string ClienteId { get; set; }
    public List<ItemDoPedidoDto> Itens { get; set; }
    public DadosPagamentoDto DadosPagamento { get; set; }
}

public class ItemDoPedidoDto
{
    public int ProdutoId { get; set; }
    public int Quantidade { get; set; }
}

public class DadosPagamentoDto
{
    public string NumeroCartao { get; set; }
    public string NomeTitular { get; set; }
    public string DataValidade { get; set; }
    public string CodigoSeguranca { get; set; }
}
