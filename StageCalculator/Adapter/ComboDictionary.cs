using StageCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StageCalculator.Adapter
{
   public class ComboDictionary
    {
        private Repositories.BaseOperation OperationCRUD;
        public Dictionary<string, object> Dictionar;

        public ComboDictionary()
        {
            OperationCRUD = new Repositories.BaseOperation();
            Dictionar = new Dictionary<string, object>();

        }
        public void FillDictionar<T>() where T : class, IClassIDandName
        {
            Dictionar.Clear();
            var ClassEntity = OperationCRUD.GetAll<T>().Select(x => x);
            foreach (var item in ClassEntity)
            {
                SaveLocal(item.GetName(), item);
            }
        }

        public void Delete<T>(T Value) where T: class
        {
            if(Dictionar.ContainsValue(Value))
            {
                OperationCRUD.Remove(Value);
                OperationCRUD.Save();
                var itemToRemove = Dictionar.First(x => x.Value == Value);
                Dictionar.Remove(itemToRemove.Key);
            }
        }
        public void Update<T>( T Value) where T : class
        {
            if (Dictionar.ContainsValue(Value))
            {
                
                OperationCRUD.Update(Value);
                OperationCRUD.Save();
                var itemToUpdate = Dictionar.First(x => x.Value == Value).Key;
                Dictionar[itemToUpdate] = Value;
            }
        }

        private void SaveLocal<T>(string key, T value) where T : class
        {
            if (!Dictionar.Keys.Contains(key,StringComparer.InvariantCulture))
            {
                Dictionar.Add(key, value);
            }
            
        }
        public void Add<T>(string key, T value) where T : class
        {
            if (!Dictionar.ContainsKey(key))
            {
                OperationCRUD.Add(value);
                OperationCRUD.Save();
                
            }
            else
            {
                MessageBox.Show("Value already exist: Please enter another value");
            }

        }


        public T GetObjectByName<T>(string ValueParam) where T : class
        {
            if (Dictionar.TryGetValue(ValueParam, out object EntityObject))
            {
                return EntityObject as T;
            }
            else
            {
                return null;
            }
            // return  Dictionar[ValueParam] as T;
            // return Dictionar.FirstOrDefault(x=>x.Key==ValueParam) as T;
        }

    }// EndClass

}//EndNamespace
