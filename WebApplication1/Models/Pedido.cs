namespace WebApplication1.Models
{
    public class Pedido
    {
        public int Id{ get; set; }
        public DateTime Data { get; set; }
        public decimal ValorTotal { get; set; }
        public string Status { get; set; }
        public string FormaPagamento { get; set; }

        public List<ItemImpressao> itens { get; set; } = new();
    }
}
