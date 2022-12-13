using Microsoft.EntityFrameworkCore;
using ProjetoAgendamento.Data.Context;
using ProjetoAgendamento.Data.Interfaces;
using ProjetoAgendamento.Domain.Entitites;

namespace ProjetoAgendamento.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ContextDB _context;
        protected readonly DbSet<T> _dataSet;

        public BaseRepository(ContextDB context) {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public async Task<bool> DeleteAsync(Guid id) {
            try {
                var result = await _dataSet.SingleOrDefaultAsync(x => x.Id.Equals(id));
                if (result is null) return false;

                _dataSet.Remove(result);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw ex;
            }
            return true;
        }       

        public async Task<T> InsertAsync(T item) {
            try {
                if (item.Id == Guid.Empty)
                    item.Id = Guid.NewGuid();

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
            return await _dataSet.AnyAsync(x => x.Id.Equals(id));
        }

        public async Task<T> SelectAsync(Guid id) {
            try {
                return await _dataSet.SingleOrDefaultAsync(x => x.Id.Equals(id));
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync() {
            try {
                return await _dataSet.ToListAsync();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public async Task<T> UpdateAsync(T item) {
            try {
                var result = await _dataSet.SingleOrDefaultAsync(x => x.Id.Equals(item.Id));
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
