using System.Collections.Generic;
using StageCalculator.Context;
using System.Data.Entity;
using StageCalculator.Interface;

namespace StageCalculator.Repositories
{
    public class BaseOperation: IGenericRepository
    {
        private readonly StageEntity _context;
        public BaseOperation()
        {
            _context = new StageEntity();
            
        }
        public T GetById<T>(int IdParam) where T : class
        {
            var entry = _context.Set<T>().Find(IdParam);
            return entry;
        }
        public IEnumerable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Add<T>(T entry) where T : class
        {
            _context.Set<T>().Add(entry);
        }

        public void Remove<T>(T entry) where T : class
        {
            _context.Entry(entry).State = EntityState.Deleted;
        }

        public void Update<T>(T entry) where T : class
        {
            _context.Entry(entry).State = EntityState.Modified;
        }


        public void Save()
        {
            _context.SaveChanges();
            
        }

    }
}
