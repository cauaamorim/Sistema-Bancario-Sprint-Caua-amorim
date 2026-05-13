using Sistema_bancario_Sprint.models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sistema_bancario_Sprint.Services;

public interface IContaService
{
    Task<Conta?> GetByIdAsync(int id);
    Task<IEnumerable<Conta>> GetAllAsync();
    Task<Conta> CreateAsync(Conta conta);
    Task<bool> DepositAsync(int contaId, double valor);
    Task<bool> WithdrawAsync(int contaId, double valor);
}
