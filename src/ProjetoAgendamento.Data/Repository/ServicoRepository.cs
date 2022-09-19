using Microsoft.EntityFrameworkCore;
using ProjetoAgendamento.Data.Context;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.Entitites;


namespace ProjetoAgendamento.Data.Repository
{	 
	public class ServicoRepository : IServicoRepository
	{

		protected readonly ContextDB _context;
		protected readonly DbSet<Servico> _dataSet;

		public ServicoRepository(ContextDB context) {
			_context = context;
			_dataSet = _context.Set<Servico>();
		}

        public async Task<bool> DeleteAsync(Guid id) {
            try {
                var result = await _dataSet.SingleOrDefaultAsync(x => x.ServicoId.Equals(id));
                if (result is null) return false;

                _dataSet.Remove(result);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw ex;
            }
            return true;
        }

        public async Task<Servico> InsertAsync(Servico item) {
            try {
                if (item.ServicoId == Guid.Empty)
                    item.ServicoId = Guid.NewGuid();

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
            return await _dataSet.AnyAsync(x => x.ServicoId.Equals(id));
        }

        public async Task<Servico> SelectAsync(Guid id) {
            try {
                return await _dataSet.SingleOrDefaultAsync(x => x.ServicoId.Equals(id));
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public async Task<IEnumerable<Servico>> SelectAsync() {
            try {
                return await _dataSet.ToListAsync();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public async Task<Servico> UpdateAsync(Servico item) {
            try {
                var result = await _dataSet.SingleOrDefaultAsync(x => x.ServicoId.Equals(item.ServicoId));
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
