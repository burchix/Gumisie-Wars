using AutoMapper;
using GummyBears.Common.Interfaces;
using GummyBears.DAL.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;

namespace GummyBears.DAL.Repositories
{
    public abstract class BaseRepository<TDBModel, TModel> : IBaseRepository<TDBModel, TModel>
        where TDBModel : class, IObjWithId
        where TModel : class, IObjWithId
    {
        protected DbContext _dbContext { get; }
        protected DbSet<TDBModel> _dbSet { get; }
        protected IMapper _mapper { get; }

        public BaseRepository(DbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TDBModel>();
            _mapper = mapper;
        }

        public virtual int Create(TModel model)
        {
            TDBModel dbModel = _mapper.Map<TDBModel>(model);
            _dbSet.Add(dbModel);
            _dbContext.SaveChanges();
            return dbModel.Id;
        }

        public virtual void Update(TModel model)
        {
            TDBModel dbModel = _dbSet.Find(model.Id);
            dbModel = _mapper.Map(model, dbModel);
            _dbContext.Entry(dbModel).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            TDBModel entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public virtual TModel[] GetAll()
        {
            var collection = BuildQuery(_dbSet).AsNoTracking().ToList();
            return collection.Select(m => _mapper.Map<TModel>(m)).ToArray();
        }

        public virtual TModel GetById(int id)
        {
            TDBModel dbModel = BuildQuery(_dbSet).AsNoTracking().SingleOrDefault(x => x.Id == id);
            if (dbModel == null) return null;
            return _mapper.Map<TModel>(dbModel);
        }

        protected IQueryable<TDBModel> GetQuery() => BuildQuery(_dbSet);

        protected abstract IQueryable<TDBModel> BuildQuery(IQueryable<TDBModel> query);
    }
}
