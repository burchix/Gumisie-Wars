using GummyBears.DTO.Interfaces;

namespace GummyBears.DAL.Interfaces
{
    public interface IBaseRepository<TDBModel, TModel>
        where TDBModel : class, IObjWithId
        where TModel : class
    {
        TModel GetById(int id);

        TModel[] GetAll();

        int Create(TModel model);

        void Update(TModel model);

        void Delete(int id);
    }
}
