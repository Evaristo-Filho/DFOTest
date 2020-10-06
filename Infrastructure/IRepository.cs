using DFOTest.Entities;
using System;
using System.Collections.Generic;

namespace Infrastructure
{
    public interface IRepository<T>
    {
        T Get(int id);
        List<T> GetAll();
        int Update(T entity);
        int Insert(T entity);
    }
}
