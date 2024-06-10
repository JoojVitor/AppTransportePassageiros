using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBaseRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity)where T : class;
        void Delete<T>(T entity) where T: class;
        bool SaveChanges();
    }
}
