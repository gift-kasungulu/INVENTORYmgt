using inventoryManagement.DbContextclass;
using InventoryManagement.Interfaces;

namespace InventoryManagement.Implimentation
{
    public class GImplimentation<T>: GInterface<T> where T : class
    {
        readonly IDbcontext context;
        protected IQueryable<T> Entities { get => context.Set<T>(); }
        public GImplimentation(IDbcontext context)
        {
            this.context= context;
        }
        public bool Add(T entity)
        {
            try {
                context.Set<T>().Add( entity);
                return context.SaveChanges() !=0;
            }
            catch{
                return false;
            
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                context.Set<T>().Remove(entity);
                return context.SaveChanges() != 0;
            }
            catch
            {
                return false;

            }

        }

        public bool Update(T entity)
        {
            try
            {
                context.Set<T>().Update(entity);
                return context.SaveChanges() != 0;
            }
            catch
            {
                return false;

            }
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

       
    }
}
