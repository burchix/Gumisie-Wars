using GummyBears.DAL.Interfaces;
using GummyBears.DTO.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace GummyBears.DAL.Repositories
{
    public abstract class BaseRepository<DBModel, ServiceModel> : IBaseRepository<DBModel, ServiceModel>
           where DBModel : class, IObjWithId
           where ServiceModel : class
    {
        protected DbContext _dbContext { get; }
        protected DbSet<DBModel> _dbSet { get; }

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<DBModel>();
        }

        public int Create(ServiceModel model)
        {
            DBModel dbModel = FromModelToDB(model);
            _dbSet.Add(dbModel);
            _dbContext.SaveChanges();
            return dbModel.Id;
        }

        public void Update(ServiceModel model)
        {
            _dbContext.Entry(model).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            DBModel entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public ServiceModel[] GetAll()
        {
            return _dbSet.Select(m => FromDBToModel(m)).ToArray();
        }

        public ServiceModel GetById(int id)
        {
            return FromDBToModel(_dbSet.Find(id));
        }

        public abstract ServiceModel FromDBToModel(DBModel dbModel);

        public abstract DBModel FromModelToDB(ServiceModel model);
    }
}
