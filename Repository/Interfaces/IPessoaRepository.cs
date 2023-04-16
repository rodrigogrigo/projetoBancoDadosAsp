using Microsoft.EntityFrameworkCore;
using PrimeiroProjetoBanco.Data;
using PrimeiroProjetoBanco.Models;

namespace PrimeiroProjetoBanco.Repository.Interfaces
{
    public interface IPessoaRepository
    {
        List<Pessoa> ObterTodasPessoasEF();
        List<Pessoa> ObterTodasPessoas();
        int InserirPessoa(Pessoa pessoa);
    }
}
