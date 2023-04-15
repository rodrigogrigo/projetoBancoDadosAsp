using Microsoft.EntityFrameworkCore;
using PrimeiroProjetoBanco.Data;

namespace PrimeiroProjetoBanco.Models.Interfaces
{
    public interface IPessoa
    {
        List<Pessoa> ObterTodasPessoasEF();
        List<Pessoa> ObterTodasPessoas();
        int InserirPessoa(Pessoa pessoa, AppDbContext appDbContext);
    }
}
