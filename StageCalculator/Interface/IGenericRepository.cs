using System.Collections.Generic;

namespace StageCalculator.Interface
{
    interface IGenericRepository
    {
        T GetById<T>(int IdParam) where T : class;
        IEnumerable<T> GetAll<T>() where T : class;
        void Add<T>(T entry) where T : class;
        void Remove<T>(T entry) where T : class;
        void Update<T>(T entry) where T : class;
        void Save();
    }
}
