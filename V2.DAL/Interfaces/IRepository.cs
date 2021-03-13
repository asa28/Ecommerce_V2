using System.Collections.Generic;
using V2.DAL.InfraStructure;

namespace V2.DAL.Interfaces
{
    public interface IRepository<T> where T :BaseEntity
    {
        void Add(T p);
        void Edit(T p);
        void Remove(int Id);
        IEnumerable<T> GetAllEntities();
        T FindById(int Id);
    }
}