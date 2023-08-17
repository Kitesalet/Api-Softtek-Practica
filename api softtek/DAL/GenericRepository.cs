using api_softtek.Common_Layer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_softtek.DAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {

            _context = context;

        }

        public int Create(T entity)
        {
           
           _context.Add(entity);

            _context.SaveChanges();

            return 1;

        }

        public bool Delete(int id)
        {

            

            T obj = _context.Set<T>().Find(id);

            if(obj == null)
            {
                return false;
            }

            _context.Remove(obj);
            

            _context.SaveChanges();

            return true;

        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
           
            T obj = _context.Set<T>().Where(e => e.Id == id).FirstOrDefault();

            return obj;


        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public bool Update(T entity)
        {

            var x = GetById(entity.Id);

            _context.Entry(x).State = EntityState.Detached;


            _context.Update(entity);

            _context.SaveChanges();

            return true;


        }
    }
}
