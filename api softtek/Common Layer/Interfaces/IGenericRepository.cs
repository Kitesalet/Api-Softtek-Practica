using api_softtek.DAL;

namespace api_softtek.Common_Layer.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {

        public IEnumerable<T> GetAll();

        public T GetById(int id);

        public int Create(T entity);

        public bool Update(T entity);

        public bool Delete(int id);

        public void SaveChanges();

    }
}
