namespace WebApplication1.Models
{
    public class ItemImpressao
    {
        public int Id { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int ImpressaoId { get; set; }
        public Impressao Impressao { get; set; }

        public int ArquivoPaginaId { get; set; }
        public SelectedPage selectedPage { get; set; }

        public int Quantidade { get; set; }

        public decimal ValorTotal()
        {
            var resultado = Quantidade * Impressao.Valor;

            return resultado;
        }
        
    }
}
