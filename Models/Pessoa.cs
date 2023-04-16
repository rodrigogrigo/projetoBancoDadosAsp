using PrimeiroProjetoBanco.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiroProjetoBanco.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("cep")]
        public string Cep { get; set; }

        [Column("referencia")]
        public string Referencia { get; set; }        
    }
}
