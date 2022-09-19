using Microsoft.EntityFrameworkCore;
using ProjetoAgendamento.Data.Context;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Repository
{	 
	public class FuncionarioRepository : IFuncionarioRepository
	{

        protected readonly ContextDB _context;
        protected readonly DbSet<Funcionario> _dataSet;

        public FuncionarioRepository(ContextDB context) {
            _context = context;
            _dataSet = _context.Set<Funcionario>();
        }
            
        public async Task<bool> DeleteAsync(Guid id) {
            try {
                var result = await _dataSet.SingleOrDefaultAsync(x => x.FuncionarioId.Equals(id));
                if (result is null) return false;

                _dataSet.Remove(result);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw ex;
            }
            return true;
        }

        public async Task<Funcionario> InsertAsync(Funcionario item) {
            try {
                if (item.FuncionarioId == Guid.Empty)
                    item.FuncionarioId = Guid.NewGuid();

                item.CreateAt = DateTime.Now;
                _dataSet.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw ex;
            }
            return item;
        }

        public async Task<bool> ExistAsync(Guid id) {
            return await _dataSet.AnyAsync(x => x.FuncionarioId.Equals(id));
        }

        public async Task<Funcionario> SelectAsync(Guid id) {
            try {
                return await _dataSet.SingleOrDefaultAsync(x => x.FuncionarioId.Equals(id));
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public async Task<IEnumerable<Funcionario>> SelectAsync() {
            try {
                return await _dataSet.ToListAsync();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public async Task<Funcionario> UpdateAsync(Funcionario item) {
            try {
                var result = await _dataSet.SingleOrDefaultAsync(x => x.FuncionarioId.Equals(item.FuncionarioId));
                if (result is null) return null;

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = result.CreateAt;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw ex;
            }
            return item;
        }
	}
}
