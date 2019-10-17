using StageCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StageCalculator.Models;

namespace StageCalculator.Service
{
    class PersonService 
    {
        private readonly IGenericRepository _repository;

        public PersonService(IGenericRepository repository)
        {
            _repository = repository;
           
        }
        public  List<Person> GetAll()
        {
            return _repository.GetEntities<Person>().Select(x => x).ToList();
        }
        public  void Add(Person objectParam)
        {
            if (objectParam == null) return;
            _repository.Add(objectParam);
            _repository.SaveChanges();
        }
        public  Person GetById(int id)
        {
            var entry = _repository.GetEntities<Person>().FirstOrDefault(x => x.PersonId == id);
            return entry;
        }

        public  void Remove(int id)
        {
            if (id >= 0)
            {
                var entry = _repository.GetEntities<Person>().FirstOrDefault(x => x.PersonId == id);
                if (entry != null)
                {
                    _repository.Remove(entry);
                    _repository.SaveChanges();
                }
            }
        }

        public  void Update(int existingId)
        {
            var destination = _repository.GetEntities<Person>().FirstOrDefault(x => x.PersonId == existingId);
            _repository.Update(destination);
            _repository.SaveChanges();
        }
    }
}
