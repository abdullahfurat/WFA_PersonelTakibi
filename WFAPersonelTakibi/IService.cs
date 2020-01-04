using System;
using System.Collections.Generic;

namespace WFAPersonelTakibi
{
    public interface IService<T>
    { 
        void Add(T entity);

        bool Delete(T entity);

        List<T> GetAll();

        T GetById(Guid id);

        void Update(T entity);
    }
}
// Generic Repository Design Patter Nedir ?