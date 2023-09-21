using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buoi_toi.service
{
    public interface IBaseCRUD<T>
    {
        public ArrayList FindAll();

        public void Create(T t);

        public void Update(T t);

        public void Delete(int id);
    }
}