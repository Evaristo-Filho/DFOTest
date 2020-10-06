using DFOTest.Entities;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFOTest.Infrastructure
{
    public class UserRepository : IRepository<IUser>
    {
        private static List<IUser> repository;
        public UserRepository()
        {
            repository = new List<IUser>();
        }
        public IUser Get(int id)
        {
            return repository.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<IUser> GetAll()
        {
            return repository;
        }

        public int Insert(IUser entity)
        {
            if (repository.Exists(x => x.Id == entity.Id))
                return -1;
            repository.Add(entity);
            return 0;
        }

        public int Update(IUser entity)
        {
            var item = repository.FindIndex(x=>x.Id== entity.Id);
            if (item == -1)
                return -1;
            repository[item] = entity;
            return 0;
        }
    }
}
