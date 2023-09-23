using System.Collections;

namespace buoi_toi.service
{
    public interface IBaseCRUD<T>
    {
        public List<T> FindAll();

        public void Create(T t);

        public void Update(T t);

        public void Delete(int id);
    }
}