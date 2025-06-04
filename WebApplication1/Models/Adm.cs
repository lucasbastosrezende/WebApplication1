using System.Numerics;

namespace WebApplication1.Models
{
    public class Adm
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        private char[] Senha { get; set; }
    }
}
