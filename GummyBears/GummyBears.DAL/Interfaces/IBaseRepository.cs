using GummyBears.Common.Interfaces;

namespace GummyBears.DAL.Interfaces
{
    public interface IBaseRepository<TDBModel, TModel>
        where TDBModel : class, IObjWithId
        where TModel : class, IObjWithId
    {
        TModel GetById(int id);

        TModel[] GetAll();

        int Create(TModel model);

        void Update(TModel model);

        void Delete(int id);
    }
}
